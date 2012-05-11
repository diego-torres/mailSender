Imports System.IO
Imports System.IO.Packaging
Imports System.Net.Mail
Imports System.Net.Mime

Public Class CMailer
    Public Sub Send_Email(ByVal config As MailerConfig, _
                                 ByVal details As EmailDetails)
        ' Read File
        Dim b As Byte() = Read_File(details.Attachment_path)
        Dim fileName As String = Path.GetFileName(details.Attachment_path).Replace(" ", "_")

        ' Zip File
        Dim ms As New MemoryStream()
        Dim zip As Package = ZipPackage.Open(ms, IO.FileMode.Create)
        zipFile(zip, b, fileName)
        zip.Close()

        ' Create Email
        Dim msg As MailMessage = Create_Email(details)
        msg.From = New MailAddress(config.From_Email)

        ' Create Attachment with zip memory stream
        Dim ct As New ContentType()
        ct.MediaType = MediaTypeNames.Application.Zip
        ct.Name = Path.GetFileNameWithoutExtension(fileName) & ".zip"

        ms.Seek(0, SeekOrigin.Begin)
        Dim att As New Attachment(ms, ct)

        msg.Attachments.Add(att)

        ' Connect and send through smtp
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential(config.User_Name, config.Password)
        SmtpServer.Host = config.Host
        SmtpServer.Port = config.Port
        SmtpServer.EnableSsl = config.SSL

        SmtpServer.Send(msg)

        ms.Close()
        ms.Dispose()
    End Sub

#Region "CMailer_Private_members"

    Private Function Read_File(ByVal fileName As String) As Byte()
        If Not File.Exists(fileName) Then
            Throw New MailerException("File Not Found: [" & fileName & "]")
        End If

        Try
            Using fs As FileStream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
                Read_File = New Byte((fs.Length) - 1) {}
                Dim bytesToRead As Integer = CType(fs.Length, Integer)
                Dim bytesRead As Integer = 0

                While (bytesToRead > 0)
                    Dim n As Integer = fs.Read(Read_File, bytesRead, bytesToRead)
                    ' Check EOF To break the look
                    If n = 0 Then
                        Exit While
                    End If

                    bytesRead = bytesRead + n
                    bytesToRead = bytesToRead - n
                End While

            End Using
        Catch ex As Exception
            Throw New MailerException("Exception while reading the file [" & _
                                      fileName & "]: [" & ex.Message & "]", ex)
        End Try

    End Function

    Private Sub zipFile(ByRef zip As Package, ByVal fBytes As Byte(), ByVal fileName As String)
        Dim zipUri As String = String.Concat("/", fileName)
        Dim partUri As New Uri(zipUri, UriKind.Relative)
        Dim contentType As String = Net.Mime.MediaTypeNames.Application.Zip

        Dim pkgPart As PackagePart = zip.CreatePart(partUri, contentType, CompressionOption.Normal)
        pkgPart.GetStream().Write(fBytes, 0, fBytes.Length)
    End Sub

    Private Function Create_Email(ByRef details As EmailDetails) As MailMessage
        Create_Email = New MailMessage()
        Create_Email.To.Add(details.Email_to)

        If (details.Email_cc.Trim() <> "") Then
            Create_Email.CC.Add(details.Email_cc)
        End If

        Create_Email.Subject = details.Email_subject
        Create_Email.Body = details.Email_body
    End Function

#End Region

End Class

Public Class EmailDetails

#Region "EmailDetails_fields"

    Dim _to As String
    Dim _cc As String
    Dim _subject As String
    Dim _body As String
    Dim _attachment_path As String

#End Region

#Region "EmailDetails_properties"

    ''' <summary>
    ''' Gets or sets the email to property
    ''' </summary>
    ''' <value>email address to send the email</value>
    ''' <remarks>valid email address in address@server.domain format.</remarks>
    Public Property Email_to As String
        Get
            Return _to
        End Get
        Set(value As String)
            _to = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the email cc property
    ''' </summary>
    ''' <value>email address to copy the email</value>
    ''' <remarks>valid email address in address@server.domain format.</remarks>
    Public Property Email_cc As String
        Get
            Return _cc
        End Get
        Set(value As String)
            _cc = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the email's subject
    ''' </summary>
    ''' <value>Subject to be applied in email</value>
    Public Property Email_subject As String
        Get
            Return _subject
        End Get
        Set(value As String)
            _subject = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the email's body
    ''' </summary>
    ''' <value>Email content, plain text.</value>
    Public Property Email_body As String
        Get
            Return _body
        End Get
        Set(value As String)
            _body = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the attachment path to be included in the email.
    ''' </summary>
    ''' <value>full path to find the attachment to be included.</value>
    ''' <remarks>application should have read access to the attachment's path.</remarks>
    Public Property Attachment_path As String
        Get
            Return _attachment_path
        End Get
        Set(value As String)
            _attachment_path = value
        End Set
    End Property

#End Region

End Class

Public Class MailerConfig

#Region "MailerConfig_fields"

    Dim _from_email As String
    Dim _user_name As String
    Dim _password As String
    Dim _host As String
    Dim _port As Long
    Dim _ssl As Boolean = False

#End Region

#Region "MailerConfig_properties"

    ''' <summary>
    ''' Gets or sets the email from property
    ''' </summary>
    ''' <value>The email remitent address.</value>
    ''' <remarks>valid email address in address@server.domain format.</remarks>
    Public Property From_Email As String
        Get
            Return _from_email
        End Get
        Set(value As String)
            _from_email = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the user name to connect to the smtp server.
    ''' </summary>
    ''' <value>User name for the smtp server</value>
    ''' <remarks>Generally the user name is the email address.</remarks>
    Public Property User_Name As String
        Get
            Return _user_name
        End Get
        Set(value As String)
            _user_name = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the password to log in the smtp server.
    ''' </summary>
    ''' <value>Password for the smtp server</value>
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the host property for the smtp server.
    ''' </summary>
    ''' <value>Host name or ip for smtp server connection.</value>
    Public Property Host As String
        Get
            Return _host
        End Get
        Set(value As String)
            _host = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the port property for the smtp server.
    ''' </summary>
    ''' <value>Port number for smtp server connection.</value>
    Public Property Port As Long
        Get
            Return _port
        End Get
        Set(value As Long)
            _port = value
        End Set
    End Property

    ''' <summary>
    ''' States wheather should use SSL on smtp server connection.
    ''' </summary>
    ''' <value>true for ssl usage on smtp server connection.</value>
    ''' <remarks>defaulted to false.</remarks>
    Public Property SSL As Boolean
        Get
            Return _ssl
        End Get
        Set(value As Boolean)
            _ssl = value
        End Set
    End Property

#End Region

End Class

Public Class MailerException
    Inherits Exception

    Sub New(ByVal ErrMsg As String)
        MyBase.New(ErrMsg)
    End Sub

    Sub New(ByVal ErrMsg As String, ByVal innerException As Exception)
        MyBase.New(ErrMsg, innerException)
    End Sub

End Class


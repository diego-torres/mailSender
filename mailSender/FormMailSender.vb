Imports System.Text.RegularExpressions
Imports dtorres.Mailer

Public Class FormMailSender

    Private Sub ButtonBrowse_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBrowse.Click

        OpenFileDialogAttachment.FileName = ""

        Dim dr As DialogResult = OpenFileDialogAttachment.ShowDialog()
        If (dr = Windows.Forms.DialogResult.OK) Then
            TextBoxAttachmentPath.Text = OpenFileDialogAttachment.FileName
        End If

    End Sub

    Private Sub ButtonSend_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSend.Click

        If Not Validate_Configuration() Then
            MessageBox.Show("Email configuration is not well formed", "Email Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Validate_Email() Then
            MessageBox.Show("Email details are not well formed", "Email Details Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Cursor = Cursors.WaitCursor
        Try
            Dim mailer As New CMailer()
            mailer.Send_Email(Get_Mailer_Config(), Get_Email_Details())
            MessageBox.Show("Email successfully sent", "Fine", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clean_Details()
        Catch ex As Exception
            MessageBox.Show("Unable to send the email due to the following exception:" & _
                            vbCr & ex.Message, "Error Sending Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

#Region "method_helpers"

    Private Function Get_Mailer_Config() As MailerConfig
        Dim config As New MailerConfig()

        config.From_Email = TextBoxEmail.Text
        config.Host = TextBoxHost.Text
        config.Password = TextBoxPassword.Text
        config.Port = Long.Parse(TextBoxPort.Text)
        config.SSL = CheckBoxSSL.Checked
        config.User_Name = TextBoxUserName.Text

        Return config
    End Function

    Private Function Get_Email_Details() As EmailDetails
        Dim details As New EmailDetails()

        details.Attachment_path = TextBoxAttachmentPath.Text
        details.Email_body = TextBoxBody.Text
        details.Email_cc = TextBoxCc.Text
        details.Email_subject = TextBoxSubject.Text
        details.Email_to = TextBoxTo.Text

        Return details
    End Function

    Private Sub Clean_Details()
        TextBoxAttachmentPath.Text = ""
        TextBoxTo.Text = ""
        TextBoxCc.Text = ""
        TextBoxSubject.Text = ""
        TextBoxBody.Text = ""
    End Sub

    Private Function Validate_Email() As Boolean
        Validate_Email = True
        If Not Is_Email(TextBoxTo.Text) Or TextBoxSubject.Text = "" Then
            Validate_Email = False
        End If
        If TextBoxCc.Text <> "" And Not Is_Email(TextBoxCc.Text) Then
            Validate_Email = False
        End If
    End Function

    Private Function Validate_Configuration() As Boolean
        Validate_Configuration = True

        If Not Is_Email(TextBoxEmail.Text) Then
            Return False
        End If

        If TextBoxUserName.Text = "" Then
            Return False
        End If

        If TextBoxPassword.Text = "" Then
            Return False
        End If

        If TextBoxHost.Text = "" Then
            Return False
        End If

        If TextBoxPort.Text = "" Or Not IsNumeric(TextBoxPort.Text) Then
            Return False
        End If

    End Function

    Private Function Is_Email(ByVal value As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim patternMatch As Match = Regex.Match(value, pattern)

        Is_Email = patternMatch.Success
    End Function

#End Region
End Class

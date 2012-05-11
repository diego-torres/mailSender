<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMailSender
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMailSender))
        Me.OpenFileDialogAttachment = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxBody = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonSend = New System.Windows.Forms.Button()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.TextBoxAttachmentPath = New System.Windows.Forms.TextBox()
        Me.TextBoxSubject = New System.Windows.Forms.TextBox()
        Me.TextBoxCc = New System.Windows.Forms.TextBox()
        Me.TextBoxTo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBoxSSL = New System.Windows.Forms.CheckBox()
        Me.TextBoxPort = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxHost = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialogAttachment
        '
        Me.OpenFileDialogAttachment.FileName = "OpenFileDialog1"
        Me.OpenFileDialogAttachment.Filter = "word files|*.doc|2010 word files|*.docx|PDF Files|*.pdf|All files|*.*"
        Me.OpenFileDialogAttachment.FilterIndex = 3
        Me.OpenFileDialogAttachment.InitialDirectory = "~/Documents"
        Me.OpenFileDialogAttachment.Title = "Mail Attachment"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(507, 345)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(499, 319)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "E Mail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxBody)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 140)
        Me.Panel2.TabIndex = 1
        '
        'TextBoxBody
        '
        Me.TextBoxBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxBody.Location = New System.Drawing.Point(0, 0)
        Me.TextBoxBody.Multiline = True
        Me.TextBoxBody.Name = "TextBoxBody"
        Me.TextBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxBody.Size = New System.Drawing.Size(493, 140)
        Me.TextBoxBody.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonSend)
        Me.Panel1.Controls.Add(Me.ButtonBrowse)
        Me.Panel1.Controls.Add(Me.TextBoxAttachmentPath)
        Me.Panel1.Controls.Add(Me.TextBoxSubject)
        Me.Panel1.Controls.Add(Me.TextBoxCc)
        Me.Panel1.Controls.Add(Me.TextBoxTo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 173)
        Me.Panel1.TabIndex = 0
        '
        'ButtonSend
        '
        Me.ButtonSend.Location = New System.Drawing.Point(77, 19)
        Me.ButtonSend.Name = "ButtonSend"
        Me.ButtonSend.Size = New System.Drawing.Size(75, 44)
        Me.ButtonSend.TabIndex = 0
        Me.ButtonSend.Text = "&Send"
        Me.ButtonSend.UseVisualStyleBackColor = True
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Location = New System.Drawing.Point(364, 145)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowse.TabIndex = 9
        Me.ButtonBrowse.Text = "&Browse"
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'TextBoxAttachmentPath
        '
        Me.TextBoxAttachmentPath.Location = New System.Drawing.Point(77, 147)
        Me.TextBoxAttachmentPath.Name = "TextBoxAttachmentPath"
        Me.TextBoxAttachmentPath.Size = New System.Drawing.Size(281, 20)
        Me.TextBoxAttachmentPath.TabIndex = 8
        '
        'TextBoxSubject
        '
        Me.TextBoxSubject.Location = New System.Drawing.Point(77, 119)
        Me.TextBoxSubject.Name = "TextBoxSubject"
        Me.TextBoxSubject.Size = New System.Drawing.Size(362, 20)
        Me.TextBoxSubject.TabIndex = 6
        '
        'TextBoxCc
        '
        Me.TextBoxCc.Location = New System.Drawing.Point(77, 95)
        Me.TextBoxCc.Name = "TextBoxCc"
        Me.TextBoxCc.Size = New System.Drawing.Size(362, 20)
        Me.TextBoxCc.TabIndex = 4
        '
        'TextBoxTo
        '
        Me.TextBoxTo.Location = New System.Drawing.Point(77, 69)
        Me.TextBoxTo.Name = "TextBoxTo"
        Me.TextBoxTo.Size = New System.Drawing.Size(362, 20)
        Me.TextBoxTo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Attachment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "S&ubject:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Cc:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&To:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBoxEmail)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.CheckBoxSSL)
        Me.TabPage2.Controls.Add(Me.TextBoxPort)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TextBoxHost)
        Me.TabPage2.Controls.Add(Me.TextBoxPassword)
        Me.TabPage2.Controls.Add(Me.TextBoxUserName)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(499, 319)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configuration"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(108, 12)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(273, 20)
        Me.TextBoxEmail.TabIndex = 1
        Me.TextBoxEmail.Text = "your.email@gmail.com"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "&Email:"
        '
        'CheckBoxSSL
        '
        Me.CheckBoxSSL.AutoSize = True
        Me.CheckBoxSSL.Checked = True
        Me.CheckBoxSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSSL.Location = New System.Drawing.Point(108, 142)
        Me.CheckBoxSSL.Name = "CheckBoxSSL"
        Me.CheckBoxSSL.Size = New System.Drawing.Size(46, 17)
        Me.CheckBoxSSL.TabIndex = 10
        Me.CheckBoxSSL.Text = "&SSL"
        Me.CheckBoxSSL.UseVisualStyleBackColor = True
        '
        'TextBoxPort
        '
        Me.TextBoxPort.Location = New System.Drawing.Point(108, 116)
        Me.TextBoxPort.Name = "TextBoxPort"
        Me.TextBoxPort.Size = New System.Drawing.Size(273, 20)
        Me.TextBoxPort.TabIndex = 9
        Me.TextBoxPort.Text = "587"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(73, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "&Port:"
        '
        'TextBoxHost
        '
        Me.TextBoxHost.Location = New System.Drawing.Point(108, 90)
        Me.TextBoxHost.Name = "TextBoxHost"
        Me.TextBoxHost.Size = New System.Drawing.Size(273, 20)
        Me.TextBoxHost.TabIndex = 7
        Me.TextBoxHost.Text = "smtp.gmail.com"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(108, 64)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(273, 20)
        Me.TextBoxPassword.TabIndex = 5
        Me.TextBoxPassword.Text = "secret"
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(108, 38)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(273, 20)
        Me.TextBoxUserName.TabIndex = 3
        Me.TextBoxUserName.Text = "your.email@gmail.com"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "&Host:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "&Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "&User Name:"
        '
        'FormMailSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 345)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMailSender"
        Me.Text = "Mail Sender"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxBody As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBoxAttachmentPath As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSubject As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCc As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSend As System.Windows.Forms.Button
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSSL As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxPort As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHost As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogAttachment As System.Windows.Forms.OpenFileDialog

End Class

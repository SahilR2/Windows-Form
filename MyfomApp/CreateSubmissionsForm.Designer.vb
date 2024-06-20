<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        btnToggleStopwatch = New Button()
        lblStopwatchTime = New Label()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(445, 20)
        Label1.TabIndex = 3
        Label1.Text = "Syed Shabiul Husain, Slidely Task 2 - Create New Submission Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 6
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(77, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 8
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(77, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 40)
        Label5.TabIndex = 9
        Label5.Text = "Github Link " & vbCrLf & "For Task 2"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(252, 81)
        txtName.Name = "txtName"
        txtName.Size = New Size(493, 27)
        txtName.TabIndex = 11
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(252, 129)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(493, 27)
        txtEmail.TabIndex = 12
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(252, 186)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(493, 27)
        txtPhoneNum.TabIndex = 13
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(252, 254)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(493, 27)
        txtGithubLink.TabIndex = 14
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.LightGoldenrodYellow
        btnToggleStopwatch.FlatStyle = FlatStyle.Popup
        btnToggleStopwatch.Location = New Point(77, 324)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(281, 52)
        btnToggleStopwatch.TabIndex = 15
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.BackColor = SystemColors.ControlLight
        lblStopwatchTime.BorderStyle = BorderStyle.Fixed3D
        lblStopwatchTime.FlatStyle = FlatStyle.Popup
        lblStopwatchTime.Location = New Point(397, 324)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(348, 52)
        lblStopwatchTime.TabIndex = 16
        lblStopwatchTime.Text = "00:00:00"
        lblStopwatchTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SkyBlue
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Location = New Point(77, 386)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(668, 52)
        btnSubmit.TabIndex = 17
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "CreateSubmissionsForm"
        Text = "Create Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnSubmit As Button
End Class

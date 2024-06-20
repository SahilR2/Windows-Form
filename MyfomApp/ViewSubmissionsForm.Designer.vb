<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Timer1 = New Timer(components)
        Label8 = New Label()
        Label7 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 20)
        Label1.TabIndex = 3
        Label1.Text = "Syed Shabiul Husain, Slidely Task 2 - View Submission Form"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.AutoEllipsis = True
        Button1.BackColor = Color.LightGoldenrodYellow
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(77, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(292, 60)
        Button1.TabIndex = 4
        Button1.Text = "Previous (CTRL + P)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.AutoEllipsis = True
        Button2.BackColor = Color.SkyBlue
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(375, 377)
        Button2.Name = "Button2"
        Button2.Size = New Size(303, 60)
        Button2.TabIndex = 5
        Button2.Text = "Next (CTRL + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 0
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(77, 317)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 40)
        Label6.TabIndex = 10
        Label6.Text = "Stopwatch" & vbCrLf & "time"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(252, 81)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(493, 27)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(252, 129)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(493, 27)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(252, 186)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(493, 27)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(252, 254)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(493, 27)
        TextBox4.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(77, 81)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 20)
        Label8.TabIndex = 6
        Label8.Text = "Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(274, 327)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 20)
        Label7.TabIndex = 15
        Label7.Text = "00:00:00"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkSalmon
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(77, 443)
        Button3.Name = "Button3"
        Button3.Size = New Size(601, 29)
        Button3.TabIndex = 16
        Button3.Text = "Delete (CTRL+ D)"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(789, 484)
        Controls.Add(Button3)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
End Class

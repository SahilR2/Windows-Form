Public Class Form1
    Public Sub New()
        InitializeComponent()
        MsgBox("Syed Shabiul Husain here, this is my Slidely AI task")
        CheckBackendStatus()
    End Sub

    Private Async Sub CheckBackendStatus()
        Dim isServerRunning As Boolean = Await ApiClient.PingAsync()
        If isServerRunning Then
            MessageBox.Show("Backend server is running.", "Server Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to connect to the backend server.", "Server Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open Form 2 (View Submissions Form)
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Open Form 3 (Create Submissions Form)
        Dim createSubmissionForm As New CreateSubmissionsForm()
        createSubmissionForm.ShowDialog()
    End Sub
    Private Sub Formq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackColor = Color.LightGoldenrodYellow

        Button2.BackColor = Color.SkyBlue
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Trigger the Click event of the "Previous" button (Button1)
            Button1.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Trigger the Click event of the "Next" button (Button2)
            Button2.PerformClick()
        End If
    End Sub
End Class

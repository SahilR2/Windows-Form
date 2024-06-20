Imports System.Diagnostics
Public Class CreateSubmissionsForm
    Private stopwatch As New Stopwatch()
    Private WithEvents timer As New Timer()

    Public Sub New()
        InitializeComponent()

        ' Start the timer to update the stopwatch display
        timer.Interval = 1000 ' Update every second
        timer.Start()

        ' Start the stopwatch when the form is opened
        stopwatch.Start()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Update the stopwatch time display
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhoneNum.Text
        Dim github_link As String = txtGithubLink.Text
        Dim stopwatch_time As String = lblStopwatchTime.Text

        ' Perform validation (simple example)
        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(phone) OrElse String.IsNullOrWhiteSpace(github_link) Then
            MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save the submission by calling the backend API
        Dim success As Boolean = Await ApiClient.SubmitFormAsync(name, email, phone, github_link, stopwatch_time)
        If success Then
            MessageBox.Show("Submission saved successfully!", "Submission Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to save submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        ' Stop the stopwatch and reset it to 0
        stopwatch.Reset()

        ' Clear the form for new input
        txtName.Clear()
        txtEmail.Clear()
        txtPhoneNum.Clear()
        txtGithubLink.Clear()
        lblStopwatchTime.Text = "00:00:00"

        ' Restart the stopwatch for the next submission
        stopwatch.Start()
    End Sub


    Private Sub CreateSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ' Toggle the stopwatch
            btnToggleStopwatch.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Trigger the Click event of the "Submit" button
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub CreateSubmissionsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Enable KeyPreview for the form to capture key events
        Me.KeyPreview = True
    End Sub

    Private Sub CreateSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnToggleStopwatch.BackColor = Color.LightGoldenrodYellow

        btnSubmit.BackColor = Color.SkyBlue
    End Sub
End Class

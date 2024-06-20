Imports System.Diagnostics
Imports MyfomApp.CreateSubmissionsForm
Imports Newtonsoft.Json


Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0



    Public Sub New()
        InitializeComponent()
        ' Enable KeyPreview for the form to capture key events
        Me.KeyPreview = True

        LoadSubmission(currentIndex)
        ' Display the first submission if available




    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Dim response As String = Await ApiClient.ReadSubmissionAsync(index)
        Debug.WriteLine("Received JSON response: " & response) ' Log JSON response for debugging

        If Not String.IsNullOrEmpty(response) Then
            Try
                Dim submissionResponse As SubmissionResponse = JsonConvert.DeserializeObject(Of SubmissionResponse)(response)
                Debug.WriteLine("Deserialized submission response object: " & JsonConvert.SerializeObject(submissionResponse)) ' Log deserialized object

                If submissionResponse IsNot Nothing AndAlso submissionResponse.success AndAlso submissionResponse.submission IsNot Nothing Then
                    Dim submission As Submission = submissionResponse.submission
                    TextBox1.Text = submission.name
                    TextBox2.Text = submission.email
                    TextBox3.Text = submission.phone  ' Phone number
                    TextBox4.Text = submission.github_link
                    Label7.Text = submission.stopwatch_time
                Else
                    MessageBox.Show("Submission not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                Debug.WriteLine("Deserialization error: " & ex.Message)
                MessageBox.Show("Error deserializing submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Submission not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the background color of the buttons
        Button1.BackColor = Color.LightGoldenrodYellow

        Button2.BackColor = Color.SkyBlue

    End Sub

    Private Sub ViewSubmissionsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Enable KeyPreview for the form to capture key events
        Me.KeyPreview = True
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Trigger the Click event of the "Previous" button (btnPrevious)
            Button1.PerformClick()
        End If

        ' Check if Ctrl + N is pressed for "Next" button
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Trigger the Click event of the "Next" button (btnNext)
            Button2.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentIndex += 1
        LoadSubmission(currentIndex)

    End Sub


End Class



Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ApiClient
    Private Shared ReadOnly client As New HttpClient()

    Public Shared Async Function PingAsync() As Task(Of Boolean)
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/ping")
            Return response.IsSuccessStatusCode
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Method to submit a form
    Public Shared Async Function SubmitFormAsync(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of Boolean)
        Dim formData As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", githubLink},
            {"stopwatch_time", stopwatchTime}
        }
        Dim jsonContent As String = JsonConvert.SerializeObject(formData)
        Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
        Return response.IsSuccessStatusCode
    End Function

    ' Method to read a submission by index
    Public Shared Async Function ReadSubmissionAsync(index As Integer) As Task(Of String)
        Dim requestUri As String = $"http://localhost:3000/read?index={index}"
        Debug.WriteLine($"Sending GET request to: {requestUri}")

        Dim response As HttpResponseMessage = Await client.GetAsync(requestUri)
        If response.IsSuccessStatusCode Then
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            Debug.WriteLine($"Received response: {responseData}")
            Return responseData
        Else
            Debug.WriteLine($"Failed to fetch submission data. Status code: {response.StatusCode}")
            Return Nothing
        End If
    End Function
End Class

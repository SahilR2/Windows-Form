﻿Public Class SubmissionResponse
    Public Property success As Boolean
    Public Property submission As Submission
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
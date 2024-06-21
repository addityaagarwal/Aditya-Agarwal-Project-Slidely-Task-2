Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ApiHelper
    Private Shared ReadOnly client As New HttpClient()
    Public Shared Async Function PingServer() As Task(Of Boolean)
        Dim response = Await client.GetAsync("http://localhost:3000/ping")
        Return response.IsSuccessStatusCode
    End Function

    Public Shared Async Function SubmitForm(submission As Submission) As Task
        Dim json = JsonConvert.SerializeObject(submission)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
        response.EnsureSuccessStatusCode()
    End Function

    Public Shared Async Function ReadSubmission(index As Integer) As Task(Of Submission)
        Dim response = Await client.GetAsync($"http://localhost:3000/read?index={index}")
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of Submission)(json)
    End Function

    Public Shared Async Function GetAllSubmissions() As Task(Of List(Of Submission))
        Dim response = Await client.GetAsync("http://localhost:3000/read_all")
        response.EnsureSuccessStatusCode()
        Dim responseData = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of List(Of Submission))(responseData)
    End Function
End Class

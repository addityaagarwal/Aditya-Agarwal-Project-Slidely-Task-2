Public Class Form2

    Private submissions As New List(Of Submission)()
    Private currentIndex As Integer = 0
    Private currentSubmissionIndex As Integer = 0

    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await LoadSubmission(currentSubmissionIndex)
        Await LoadAllSubmissions()
        If submissions.Count > 0 Then
            Await LoadSubmission(currentIndex)
        Else
            MessageBox.Show("No submissions found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Async Function LoadAllSubmissions() As Task
        Try
            ' Assuming you have a method to get all submissions
            submissions = Await ApiHelper.GetAllSubmissions()
            If submissions.Count = 0 Then
                MessageBox.Show("No submissions retrieved from the server.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading submissions: {ex.Message}")
        End Try
    End Function

    Private Async Function LoadSubmission(index As Integer) As Task
        Try
            Dim submission = Await ApiHelper.ReadSubmission(index)
            If NameInput IsNot Nothing Then NameInput.Text = submission.Name
            If EmailInput IsNot Nothing Then EmailInput.Text = submission.Email
            If PhoneNumInput IsNot Nothing Then PhoneNumInput.Text = submission.Phone
            If GitHubInput IsNot Nothing Then GitHubInput.Text = submission.GitHubLink
            If StopwatchInput IsNot Nothing Then StopwatchInput.Text = submission.StopwatchTime

        Catch ex As Exception
            MessageBox.Show($"Error loading submission: {ex.Message}")
        End Try
    End Function

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentSubmissionIndex = currentSubmissionIndex + 1
            Await LoadSubmission(currentSubmissionIndex)
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            Await LoadSubmission(currentSubmissionIndex)
        End If
    End Sub


    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        End If
    End Sub



    Private Function LoadSubmissions() As List(Of Submission)
        ' Placeholder for loading submissions from a data source
        Return New List(Of Submission)() ' Replace with actual data loading logic
    End Function
End Class
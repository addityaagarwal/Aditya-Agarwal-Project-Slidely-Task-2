Public Class Form3
    Private stopwatch As New Stopwatch()
    Private submissionList As List(Of Submission)
    Private currentIndex As Integer = -1

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.KeyPreview = True
        ' Add any initialization after the InitializeComponent() call.
        submissionList = New List(Of Submission)()
    End Sub


    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchTime()
    End Sub

    Private Sub UpdateStopwatchTime()
        StopwatchInput.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub


    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If NameInput IsNot Nothing AndAlso EmailInput IsNot Nothing AndAlso PhoneNumInput IsNot Nothing AndAlso GitHubInput IsNot Nothing Then
            If String.IsNullOrWhiteSpace(NameInput.Text) OrElse
            String.IsNullOrWhiteSpace(EmailInput.Text) OrElse
            String.IsNullOrWhiteSpace(PhoneNumInput.Text) OrElse
            String.IsNullOrWhiteSpace(GitHubInput.Text) Then
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If


        Dim newSubmission As New Submission With {
            .Name = NameInput.Text,
            .Email = EmailInput.Text,
            .Phone = PhoneNumInput.Text,
            .GitHubLink = GitHubInput.Text,
            .StopwatchTime = StopwatchInput.Text
        }
        submissionList.Add(newSubmission)
        Try
            Await ApiHelper.SubmitForm(newSubmission)
            MessageBox.Show("Submission added successfully!")
        Catch ex As Exception
            MessageBox.Show($"Error submitting form: {ex.Message}")
        End Try
    End Sub


    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.T) Then
            btnToggleStopwatch.PerformClick()
        ElseIf (e.Control AndAlso e.KeyCode = Keys.S) Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submissionList = New List(Of Submission)()
        Me.KeyPreview = True
    End Sub


End Class
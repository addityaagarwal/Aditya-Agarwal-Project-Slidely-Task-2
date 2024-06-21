<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        LabelName = New Label()
        LabelEmail = New Label()
        LabelGithub = New Label()
        LabelPhoneNum = New Label()
        Label6 = New Label()
        NameInput = New TextBox()
        GitHubInput = New TextBox()
        EmailInput = New TextBox()
        PhoneNumInput = New TextBox()
        StopwatchInput = New TextBox()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.Location = New Point(200, 368)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(190, 30)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.Highlight
        btnNext.Location = New Point(410, 368)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(190, 30)
        btnNext.TabIndex = 1
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(200, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 20)
        Label1.TabIndex = 2
        Label1.Text = "Aditya Agarwal, Slidely Task 2 - View Submissions"
        ' 
        ' LabelName
        ' 
        LabelName.Location = New Point(200, 100)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(100, 27)
        LabelName.TabIndex = 3
        LabelName.Text = "Name"
        LabelName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelEmail
        ' 
        LabelEmail.Location = New Point(200, 150)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(100, 27)
        LabelEmail.TabIndex = 4
        LabelEmail.Text = "Email"
        LabelEmail.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelGithub
        ' 
        LabelGithub.Location = New Point(200, 243)
        LabelGithub.Name = "LabelGithub"
        LabelGithub.Size = New Size(100, 40)
        LabelGithub.TabIndex = 5
        LabelGithub.Text = "GitHub Link" & vbCrLf & "For Task 2"
        LabelGithub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPhoneNum
        ' 
        LabelPhoneNum.Location = New Point(200, 200)
        LabelPhoneNum.Name = "LabelPhoneNum"
        LabelPhoneNum.Size = New Size(100, 27)
        LabelPhoneNum.TabIndex = 6
        LabelPhoneNum.Text = "Phone Num"
        LabelPhoneNum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(200, 293)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 40)
        Label6.TabIndex = 7
        Label6.Text = "Stopwatch" & vbCrLf & "Time" & vbCrLf
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NameInput
        ' 
        NameInput.Location = New Point(320, 100)
        NameInput.Name = "NameInput"
        NameInput.ReadOnly = True
        NameInput.Size = New Size(280, 27)
        NameInput.TabIndex = 8
        NameInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' GitHubInput
        ' 
        GitHubInput.AcceptsReturn = True
        GitHubInput.Location = New Point(320, 250)
        GitHubInput.Name = "GitHubInput"
        GitHubInput.ReadOnly = True
        GitHubInput.Size = New Size(280, 27)
        GitHubInput.TabIndex = 11
        GitHubInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' EmailInput
        ' 
        EmailInput.Location = New Point(320, 150)
        EmailInput.Name = "EmailInput"
        EmailInput.ReadOnly = True
        EmailInput.Size = New Size(280, 27)
        EmailInput.TabIndex = 9
        EmailInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' PhoneNumInput
        ' 
        PhoneNumInput.Location = New Point(320, 200)
        PhoneNumInput.Name = "PhoneNumInput"
        PhoneNumInput.ReadOnly = True
        PhoneNumInput.Size = New Size(280, 27)
        PhoneNumInput.TabIndex = 10
        PhoneNumInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' StopwatchInput
        ' 
        StopwatchInput.Location = New Point(320, 300)
        StopwatchInput.Name = "StopwatchInput"
        StopwatchInput.ReadOnly = True
        StopwatchInput.Size = New Size(280, 27)
        StopwatchInput.TabIndex = 12
        StopwatchInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StopwatchInput)
        Controls.Add(PhoneNumInput)
        Controls.Add(EmailInput)
        Controls.Add(GitHubInput)
        Controls.Add(NameInput)
        Controls.Add(Label6)
        Controls.Add(LabelPhoneNum)
        Controls.Add(LabelGithub)
        Controls.Add(LabelEmail)
        Controls.Add(LabelName)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelGithub As Label
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NameInput As TextBox
    Friend WithEvents GitHubInput As TextBox
    Friend WithEvents EmailInput As TextBox
    Friend WithEvents PhoneNumInput As TextBox
    Friend WithEvents StopwatchInput As TextBox
End Class
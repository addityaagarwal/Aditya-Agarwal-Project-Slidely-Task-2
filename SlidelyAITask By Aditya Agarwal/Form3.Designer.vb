<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        StopwatchInput = New TextBox()
        PhoneNumInput = New TextBox()
        EmailInput = New TextBox()
        GitHubInput = New TextBox()
        NameInput = New TextBox()
        LabelPhoneNum = New Label()
        LabelGithub = New Label()
        LabelEmail = New Label()
        LabelName = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' StopwatchInput
        ' 
        StopwatchInput.Location = New Point(500, 300)
        StopwatchInput.Name = "StopwatchInput"
        StopwatchInput.ReadOnly = True
        StopwatchInput.Size = New Size(100, 27)
        StopwatchInput.TabIndex = 15
        StopwatchInput.Text = "00:00:00"
        StopwatchInput.TextAlign = HorizontalAlignment.Center
        ' 
        ' PhoneNumInput
        ' 
        PhoneNumInput.Location = New Point(320, 200)
        PhoneNumInput.Name = "PhoneNumInput"
        PhoneNumInput.Size = New Size(280, 27)
        PhoneNumInput.TabIndex = 12
        ' 
        ' EmailInput
        ' 
        EmailInput.Location = New Point(320, 150)
        EmailInput.Name = "EmailInput"
        EmailInput.Size = New Size(280, 27)
        EmailInput.TabIndex = 11
        ' 
        ' GitHubInput
        ' 
        GitHubInput.AcceptsReturn = True
        GitHubInput.Location = New Point(320, 250)
        GitHubInput.Name = "GitHubInput"
        GitHubInput.Size = New Size(280, 27)
        GitHubInput.TabIndex = 13
        ' 
        ' NameInput
        ' 
        NameInput.Location = New Point(320, 100)
        NameInput.Name = "NameInput"
        NameInput.Size = New Size(280, 27)
        NameInput.TabIndex = 10
        ' 
        ' LabelPhoneNum
        ' 
        LabelPhoneNum.Location = New Point(200, 200)
        LabelPhoneNum.Name = "LabelPhoneNum"
        LabelPhoneNum.Size = New Size(100, 27)
        LabelPhoneNum.TabIndex = 16
        LabelPhoneNum.Text = "Phone Num"
        LabelPhoneNum.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' LabelGithub
        ' 
        LabelGithub.Location = New Point(200, 243)
        LabelGithub.Name = "LabelGithub"
        LabelGithub.Size = New Size(100, 40)
        LabelGithub.TabIndex = 15
        LabelGithub.Text = "GitHub Link" & vbCrLf & "For Task 2"
        LabelGithub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelEmail
        ' 
        LabelEmail.Location = New Point(200, 150)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(100, 27)
        LabelEmail.TabIndex = 14
        LabelEmail.Text = "Email"
        LabelEmail.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelName
        ' 
        LabelName.Location = New Point(200, 100)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(100, 27)
        LabelName.TabIndex = 13
        LabelName.Text = "Name"
        LabelName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Yellow
        btnToggleStopwatch.Location = New Point(200, 298)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(280, 30)
        btnToggleStopwatch.TabIndex = 14
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL+T)"
        btnToggleStopwatch.TextAlign = ContentAlignment.TopCenter
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.Highlight
        btnSubmit.Location = New Point(200, 368)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(400, 30)
        btnSubmit.TabIndex = 16
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(200, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(334, 20)
        Label1.TabIndex = 25
        Label1.Text = "Aditya Agarwal, Slidely Task 2, Create Submission"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(StopwatchInput)
        Controls.Add(PhoneNumInput)
        Controls.Add(EmailInput)
        Controls.Add(GitHubInput)
        Controls.Add(NameInput)
        Controls.Add(LabelPhoneNum)
        Controls.Add(LabelGithub)
        Controls.Add(LabelEmail)
        Controls.Add(LabelName)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StopwatchInput As TextBox
    Friend WithEvents PhoneNumInput As TextBox
    Friend WithEvents EmailInput As TextBox
    Friend WithEvents GitHubInput As TextBox
    Friend WithEvents NameInput As TextBox
    Friend WithEvents LabelPhoneNum As Label
    Friend WithEvents LabelGithub As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
End Class

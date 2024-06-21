<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.AccessibleRole = AccessibleRole.MenuBar
        btnViewSubmissions.BackColor = Color.Yellow
        btnViewSubmissions.Location = New Point(34, 179)
        btnViewSubmissions.Margin = New Padding(4, 5, 4, 5)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(1031, 98)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = SystemColors.Highlight
        btnCreateNewSubmission.Location = New Point(34, 385)
        btnCreateNewSubmission.Margin = New Padding(4, 5, 4, 5)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(1031, 98)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSIONS (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 71)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(437, 28)
        Label1.TabIndex = 2
        Label1.Text = "Aditya Agarwal, Slidely Task 2 - Slidely Form Task"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 630)
        Controls.Add(Label1)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        Font = New Font("Segoe UI", 12F)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents Label1 As Label

End Class

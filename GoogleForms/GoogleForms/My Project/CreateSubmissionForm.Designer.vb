<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TxtName = New TextBox()
        TxtEmail = New TextBox()
        TxtPhone = New TextBox()
        TxtGitHub = New TextBox()
        LabelName = New Label()
        LabelEmail = New Label()
        LabelPhone = New Label()
        LabelGitHub = New Label()
        LabelStopWatch = New Label()
        BtnStopWatch = New Button()
        BtnSubmit = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(457, 23)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(150, 31)
        TxtName.TabIndex = 0
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(457, 85)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(150, 31)
        TxtEmail.TabIndex = 1
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Location = New Point(457, 153)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(150, 31)
        TxtPhone.TabIndex = 2
        ' 
        ' TxtGitHub
        ' 
        TxtGitHub.Location = New Point(457, 219)
        TxtGitHub.Name = "TxtGitHub"
        TxtGitHub.Size = New Size(150, 31)
        TxtGitHub.TabIndex = 3
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(170, 29)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(59, 25)
        LabelName.TabIndex = 4
        LabelName.Text = "Name"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(170, 91)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(54, 25)
        LabelEmail.TabIndex = 5
        LabelEmail.Text = "Email"
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Location = New Point(170, 153)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(106, 25)
        LabelPhone.TabIndex = 6
        LabelPhone.Text = "Phone Num"
        ' 
        ' LabelGitHub
        ' 
        LabelGitHub.AutoSize = True
        LabelGitHub.Location = New Point(170, 208)
        LabelGitHub.Name = "LabelGitHub"
        LabelGitHub.Size = New Size(188, 25)
        LabelGitHub.TabIndex = 7
        LabelGitHub.Text = "GitHub Link For Task 2"
        ' 
        ' LabelStopWatch
        ' 
        LabelStopWatch.AutoSize = True
        LabelStopWatch.Location = New Point(544, 316)
        LabelStopWatch.Name = "LabelStopWatch"
        LabelStopWatch.Size = New Size(80, 25)
        LabelStopWatch.TabIndex = 8
        LabelStopWatch.Text = "00.00.00"
        ' 
        ' BtnStopWatch
        ' 
        BtnStopWatch.Location = New Point(145, 307)
        BtnStopWatch.Name = "BtnStopWatch"
        BtnStopWatch.Size = New Size(293, 34)
        BtnStopWatch.TabIndex = 9
        BtnStopWatch.Text = "&TOGGLE STOPWATCH (CTRL + T)"
        BtnStopWatch.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(341, 380)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(187, 34)
        BtnSubmit.TabIndex = 10
        BtnSubmit.Text = "&SUBMIT (CTRL + S)"
        BtnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnStopWatch)
        Controls.Add(LabelStopWatch)
        Controls.Add(LabelGitHub)
        Controls.Add(LabelPhone)
        Controls.Add(LabelEmail)
        Controls.Add(LabelName)
        Controls.Add(TxtGitHub)
        Controls.Add(TxtPhone)
        Controls.Add(TxtEmail)
        Controls.Add(TxtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtGitHub As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelGitHub As Label
    Friend WithEvents LabelStopWatch As Label
    Friend WithEvents BtnStopWatch As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Timer1 As Timer
End Class

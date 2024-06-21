<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        TxtName = New TextBox()
        TxtEmail = New TextBox()
        TxtPhone = New TextBox()
        TxtGitHub = New TextBox()
        TxtStopWatch = New TextBox()
        LabelName = New Label()
        LabelEmail = New Label()
        LabelPhone = New Label()
        LabelGitHub = New Label()
        LabelStopWatch = New Label()
        BtnPrevious = New Button()
        BtnNext = New Button()
        BtnDelete = New Button()
        BtnEdit = New Button()
        BtnSubmit = New Button()
        BtnCancel = New Button()
        TxtEmpty = New TextBox()
        SuspendLayout()
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(470, 50)
        TxtName.Name = "TxtName"
        TxtName.ReadOnly = True
        TxtName.Size = New Size(150, 31)
        TxtName.TabIndex = 0
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(470, 106)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.ReadOnly = True
        TxtEmail.Size = New Size(150, 31)
        TxtEmail.TabIndex = 1
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Location = New Point(470, 177)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.ReadOnly = True
        TxtPhone.Size = New Size(150, 31)
        TxtPhone.TabIndex = 2
        ' 
        ' TxtGitHub
        ' 
        TxtGitHub.Location = New Point(470, 230)
        TxtGitHub.Name = "TxtGitHub"
        TxtGitHub.ReadOnly = True
        TxtGitHub.Size = New Size(150, 31)
        TxtGitHub.TabIndex = 3
        ' 
        ' TxtStopWatch
        ' 
        TxtStopWatch.Location = New Point(470, 294)
        TxtStopWatch.Name = "TxtStopWatch"
        TxtStopWatch.ReadOnly = True
        TxtStopWatch.Size = New Size(150, 31)
        TxtStopWatch.TabIndex = 4
        ' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Location = New Point(145, 50)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(59, 25)
        LabelName.TabIndex = 5
        LabelName.Text = "Name"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(145, 109)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(54, 25)
        LabelEmail.TabIndex = 6
        LabelEmail.Text = "Email"
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Location = New Point(145, 166)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(106, 25)
        LabelPhone.TabIndex = 7
        LabelPhone.Text = "Phone Num"
        ' 
        ' LabelGitHub
        ' 
        LabelGitHub.AutoSize = True
        LabelGitHub.Location = New Point(145, 230)
        LabelGitHub.Name = "LabelGitHub"
        LabelGitHub.Size = New Size(185, 25)
        LabelGitHub.TabIndex = 8
        LabelGitHub.Text = "GitHub Link for Task 2"
        ' 
        ' LabelStopWatch
        ' 
        LabelStopWatch.AutoSize = True
        LabelStopWatch.Location = New Point(145, 294)
        LabelStopWatch.Name = "LabelStopWatch"
        LabelStopWatch.Size = New Size(141, 25)
        LabelStopWatch.TabIndex = 9
        LabelStopWatch.Text = "StopWatch Time"
        ' 
        ' BtnPrevious
        ' 
        BtnPrevious.Location = New Point(65, 385)
        BtnPrevious.Name = "BtnPrevious"
        BtnPrevious.Size = New Size(195, 34)
        BtnPrevious.TabIndex = 10
        BtnPrevious.Text = "&PREVIOUS (CTRL+P)"
        BtnPrevious.UseVisualStyleBackColor = True
        ' 
        ' BtnNext
        ' 
        BtnNext.Location = New Point(288, 385)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(153, 34)
        BtnNext.TabIndex = 11
        BtnNext.Text = "&NEXT (CTRL+N)"
        BtnNext.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(470, 385)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(156, 34)
        BtnDelete.TabIndex = 12
        BtnDelete.Text = "&DELETE (CTRL+D)"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnEdit
        ' 
        BtnEdit.Location = New Point(651, 385)
        BtnEdit.Name = "BtnEdit"
        BtnEdit.Size = New Size(152, 34)
        BtnEdit.TabIndex = 13
        BtnEdit.Text = "&EDIT (CTRL + E)"
        BtnEdit.UseVisualStyleBackColor = True
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.Location = New Point(306, 407)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(112, 34)
        BtnSubmit.TabIndex = 14
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = True
        BtnSubmit.Visible = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.Location = New Point(508, 407)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(112, 34)
        BtnCancel.TabIndex = 15
        BtnCancel.Text = "Cancel"
        BtnCancel.UseVisualStyleBackColor = True
        BtnCancel.Visible = False
        ' 
        ' TxtEmpty
        ' 
        TxtEmpty.Location = New Point(288, 163)
        TxtEmpty.Name = "TxtEmpty"
        TxtEmpty.ReadOnly = True
        TxtEmpty.Size = New Size(360, 31)
        TxtEmpty.TabIndex = 16
        TxtEmpty.Text = "No Forms Available"
        TxtEmpty.TextAlign = HorizontalAlignment.Center
        TxtEmpty.Visible = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(883, 501)
        Controls.Add(TxtEmpty)
        Controls.Add(BtnCancel)
        Controls.Add(BtnSubmit)
        Controls.Add(BtnEdit)
        Controls.Add(BtnDelete)
        Controls.Add(BtnNext)
        Controls.Add(BtnPrevious)
        Controls.Add(LabelStopWatch)
        Controls.Add(LabelGitHub)
        Controls.Add(LabelPhone)
        Controls.Add(LabelEmail)
        Controls.Add(LabelName)
        Controls.Add(TxtStopWatch)
        Controls.Add(TxtGitHub)
        Controls.Add(TxtPhone)
        Controls.Add(TxtEmail)
        Controls.Add(TxtName)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtGitHub As TextBox
    Friend WithEvents TxtStopWatch As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents LabelGitHub As Label
    Friend WithEvents LabelStopWatch As Label
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtEmpty As TextBox
End Class

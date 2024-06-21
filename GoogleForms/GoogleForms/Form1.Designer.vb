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
        BtnViewSubmissions = New Button()
        BtnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' BtnViewSubmissions
        ' 
        BtnViewSubmissions.Location = New Point(244, 102)
        BtnViewSubmissions.Name = "BtnViewSubmissions"
        BtnViewSubmissions.Size = New Size(282, 60)
        BtnViewSubmissions.TabIndex = 0
        BtnViewSubmissions.Text = "&VIEW SUBMISSIONS (CTRL + V)"
        BtnViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' BtnCreateSubmission
        ' 
        BtnCreateSubmission.Location = New Point(244, 250)
        BtnCreateSubmission.Name = "BtnCreateSubmission"
        BtnCreateSubmission.Size = New Size(282, 57)
        BtnCreateSubmission.TabIndex = 1
        BtnCreateSubmission.Text = "&NEW SUBMISSIONS (CTRL + N)"
        BtnCreateSubmission.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnCreateSubmission)
        Controls.Add(BtnViewSubmissions)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnViewSubmissions As Button
    Friend WithEvents BtnCreateSubmission As Button

End Class

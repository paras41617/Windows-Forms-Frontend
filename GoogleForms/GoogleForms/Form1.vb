Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            OpenViewSubmissionsForm()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            OpenCreateSubmissionForm()
        End If
    End Sub

    Private Sub BtnViewSubmissions_Click(sender As Object, e As EventArgs) Handles BtnViewSubmissions.Click
        OpenViewSubmissionsForm()
    End Sub

    Private Sub BtnCreateSubmission_Click(sender As Object, e As EventArgs) Handles BtnCreateSubmission.Click
        OpenCreateSubmissionForm()
    End Sub

    Private Sub OpenViewSubmissionsForm()
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub OpenCreateSubmissionForm()
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

End Class

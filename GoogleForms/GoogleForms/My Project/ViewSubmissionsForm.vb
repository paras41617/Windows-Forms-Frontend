Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private totalForms As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission()
    End Sub

    Private Async Function LoadSubmission() As Task
        Using client As New HttpClient()
            Try
                Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={currentIndex}")

                Dim jsonResponse = JObject.Parse(response)
                If jsonResponse("error") IsNot Nothing Then
                    Console.WriteLine("Error fetching submission.")
                Else
                    totalForms = CType(jsonResponse("totalForms"), Integer)
                    Dim submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse("form").ToString())
                    DisplaySubmission(submission)
                End If

            Catch ex As Exception
                Console.WriteLine($"Error fetching submission: {ex.Message}")
            End Try
            Check()
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        TxtName.Text = submission.Name
        TxtEmail.Text = submission.Email
        TxtPhone.Text = submission.Phone
        TxtGitHub.Text = submission.GitHub_Link
        TxtStopWatch.Text = submission.Stopwatch_Time
    End Sub

    Private Sub Check()
        If totalForms = 0 Then

            BtnEdit.Visible = False
            BtnDelete.Visible = False
            BtnNext.Visible = False
            BtnPrevious.Visible = False

            TxtName.Visible = False
            TxtEmail.Visible = False
            TxtPhone.Visible = False
            TxtGitHub.Visible = False
            TxtStopWatch.Visible = False

            LabelName.Visible = False
            LabelEmail.Visible = False
            LabelPhone.Visible = False
            LabelGitHub.Visible = False
            LabelStopWatch.Visible = False

            TxtEmpty.Visible = True

        Else
            If currentIndex = 0 Then
                BtnPrevious.Enabled = False
            End If

            If currentIndex = totalForms - 1 Then
                BtnNext.Enabled = False
            End If


        End If


    End Sub

    Private Sub MakeDefault()
        TxtName.ReadOnly = True
        TxtEmail.ReadOnly = True
        TxtPhone.ReadOnly = True
        TxtGitHub.ReadOnly = True

        BtnSubmit.Visible = False
        BtnCancel.Visible = False

        BtnEdit.Visible = True
        BtnDelete.Visible = True
        BtnNext.Visible = True
        BtnPrevious.Visible = True
    End Sub

    Private Async Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        BtnPrevious.Enabled = True
        If currentIndex < totalForms Then
            currentIndex += 1
            Await LoadSubmission()
        End If
    End Sub

    Private Async Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        BtnNext.Enabled = True
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission()
        End If
    End Sub

    Private Async Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Using client As New HttpClient()
            Dim response = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully!")
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                totalForms -= 1
                Await LoadSubmission()
            Else
                MessageBox.Show("Failed to delete submission.")
            End If
        End Using
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' Make fields editable
        TxtName.ReadOnly = False
        TxtEmail.ReadOnly = False
        TxtPhone.ReadOnly = False
        TxtGitHub.ReadOnly = False

        ' Show edit controls
        BtnSubmit.Visible = True
        BtnCancel.Visible = True

        ' Hide other controls
        BtnEdit.Visible = False
        BtnDelete.Visible = False
        BtnNext.Visible = False
        BtnPrevious.Visible = False
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Using client As New HttpClient()
            Dim submission = New Dictionary(Of String, String) From {
                {"index", currentIndex.ToString()}
            }

            If Not String.IsNullOrWhiteSpace(TxtName.Text) Then submission("name") = TxtName.Text
            If Not String.IsNullOrWhiteSpace(TxtEmail.Text) Then submission("email") = TxtEmail.Text
            If Not String.IsNullOrWhiteSpace(TxtPhone.Text) Then submission("phone") = TxtPhone.Text
            If Not String.IsNullOrWhiteSpace(TxtGitHub.Text) Then submission("github_link") = TxtGitHub.Text

            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PutAsync("http://localhost:3000/edit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission edited successfully!")
                MakeDefault()
                Await LoadSubmission()
            Else
                MessageBox.Show("Failed to edit submission.")
            End If
        End Using
    End Sub

    Private Async Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        MakeDefault()
        Await LoadSubmission()
    End Sub

    Private Async Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim email = TxtSearch.Text.Trim()

        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Please enter an email to search.")
            Return
        End If

        Using client As New HttpClient()
            Dim response = Await client.GetAsync($"http://localhost:3000/search?email={Uri.EscapeDataString(email)}")

            If response.IsSuccessStatusCode Then
                Try
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim submissionsResponse = JsonConvert.DeserializeObject(Of List(Of SubmissionResponse))(json)

                    If submissionsResponse IsNot Nothing AndAlso submissionsResponse.Count > 0 Then
                        Dim submission = submissionsResponse(0).Submission
                        TxtName.Text = submission.Name
                        TxtEmail.Text = submission.Email
                        TxtPhone.Text = submission.Phone
                        TxtGitHub.Text = submission.GitHub_Link
                        TxtStopWatch.Text = submission.Stopwatch_Time
                        currentIndex = submissionsResponse(0).Index
                    Else
                        MessageBox.Show("No submissions found for the specified email.")
                    End If
                Catch ex As Exception
                    MessageBox.Show($"Error deserializing JSON: {ex.Message}")
                End Try
            Else
                MessageBox.Show("Failed to search submissions.")
            End If
        End Using
    End Sub

    Private Async Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Await LoadSubmission()
    End Sub


    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Ctrl + P pressed
            BtnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl + N pressed
            BtnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            ' Ctrl + N pressed
            BtnDelete.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            ' Ctrl + N pressed
            BtnEdit.PerformClick()
        End If
    End Sub

End Class

Public Class Submission
    <JsonProperty("Name")>
    Public Property Name As String

    <JsonProperty("Email")>
    Public Property Email As String

    <JsonProperty("Phone")>
    Public Property Phone As String

    <JsonProperty("GitHub_Link")>
    Public Property GitHub_Link As String

    <JsonProperty("Stopwatch_Time")>
    Public Property Stopwatch_Time As String
End Class

Public Class SubmissionResponse
    <JsonProperty("submission")>
    Public Property Submission As SubmissionSearch
    <JsonProperty("index")>
    Public Property Index As Integer
End Class

Public Class SubmissionSearch
    <JsonProperty("Name")>
    Public Property Name As String

    <JsonProperty("Email")>
    Public Property Email As String

    <JsonProperty("Phone")>
    Public Property Phone As String

    <JsonProperty("GitHub_Link")>
    Public Property GitHub_Link As String

    <JsonProperty("Stopwatch_Time")>
    Public Property Stopwatch_Time As String
End Class


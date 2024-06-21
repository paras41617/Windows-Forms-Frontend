Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private internalStopWatch As New Stopwatch()
    Private timerUpdate As System.Threading.Timer
    Private isSubmitting As Boolean = False

    Public Sub New()
        InitializeComponent()

        ' Create a timer with a callback to update the stopwatch label
        timerUpdate = New System.Threading.Timer(AddressOf TimerUpdateCallback, Nothing, 0, 1000) ' 1000 milliseconds = 1 second
    End Sub

    Private Sub BtnStopwatch_Click(sender As Object, e As EventArgs) Handles BtnStopWatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If internalStopWatch.IsRunning Then
            internalStopWatch.Stop()
        Else
            internalStopWatch.Start()
        End If
    End Sub

    Private Sub TimerUpdateCallback(state As Object)
        If Me.IsHandleCreated Then
            ' Ensure UI updates happen on the UI thread
            Me.Invoke(Sub() UpdateStopwatchLabel())
        End If
    End Sub

    Private Sub UpdateStopwatchLabel()
        LabelStopWatch.Text = internalStopWatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Await SubmitForm()
    End Sub

    Private Async Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Handle Ctrl+S for submit
        If e.Control AndAlso e.KeyCode = Keys.S Then
            e.Handled = True
            Await SubmitForm()
        End If

        ' Handle Ctrl+T for toggle stopwatch
        If e.Control AndAlso e.KeyCode = Keys.T Then
            e.Handled = True
            ToggleStopwatch()
        End If
    End Sub

    Private Async Function SubmitForm() As Task
        ' Pause the stopwatch and disable the timer
        internalStopWatch.Stop()
        timerUpdate.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)
        isSubmitting = True

        Dim submission = New With {
            .name = TxtName.Text,
            .email = TxtEmail.Text,
            .phone = TxtPhone.Text,
            .github_link = TxtGitHub.Text,
            .stopwatch_time = internalStopWatch.Elapsed.ToString("hh\:mm\:ss")
        }
        Dim json = JsonConvert.SerializeObject(submission)
        Using client As New HttpClient()
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
                Me.Invoke(Sub() Me.Close()) ' Close the form from UI thread
            Else
                MessageBox.Show("Submission failed.")
                ' Resume the stopwatch and enable the timer
                internalStopWatch.Start()
                timerUpdate.Change(0, 1000)
                isSubmitting = False
            End If
        End Using
    End Function

    Private Sub CreateSubmissionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Dispose the timer when closing the form
        timerUpdate.Dispose()
    End Sub

End Class

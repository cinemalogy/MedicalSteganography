Public Class WelcomeForm
    Dim I As Integer
    Private Sub WelcomeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        I = 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        I = I + 1
        If I > 5 Then
            Timer1.Enabled = False
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub
End Class

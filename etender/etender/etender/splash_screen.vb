Public Class splash_screen
    Dim i As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        I = I + 1
        If i > 2 Then
            Timer1.Enabled = False
            main.Show()
            Me.Hide()
        End If
    End Sub
End Class
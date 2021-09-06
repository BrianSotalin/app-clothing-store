Public Class login2
    Dim ac As Integer
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btning.Click
        Timer1.Start()
        btning.Visible = False
        pbcircle.Visible = True
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        acercade.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ac = ac + 1
        Label1.Visible = True
        Label2.Visible = True
        If ac = 100 Then

            Me.Hide()
            mainmenu.Show()
        End If
        Label1.Text = ac & "%"

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
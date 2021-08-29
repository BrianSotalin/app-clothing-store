Public Class fromslider

    Dim slider As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        slider = slider + 2
        If slider = 2 Then
            panel1.Visible = True
            Panel2.Visible = False
            Panel4.Visible = False
        End If
        If slider = 4 Then
            panel1.Visible = False
            Panel2.Visible = True
            Panel4.Visible = False
        End If
        If slider = 6 Then
            panel1.Visible = False
            Panel2.Visible = False
            Panel4.Visible = True
            slider = 0
        End If
    End Sub

    Private Sub fromslider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 4000
    End Sub
End Class
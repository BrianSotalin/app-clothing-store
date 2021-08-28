Imports System.Data.SqlClient
Public Class login
    Private Sub prueba()
        Me.Hide()
        mainmenu.Show()

    End Sub
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btni.Click
        iniciosesion()
    End Sub
    Private Sub iniciosesion()
        If conectar() = 0 Then
            pbcircle.Visible = True
            btni.Visible = False
            MsgBox("BDD desconectada", vbCritical, " @Trendy Clothes Inc. | 1999-2021")
        Else
            pbcircle.Visible = True
            btni.Visible = False
            MsgBox("BDD conectada exitosamente", vbInformation, " @Trendy Clothes Inc. | 1999-2021")
        End If
        If txtuser.Text = "" Or txtpsswrd.Text = "" Then
            MsgBox("Hay campos por llenar", vbInformation, " @Trendy Clothes Inc. | 1999-2021")
            pbcircle.Visible = False
            btni.Visible = True
        Else
            Try
                conexion.Open()
                adaptador = New SqlDataAdapter("SELECT * FROM usuarios WHERE Usuario='" & txtuser.Text & "'AND Pssword='" & txtpsswrd.Text & "'", conexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count = 1 Then
                    Dim fila As DataRow = tabla.Rows(0)
                    Name = Trim(fila("Nombre").ToString)
                    txtuser.Text = ""
                    txtpsswrd.Text = ""
                    Me.Hide()
                    mainmenu.Show()
                Else
                    MsgBox("Datos ingresados erroneos ", vbInformation, " @Trendy Clothes Inc. | 1999-2021")
                    txtuser.Text = ""
                    txtpsswrd.Text = ""
                    pbcircle.Visible = False
                    btni.Visible = True

                End If
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, " @Trendy Clothes Inc. | 1999-2021")
            End Try
        End If
    End Sub
End Class

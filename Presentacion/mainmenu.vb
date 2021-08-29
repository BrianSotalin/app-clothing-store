Public Class mainmenu
    'Metodo para abrir formulario secundario
    Private Sub AbrirformEnPanel(Of miform As {Form, New})()
        Dim formulario As Form
        'estoy  busando el formulario dentro del conjunto de formularios
        formulario = pnlcont.Controls.OfType(Of miform)().FirstOrDefault()
        If formulario Is Nothing Then
            formulario = New miform()
            formulario.TopLevel = False
            'cambiamos los stilos del formulario
            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = Dock.Fill
            pnlcont.Controls.Add(formulario)
            pnlcont.Tag = formulario
            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub
    Private Sub salir()
        Me.Close()
        login.Close()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        salir()
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        If pnlopc.Width = 62 Then
            'boton imagen
            gnhome.Visible = False
            gnformal.Visible = False
            gnhoodie.Visible = False
            gnrap.Visible = False
            gndepr.Visible = False
            gnreq.Visible = False
            'boton texto
            bfhome.Visible = True
            bfformal.Visible = True
            bfurbano.Visible = True
            bfdepr.Visible = True
            bfacc.Visible = True
            bfacrc.Visible = True

            pnlopc.Visible = False
            pnlopc.Width = 180
            panela.ShowSync(pnlopc)
            logoaa.ShowSync(logo)
        Else
            'boton imagen
            gnhome.Visible = True
            gnformal.Visible = True
            gnhoodie.Visible = True
            gnrap.Visible = True
            gndepr.Visible = True
            gnreq.Visible = True
            'boton texto
            bfhome.Visible = False
            bfformal.Visible = False
            bfurbano.Visible = False
            bfdepr.Visible = False
            bfacc.Visible = False
            bfacrc.Visible = False

            logo.Visible = False
            pnlopc.Visible = False
            pnlopc.Width = 62
            panela2.ShowSync(pnlopc)
        End If
    End Sub

    Private Sub pnlopc_Paint(sender As Object, e As PaintEventArgs) Handles pnlopc.Paint

    End Sub

    Private Sub bfhome_Click(sender As Object, e As EventArgs) Handles bfhome.Click
        abrirformenpanel(Of home)()
    End Sub

    Private Sub gnhome_Click(sender As Object, e As EventArgs) Handles gnhome.Click
        AbrirformEnPanel(Of home)()
    End Sub

    Private Sub bfformal_Click(sender As Object, e As EventArgs) Handles bfformal.Click
        AbrirformEnPanel(Of formformal)()
    End Sub

    Private Sub gnformal_Click(sender As Object, e As EventArgs) Handles gnformal.Click
        AbrirformEnPanel(Of formformal)()
    End Sub

    Private Sub bfurbano_Click(sender As Object, e As EventArgs) Handles bfurbano.Click
        AbrirformEnPanel(Of formurbano)()
    End Sub

    Private Sub gnhoodie_Click(sender As Object, e As EventArgs) Handles gnhoodie.Click
        AbrirformEnPanel(Of formurbano)()
    End Sub

    Private Sub bfdepr_Click(sender As Object, e As EventArgs) Handles bfdepr.Click
        AbrirformEnPanel(Of formdepr)()
    End Sub

    Private Sub gndepr_Click(sender As Object, e As EventArgs) Handles gndepr.Click
        AbrirformEnPanel(Of formdepr)()
    End Sub

    Private Sub bfacc_Click(sender As Object, e As EventArgs) Handles bfacc.Click
        AbrirformEnPanel(Of formaccesorios)()
    End Sub

    Private Sub gnrap_Click(sender As Object, e As EventArgs) Handles gnrap.Click
        AbrirformEnPanel(Of formaccesorios)()
    End Sub

    Private Sub bfacrc_Click(sender As Object, e As EventArgs) Handles bfacrc.Click
        AbrirformEnPanel(Of formreqst)()
    End Sub

    Private Sub gnreq_Click(sender As Object, e As EventArgs) Handles gnreq.Click
        AbrirformEnPanel(Of formreqst)()
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        AbrirformEnPanel(Of fromslider)()
    End Sub
End Class
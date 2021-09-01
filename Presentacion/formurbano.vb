Public Class formurbano
    ' bloque de precios
    Dim Product1 As Double = 35.99
    Dim Product2 As Double = 16.99
    Dim Product3 As Double = 18.99
    Dim Product4 As Double = 38.5


    'bloque stock
    Dim stock1 As Double = 14
    Dim stock2 As Double = 18
    Dim stock3 As Double = 20
    Dim stock4 As Double = 12


    Dim caja As Double = 700
    Dim iva As Double = 0
    Dim subtotal As Double = 0
    Dim total As Double = 0

    Private Sub cargarpr()
        'creamos el procdimiento para cargar el precio y el precio en caja  de los productos
        prc1.Text = Product1.ToString("C")
        pr2.Text = Product2.ToString("C")
        pr3.Text = Product3.ToString("C")
        pr4.Text = Product4.ToString("C")


        lblcj.Text = caja.ToString("C")
        lbliva.Text = iva.ToString("C")
        lblsb.Text = subtotal.ToString("C")
        lbltt.Text = total.ToString("C")

    End Sub
    Private Sub cargarstock()
        stck1.Text = stock1
        stck2.Text = stock2
        stck3.Text = stock3
        stck4.Text = stock4

    End Sub

    Private Sub MacFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarpr()
        cargarstock()
    End Sub
    Private Function prenda1()
        'stock
        stock1 = stock1 - 1
        If stock1 <= 0 Then
            Producto1.Enabled = False
            stck1.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stck1.Text = stock1
        End If
        'subtotal
        subtotal = subtotal + Product1
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + Product1
        lblcj.Text = caja.ToString("C")

        Return 0

    End Function
    Private Function prenda2()
        'stock
        stock2 = stock2 - 1
        If stock2 <= 0 Then
            Producto2.Enabled = False
            stck2.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stck2.Text = stock2
        End If
        'subtotal
        subtotal = subtotal + Product2
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + Product2
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function prenda3()
        'stock
        stock3 = stock3 - 1
        If stock3 <= 0 Then
            Producto3.Enabled = False
            stck3.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stck3.Text = stock3
        End If
        'subtotal
        subtotal = subtotal + Product3
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + Product3
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function
    Private Function prenda4()
        'stock
        stock4 = stock4 - 1
        If stock4 <= 0 Then
            Producto4.Enabled = False
            stck4.Text = 0
            MsgBox("Stock agotado", vbCritical, "@ MacFood Enterprise | 2021")
        Else
            stck4.Text = stock4
        End If
        'subtotal
        subtotal = subtotal + Product4
        lblsb.Text = subtotal.ToString("C")
        'iva
        iva = subtotal * 0.12
        lbliva.Text = iva.ToString("C")
        'total
        total = subtotal + iva
        lbltt.Text = total.ToString("C")
        'caja
        caja = caja + Product4
        lblcj.Text = caja.ToString("C")

        Return 0
    End Function


    Private Sub fincompra()
        'procedimiento de despedida en compra
        MsgBox(" Gracias por su compra ", vbInformation, "@ TrendyClothes Inc. | 2021")
    End Sub

    Private Sub neworden()
        subtotal = 0
        iva = 0
        total = 0
        lblsb.Text = subtotal.ToString("C")
        lbliva.Text = iva.ToString("C")
        lbltt.Text = total.ToString("C")
    End Sub

    Private Sub btncobrar_Click(sender As Object, e As EventArgs) Handles btncobrar.Click
        fincompra()
    End Sub

    Private Sub btnew_Click(sender As Object, e As EventArgs) Handles btnew.Click
        neworden()
    End Sub

    Private Sub Producto1_Click(sender As Object, e As EventArgs) Handles Producto1.Click
        prenda1()
    End Sub

    Private Sub Producto2_Click(sender As Object, e As EventArgs) Handles Producto2.Click
        prenda2()
    End Sub

    Private Sub Producto3_Click(sender As Object, e As EventArgs) Handles Producto3.Click
        prenda3()
    End Sub

    Private Sub Producto4_Click(sender As Object, e As EventArgs) Handles Producto4.Click
        prenda4()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        'procedimiento btn cerrar caja y formulario

        MsgBox("*****CERRANDO CAJA*****" & vbNewLine & vbNewLine & "Recaudado: " & caja & "$", vbInformation, "@ TrendyClothes Inc. | 2021")

        Dim salir As String

        salir = MsgBox("¿Estas seguro que desea salir del programa?", vbQuestion + vbYesNo, "@ TrendyClothes Inc. | 2021")
        If salir = vbYes Then
            Me.Close()
            login.Close()
        End If
    End Sub
End Class
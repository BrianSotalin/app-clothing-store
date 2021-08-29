<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation4 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainmenu))
        Dim Animation5 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Dim Animation6 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Me.pnltt = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlopc = New System.Windows.Forms.Panel()
        Me.bfacrc = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfformal = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfhome = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bfacc = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfdepr = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bfurbano = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl3 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.panela = New AnimatorNS.Animator(Me.components)
        Me.pnlcont = New System.Windows.Forms.Panel()
        Me.logoaa = New AnimatorNS.Animator(Me.components)
        Me.panela2 = New AnimatorNS.Animator(Me.components)
        Me.gnreq = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.logo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.gnformal = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.gnrap = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.gnhome = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.gnhoodie = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.gndepr = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnexit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.pnltt.SuspendLayout()
        Me.pnlopc.SuspendLayout()
        CType(Me.gnreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gnformal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gnrap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gnhome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gnhoodie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gndepr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnltt
        '
        Me.pnltt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnltt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnltt.Controls.Add(Me.GunaCirclePictureBox1)
        Me.pnltt.Controls.Add(Me.Label3)
        Me.pnltt.Controls.Add(Me.Label2)
        Me.pnltt.Controls.Add(Me.Label1)
        Me.pnltt.Controls.Add(Me.btnexit)
        Me.panela.SetDecoration(Me.pnltt, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.pnltt, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.pnltt, AnimatorNS.DecorationType.None)
        Me.pnltt.Location = New System.Drawing.Point(0, 0)
        Me.pnltt.Name = "pnltt"
        Me.pnltt.Size = New System.Drawing.Size(1000, 100)
        Me.pnltt.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.panela2.SetDecoration(Me.Label3, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.Label3, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.Label3, AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Brush Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(533, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 79)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Clothes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.panela2.SetDecoration(Me.Label2, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.Label2, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.Label2, AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(571, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = """Elegancia y estilo en el mismo lugar"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.panela2.SetDecoration(Me.Label1, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.Label1, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.Label1, AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(308, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 79)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Trendy "
        '
        'pnlopc
        '
        Me.pnlopc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlopc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlopc.Controls.Add(Me.gnreq)
        Me.pnlopc.Controls.Add(Me.bfacrc)
        Me.pnlopc.Controls.Add(Me.logo)
        Me.pnlopc.Controls.Add(Me.gnformal)
        Me.pnlopc.Controls.Add(Me.bfformal)
        Me.pnlopc.Controls.Add(Me.btnmenu)
        Me.pnlopc.Controls.Add(Me.bfhome)
        Me.pnlopc.Controls.Add(Me.Panel3)
        Me.pnlopc.Controls.Add(Me.bfacc)
        Me.pnlopc.Controls.Add(Me.gnrap)
        Me.pnlopc.Controls.Add(Me.bfdepr)
        Me.pnlopc.Controls.Add(Me.bfurbano)
        Me.pnlopc.Controls.Add(Me.gnhome)
        Me.pnlopc.Controls.Add(Me.gnhoodie)
        Me.pnlopc.Controls.Add(Me.gndepr)
        Me.panela.SetDecoration(Me.pnlopc, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.pnlopc, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.pnlopc, AnimatorNS.DecorationType.None)
        Me.pnlopc.ForeColor = System.Drawing.Color.Black
        Me.pnlopc.Location = New System.Drawing.Point(0, 98)
        Me.pnlopc.Name = "pnlopc"
        Me.pnlopc.Size = New System.Drawing.Size(180, 403)
        Me.pnlopc.TabIndex = 1
        '
        'bfacrc
        '
        Me.bfacrc.Activecolor = System.Drawing.Color.Transparent
        Me.bfacrc.BackColor = System.Drawing.Color.Transparent
        Me.bfacrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfacrc.BorderRadius = 0
        Me.bfacrc.ButtonText = "ACERCA DE"
        Me.bfacrc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela2.SetDecoration(Me.bfacrc, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.bfacrc, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.bfacrc, AnimatorNS.DecorationType.None)
        Me.bfacrc.DisabledColor = System.Drawing.Color.Gray
        Me.bfacrc.Iconcolor = System.Drawing.Color.Transparent
        Me.bfacrc.Iconimage = Nothing
        Me.bfacrc.Iconimage_right = Nothing
        Me.bfacrc.Iconimage_right_Selected = Nothing
        Me.bfacrc.Iconimage_Selected = Nothing
        Me.bfacrc.IconMarginLeft = 0
        Me.bfacrc.IconMarginRight = 0
        Me.bfacrc.IconRightVisible = True
        Me.bfacrc.IconRightZoom = 0R
        Me.bfacrc.IconVisible = True
        Me.bfacrc.IconZoom = 90.0R
        Me.bfacrc.IsTab = False
        Me.bfacrc.Location = New System.Drawing.Point(10, 324)
        Me.bfacrc.Name = "bfacrc"
        Me.bfacrc.Normalcolor = System.Drawing.Color.Transparent
        Me.bfacrc.OnHovercolor = System.Drawing.Color.Transparent
        Me.bfacrc.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.bfacrc.selected = False
        Me.bfacrc.Size = New System.Drawing.Size(143, 26)
        Me.bfacrc.TabIndex = 7
        Me.bfacrc.Text = "ACERCA DE"
        Me.bfacrc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bfacrc.Textcolor = System.Drawing.Color.Black
        Me.bfacrc.TextFont = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfformal
        '
        Me.bfformal.Activecolor = System.Drawing.Color.Transparent
        Me.bfformal.BackColor = System.Drawing.Color.Transparent
        Me.bfformal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfformal.BorderRadius = 0
        Me.bfformal.ButtonText = "FORMAL"
        Me.bfformal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela2.SetDecoration(Me.bfformal, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.bfformal, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.bfformal, AnimatorNS.DecorationType.None)
        Me.bfformal.DisabledColor = System.Drawing.Color.Gray
        Me.bfformal.Iconcolor = System.Drawing.Color.Transparent
        Me.bfformal.Iconimage = Nothing
        Me.bfformal.Iconimage_right = Nothing
        Me.bfformal.Iconimage_right_Selected = Nothing
        Me.bfformal.Iconimage_Selected = Nothing
        Me.bfformal.IconMarginLeft = 0
        Me.bfformal.IconMarginRight = 0
        Me.bfformal.IconRightVisible = True
        Me.bfformal.IconRightZoom = 0R
        Me.bfformal.IconVisible = True
        Me.bfformal.IconZoom = 90.0R
        Me.bfformal.IsTab = False
        Me.bfformal.Location = New System.Drawing.Point(10, 147)
        Me.bfformal.Name = "bfformal"
        Me.bfformal.Normalcolor = System.Drawing.Color.Transparent
        Me.bfformal.OnHovercolor = System.Drawing.Color.Transparent
        Me.bfformal.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.bfformal.selected = False
        Me.bfformal.Size = New System.Drawing.Size(143, 26)
        Me.bfformal.TabIndex = 3
        Me.bfformal.Text = "FORMAL"
        Me.bfformal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bfformal.Textcolor = System.Drawing.Color.Black
        Me.bfformal.TextFont = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfhome
        '
        Me.bfhome.Activecolor = System.Drawing.Color.Transparent
        Me.bfhome.BackColor = System.Drawing.Color.Transparent
        Me.bfhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfhome.BorderRadius = 0
        Me.bfhome.ButtonText = "HOME"
        Me.bfhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela2.SetDecoration(Me.bfhome, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.bfhome, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.bfhome, AnimatorNS.DecorationType.None)
        Me.bfhome.DisabledColor = System.Drawing.Color.Gray
        Me.bfhome.Iconcolor = System.Drawing.Color.Transparent
        Me.bfhome.Iconimage = Nothing
        Me.bfhome.Iconimage_right = Nothing
        Me.bfhome.Iconimage_right_Selected = Nothing
        Me.bfhome.Iconimage_Selected = Nothing
        Me.bfhome.IconMarginLeft = 0
        Me.bfhome.IconMarginRight = 0
        Me.bfhome.IconRightVisible = True
        Me.bfhome.IconRightZoom = 0R
        Me.bfhome.IconVisible = True
        Me.bfhome.IconZoom = 90.0R
        Me.bfhome.IsTab = False
        Me.bfhome.Location = New System.Drawing.Point(10, 104)
        Me.bfhome.Name = "bfhome"
        Me.bfhome.Normalcolor = System.Drawing.Color.Transparent
        Me.bfhome.OnHovercolor = System.Drawing.Color.Transparent
        Me.bfhome.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.bfhome.selected = False
        Me.bfhome.Size = New System.Drawing.Size(143, 26)
        Me.bfhome.TabIndex = 2
        Me.bfhome.Text = "HOME"
        Me.bfhome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bfhome.Textcolor = System.Drawing.Color.Black
        Me.bfhome.TextFont = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.panela.SetDecoration(Me.Panel3, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.Panel3, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.Panel3, AnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(179, -7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(819, 105)
        Me.Panel3.TabIndex = 2
        '
        'bfacc
        '
        Me.bfacc.Activecolor = System.Drawing.Color.Transparent
        Me.bfacc.BackColor = System.Drawing.Color.Transparent
        Me.bfacc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfacc.BorderRadius = 0
        Me.bfacc.ButtonText = "ACCESORIOS"
        Me.bfacc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela2.SetDecoration(Me.bfacc, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.bfacc, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.bfacc, AnimatorNS.DecorationType.None)
        Me.bfacc.DisabledColor = System.Drawing.Color.Gray
        Me.bfacc.Iconcolor = System.Drawing.Color.Transparent
        Me.bfacc.Iconimage = Nothing
        Me.bfacc.Iconimage_right = Nothing
        Me.bfacc.Iconimage_right_Selected = Nothing
        Me.bfacc.Iconimage_Selected = Nothing
        Me.bfacc.IconMarginLeft = 0
        Me.bfacc.IconMarginRight = 0
        Me.bfacc.IconRightVisible = True
        Me.bfacc.IconRightZoom = 0R
        Me.bfacc.IconVisible = True
        Me.bfacc.IconZoom = 90.0R
        Me.bfacc.IsTab = False
        Me.bfacc.Location = New System.Drawing.Point(10, 279)
        Me.bfacc.Name = "bfacc"
        Me.bfacc.Normalcolor = System.Drawing.Color.Transparent
        Me.bfacc.OnHovercolor = System.Drawing.Color.Transparent
        Me.bfacc.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.bfacc.selected = False
        Me.bfacc.Size = New System.Drawing.Size(143, 26)
        Me.bfacc.TabIndex = 6
        Me.bfacc.Text = "ACCESORIOS"
        Me.bfacc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bfacc.Textcolor = System.Drawing.Color.Black
        Me.bfacc.TextFont = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfdepr
        '
        Me.bfdepr.Activecolor = System.Drawing.Color.Transparent
        Me.bfdepr.BackColor = System.Drawing.Color.Transparent
        Me.bfdepr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfdepr.BorderRadius = 0
        Me.bfdepr.ButtonText = "DEPORTIVO"
        Me.bfdepr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela2.SetDecoration(Me.bfdepr, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.bfdepr, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.bfdepr, AnimatorNS.DecorationType.None)
        Me.bfdepr.DisabledColor = System.Drawing.Color.Gray
        Me.bfdepr.Iconcolor = System.Drawing.Color.Transparent
        Me.bfdepr.Iconimage = Nothing
        Me.bfdepr.Iconimage_right = Nothing
        Me.bfdepr.Iconimage_right_Selected = Nothing
        Me.bfdepr.Iconimage_Selected = Nothing
        Me.bfdepr.IconMarginLeft = 0
        Me.bfdepr.IconMarginRight = 0
        Me.bfdepr.IconRightVisible = True
        Me.bfdepr.IconRightZoom = 0R
        Me.bfdepr.IconVisible = True
        Me.bfdepr.IconZoom = 90.0R
        Me.bfdepr.IsTab = False
        Me.bfdepr.Location = New System.Drawing.Point(10, 234)
        Me.bfdepr.Name = "bfdepr"
        Me.bfdepr.Normalcolor = System.Drawing.Color.Transparent
        Me.bfdepr.OnHovercolor = System.Drawing.Color.Transparent
        Me.bfdepr.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.bfdepr.selected = False
        Me.bfdepr.Size = New System.Drawing.Size(143, 26)
        Me.bfdepr.TabIndex = 5
        Me.bfdepr.Text = "DEPORTIVO"
        Me.bfdepr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bfdepr.Textcolor = System.Drawing.Color.Black
        Me.bfdepr.TextFont = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bfurbano
        '
        Me.bfurbano.Activecolor = System.Drawing.Color.Transparent
        Me.bfurbano.BackColor = System.Drawing.Color.Transparent
        Me.bfurbano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bfurbano.BorderRadius = 0
        Me.bfurbano.ButtonText = "URBANO"
        Me.bfurbano.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela2.SetDecoration(Me.bfurbano, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.bfurbano, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.bfurbano, AnimatorNS.DecorationType.None)
        Me.bfurbano.DisabledColor = System.Drawing.Color.Gray
        Me.bfurbano.Iconcolor = System.Drawing.Color.Transparent
        Me.bfurbano.Iconimage = Nothing
        Me.bfurbano.Iconimage_right = Nothing
        Me.bfurbano.Iconimage_right_Selected = Nothing
        Me.bfurbano.Iconimage_Selected = Nothing
        Me.bfurbano.IconMarginLeft = 0
        Me.bfurbano.IconMarginRight = 0
        Me.bfurbano.IconRightVisible = True
        Me.bfurbano.IconRightZoom = 0R
        Me.bfurbano.IconVisible = True
        Me.bfurbano.IconZoom = 90.0R
        Me.bfurbano.IsTab = False
        Me.bfurbano.Location = New System.Drawing.Point(10, 191)
        Me.bfurbano.Name = "bfurbano"
        Me.bfurbano.Normalcolor = System.Drawing.Color.Transparent
        Me.bfurbano.OnHovercolor = System.Drawing.Color.Transparent
        Me.bfurbano.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.bfurbano.selected = False
        Me.bfurbano.Size = New System.Drawing.Size(143, 26)
        Me.bfurbano.TabIndex = 4
        Me.bfurbano.Text = "URBANO"
        Me.bfurbano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bfurbano.Textcolor = System.Drawing.Color.Black
        Me.bfurbano.TextFont = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Me.pnltt
        '
        'GunaDragControl3
        '
        Me.GunaDragControl3.TargetControl = Me.pnlopc
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'panela
        '
        Me.panela.AnimationType = AnimatorNS.AnimationType.HorizSlide
        Me.panela.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.panela.DefaultAnimation = Animation4
        Me.panela.Interval = 20
        '
        'pnlcont
        '
        Me.panela.SetDecoration(Me.pnlcont, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.pnlcont, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.pnlcont, AnimatorNS.DecorationType.None)
        Me.pnlcont.Location = New System.Drawing.Point(186, 107)
        Me.pnlcont.Name = "pnlcont"
        Me.pnlcont.Size = New System.Drawing.Size(805, 394)
        Me.pnlcont.TabIndex = 2
        '
        'logoaa
        '
        Me.logoaa.AnimationType = AnimatorNS.AnimationType.Leaf
        Me.logoaa.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 1.0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0!
        Animation5.TransparencyCoeff = 0!
        Me.logoaa.DefaultAnimation = Animation5
        '
        'panela2
        '
        Me.panela2.AnimationType = AnimatorNS.AnimationType.HorizSlide
        Me.panela2.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0!
        Animation6.RotateLimit = 0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0!
        Animation6.TransparencyCoeff = 0!
        Me.panela2.DefaultAnimation = Animation6
        '
        'gnreq
        '
        Me.gnreq.BaseColor = System.Drawing.Color.White
        Me.gnreq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela.SetDecoration(Me.gnreq, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.gnreq, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.gnreq, AnimatorNS.DecorationType.None)
        Me.gnreq.Image = Global.login.My.Resources.Resources.request
        Me.gnreq.Location = New System.Drawing.Point(10, 345)
        Me.gnreq.Name = "gnreq"
        Me.gnreq.Size = New System.Drawing.Size(37, 37)
        Me.gnreq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gnreq.TabIndex = 7
        Me.gnreq.TabStop = False
        Me.gnreq.UseTransfarantBackground = False
        Me.gnreq.Visible = False
        '
        'logo
        '
        Me.logo.BaseColor = System.Drawing.Color.White
        Me.panela.SetDecoration(Me.logo, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.logo, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.logo, AnimatorNS.DecorationType.None)
        Me.logo.Image = Global.login.My.Resources.Resources.traje
        Me.logo.Location = New System.Drawing.Point(10, -2)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(72, 66)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        Me.logo.UseTransfarantBackground = False
        '
        'gnformal
        '
        Me.gnformal.BaseColor = System.Drawing.Color.White
        Me.gnformal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela.SetDecoration(Me.gnformal, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.gnformal, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.gnformal, AnimatorNS.DecorationType.None)
        Me.gnformal.Image = Global.login.My.Resources.Resources.suit
        Me.gnformal.Location = New System.Drawing.Point(10, 125)
        Me.gnformal.Name = "gnformal"
        Me.gnformal.Size = New System.Drawing.Size(37, 37)
        Me.gnformal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gnformal.TabIndex = 6
        Me.gnformal.TabStop = False
        Me.gnformal.UseTransfarantBackground = False
        Me.gnformal.Visible = False
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela2.SetDecoration(Me.btnmenu, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.btnmenu, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me.btnmenu, AnimatorNS.DecorationType.None)
        Me.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnmenu.Image = Global.login.My.Resources.Resources.menu
        Me.btnmenu.Location = New System.Drawing.Point(132, 3)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(41, 36)
        Me.btnmenu.TabIndex = 2
        Me.btnmenu.UseVisualStyleBackColor = False
        '
        'gnrap
        '
        Me.gnrap.BaseColor = System.Drawing.Color.White
        Me.gnrap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela.SetDecoration(Me.gnrap, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.gnrap, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.gnrap, AnimatorNS.DecorationType.None)
        Me.gnrap.Image = Global.login.My.Resources.Resources.rapero
        Me.gnrap.Location = New System.Drawing.Point(10, 290)
        Me.gnrap.Name = "gnrap"
        Me.gnrap.Size = New System.Drawing.Size(37, 37)
        Me.gnrap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gnrap.TabIndex = 5
        Me.gnrap.TabStop = False
        Me.gnrap.UseTransfarantBackground = False
        Me.gnrap.Visible = False
        '
        'gnhome
        '
        Me.gnhome.BaseColor = System.Drawing.Color.White
        Me.gnhome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela.SetDecoration(Me.gnhome, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.gnhome, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.gnhome, AnimatorNS.DecorationType.None)
        Me.gnhome.Image = Global.login.My.Resources.Resources.house_black_silhouette_without_door
        Me.gnhome.Location = New System.Drawing.Point(10, 70)
        Me.gnhome.Name = "gnhome"
        Me.gnhome.Size = New System.Drawing.Size(37, 37)
        Me.gnhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gnhome.TabIndex = 2
        Me.gnhome.TabStop = False
        Me.gnhome.UseTransfarantBackground = False
        Me.gnhome.Visible = False
        '
        'gnhoodie
        '
        Me.gnhoodie.BaseColor = System.Drawing.Color.White
        Me.gnhoodie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela.SetDecoration(Me.gnhoodie, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.gnhoodie, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.gnhoodie, AnimatorNS.DecorationType.None)
        Me.gnhoodie.Image = Global.login.My.Resources.Resources.hoodie
        Me.gnhoodie.Location = New System.Drawing.Point(10, 179)
        Me.gnhoodie.Name = "gnhoodie"
        Me.gnhoodie.Size = New System.Drawing.Size(37, 37)
        Me.gnhoodie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gnhoodie.TabIndex = 4
        Me.gnhoodie.TabStop = False
        Me.gnhoodie.UseTransfarantBackground = False
        Me.gnhoodie.Visible = False
        '
        'gndepr
        '
        Me.gndepr.BaseColor = System.Drawing.Color.White
        Me.gndepr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela.SetDecoration(Me.gndepr, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.gndepr, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.gndepr, AnimatorNS.DecorationType.None)
        Me.gndepr.Image = Global.login.My.Resources.Resources.camiseta_de_manga_corta
        Me.gndepr.Location = New System.Drawing.Point(10, 234)
        Me.gndepr.Name = "gndepr"
        Me.gndepr.Size = New System.Drawing.Size(37, 37)
        Me.gndepr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gndepr.TabIndex = 3
        Me.gndepr.TabStop = False
        Me.gndepr.UseTransfarantBackground = False
        Me.gndepr.Visible = False
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.panela.SetDecoration(Me.GunaCirclePictureBox1, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.GunaCirclePictureBox1, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.GunaCirclePictureBox1, AnimatorNS.DecorationType.None)
        Me.GunaCirclePictureBox1.Image = Global.login.My.Resources.Resources.traje
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(478, 35)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(70, 60)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 9
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'btnexit
        '
        Me.btnexit.ActiveBorderThickness = 1
        Me.btnexit.ActiveCornerRadius = 20
        Me.btnexit.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btnexit.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnexit.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btnexit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnexit.BackgroundImage = CType(resources.GetObject("btnexit.BackgroundImage"), System.Drawing.Image)
        Me.btnexit.ButtonText = "EXIT"
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panela.SetDecoration(Me.btnexit, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me.btnexit, AnimatorNS.DecorationType.None)
        Me.logoaa.SetDecoration(Me.btnexit, AnimatorNS.DecorationType.None)
        Me.btnexit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnexit.IdleBorderThickness = 1
        Me.btnexit.IdleCornerRadius = 20
        Me.btnexit.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnexit.IdleForecolor = System.Drawing.Color.Gray
        Me.btnexit.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnexit.Location = New System.Drawing.Point(908, -2)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 41)
        Me.btnexit.TabIndex = 2
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.pnlcont)
        Me.Controls.Add(Me.pnlopc)
        Me.Controls.Add(Me.pnltt)
        Me.logoaa.SetDecoration(Me, AnimatorNS.DecorationType.None)
        Me.panela.SetDecoration(Me, AnimatorNS.DecorationType.None)
        Me.panela2.SetDecoration(Me, AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainmenu"
        Me.pnltt.ResumeLayout(False)
        Me.pnltt.PerformLayout()
        Me.pnlopc.ResumeLayout(False)
        CType(Me.gnreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gnformal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gnrap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gnhome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gnhoodie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gndepr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnltt As Panel
    Friend WithEvents pnlopc As Panel
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl3 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnmenu As Button
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents logo As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents panela As AnimatorNS.Animator
    Friend WithEvents panela2 As AnimatorNS.Animator
    Friend WithEvents logoaa As AnimatorNS.Animator
    Friend WithEvents bfacc As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfdepr As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfurbano As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfformal As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfhome As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bfacrc As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents gnreq As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents gnformal As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents gnrap As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents gnhoodie As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents gndepr As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents gnhome As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents pnlcont As Panel
End Class

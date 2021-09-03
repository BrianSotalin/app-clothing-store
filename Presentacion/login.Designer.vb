<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtuser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtpsswrd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.btni = New Guna.UI.WinForms.GunaCircleButton()
        Me.pbcircle = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnexit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Sitka Heading", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel1.Location = New System.Drawing.Point(238, 25)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(188, 35)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "INICIAR SESION"
        '
        'txtuser
        '
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtuser.ForeColor = System.Drawing.Color.White
        Me.txtuser.HintForeColor = System.Drawing.Color.Empty
        Me.txtuser.HintText = ""
        Me.txtuser.isPassword = False
        Me.txtuser.LineFocusedColor = System.Drawing.Color.Black
        Me.txtuser.LineIdleColor = System.Drawing.Color.Gray
        Me.txtuser.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txtuser.LineThickness = 3
        Me.txtuser.Location = New System.Drawing.Point(189, 168)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(237, 30)
        Me.txtuser.TabIndex = 3
        Me.txtuser.Text = "Usuario"
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtpsswrd
        '
        Me.txtpsswrd.BackColor = System.Drawing.Color.Black
        Me.txtpsswrd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpsswrd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtpsswrd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtpsswrd.HintForeColor = System.Drawing.Color.Empty
        Me.txtpsswrd.HintText = ""
        Me.txtpsswrd.isPassword = True
        Me.txtpsswrd.LineFocusedColor = System.Drawing.Color.LightGray
        Me.txtpsswrd.LineIdleColor = System.Drawing.Color.Silver
        Me.txtpsswrd.LineMouseHoverColor = System.Drawing.Color.Gainsboro
        Me.txtpsswrd.LineThickness = 3
        Me.txtpsswrd.Location = New System.Drawing.Point(189, 206)
        Me.txtpsswrd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpsswrd.Name = "txtpsswrd"
        Me.txtpsswrd.Size = New System.Drawing.Size(237, 30)
        Me.txtpsswrd.TabIndex = 4
        Me.txtpsswrd.Text = "Contraseña"
        Me.txtpsswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'btni
        '
        Me.btni.AnimationHoverSpeed = 0.07!
        Me.btni.AnimationSpeed = 0.03!
        Me.btni.BackColor = System.Drawing.Color.Transparent
        Me.btni.BaseColor = System.Drawing.Color.Black
        Me.btni.BorderColor = System.Drawing.Color.Black
        Me.btni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btni.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btni.FocusedColor = System.Drawing.Color.Empty
        Me.btni.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btni.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btni.Image = Nothing
        Me.btni.ImageSize = New System.Drawing.Size(52, 52)
        Me.btni.Location = New System.Drawing.Point(244, 249)
        Me.btni.Name = "btni"
        Me.btni.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke
        Me.btni.OnHoverBorderColor = System.Drawing.Color.WhiteSmoke
        Me.btni.OnHoverForeColor = System.Drawing.Color.Black
        Me.btni.OnHoverImage = Nothing
        Me.btni.OnPressedColor = System.Drawing.Color.WhiteSmoke
        Me.btni.Size = New System.Drawing.Size(167, 62)
        Me.btni.TabIndex = 9
        Me.btni.Text = "INGRESAR"
        '
        'pbcircle
        '
        Me.pbcircle.BackColor = System.Drawing.Color.Transparent
        Me.pbcircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbcircle.Location = New System.Drawing.Point(302, 249)
        Me.pbcircle.Name = "pbcircle"
        Me.pbcircle.ProgressColor = System.Drawing.Color.White
        Me.pbcircle.Size = New System.Drawing.Size(68, 62)
        Me.pbcircle.TabIndex = 14
        Me.pbcircle.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Silver
        Me.PictureBox3.Image = Global.login.My.Resources.Resources.usss
        Me.PictureBox3.Location = New System.Drawing.Point(419, 168)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 30
        Me.GunaElipse2.TargetControl = Me.btni
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.login.My.Resources.Resources.user22
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(302, 76)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 15
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Silver
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(2, 320)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.DimGray
        Me.GunaCircleButton1.Size = New System.Drawing.Size(30, 27)
        Me.GunaCircleButton1.TabIndex = 17
        Me.GunaCircleButton1.Text = "?"
        '
        'btnexit
        '
        Me.btnexit.ActiveBorderThickness = 1
        Me.btnexit.ActiveCornerRadius = 20
        Me.btnexit.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btnexit.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnexit.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btnexit.BackColor = System.Drawing.Color.Black
        Me.btnexit.BackgroundImage = CType(resources.GetObject("btnexit.BackgroundImage"), System.Drawing.Image)
        Me.btnexit.ButtonText = "EXIT"
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.Gray
        Me.btnexit.IdleBorderThickness = 1
        Me.btnexit.IdleCornerRadius = 20
        Me.btnexit.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnexit.IdleForecolor = System.Drawing.Color.Gray
        Me.btnexit.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnexit.Location = New System.Drawing.Point(559, 313)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(89, 34)
        Me.btnexit.TabIndex = 16
        Me.btnexit.TabStop = False
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BackColor = System.Drawing.Color.Silver
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = Global.login.My.Resources.Resources.key
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(419, 206)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(28, 30)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 18
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.Black
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Ingresar de nuevo"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.Gray
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton24.Location = New System.Drawing.Point(47, 332)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(139, 15)
        Me.BunifuThinButton24.TabIndex = 19
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.login.My.Resources.Resources.mn
        Me.ClientSize = New System.Drawing.Size(650, 350)
        Me.Controls.Add(Me.BunifuThinButton24)
        Me.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.pbcircle)
        Me.Controls.Add(Me.btni)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtpsswrd)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.GunaLabel1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpsswrd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtuser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btni As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents pbcircle As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Timer1 As Timer
End Class

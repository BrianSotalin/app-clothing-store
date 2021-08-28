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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtuser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtpsswrd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btni = New Guna.UI.WinForms.GunaCircleButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbcircle = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel1.Location = New System.Drawing.Point(130, 37)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(188, 32)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "INICIAR SESION"
        '
        'txtuser
        '
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtuser.HintForeColor = System.Drawing.Color.Empty
        Me.txtuser.HintText = ""
        Me.txtuser.isPassword = False
        Me.txtuser.LineFocusedColor = System.Drawing.Color.Black
        Me.txtuser.LineIdleColor = System.Drawing.Color.Gray
        Me.txtuser.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txtuser.LineThickness = 3
        Me.txtuser.Location = New System.Drawing.Point(64, 206)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(300, 30)
        Me.txtuser.TabIndex = 3
        Me.txtuser.Text = "Usuario"
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtpsswrd
        '
        Me.txtpsswrd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpsswrd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtpsswrd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpsswrd.HintForeColor = System.Drawing.Color.Empty
        Me.txtpsswrd.HintText = ""
        Me.txtpsswrd.isPassword = True
        Me.txtpsswrd.LineFocusedColor = System.Drawing.Color.Black
        Me.txtpsswrd.LineIdleColor = System.Drawing.Color.Gray
        Me.txtpsswrd.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txtpsswrd.LineThickness = 3
        Me.txtpsswrd.Location = New System.Drawing.Point(64, 270)
        Me.txtpsswrd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpsswrd.Name = "txtpsswrd"
        Me.txtpsswrd.Size = New System.Drawing.Size(300, 30)
        Me.txtpsswrd.TabIndex = 4
        Me.txtpsswrd.Text = "Contraseña"
        Me.txtpsswrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Me.PictureBox1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.login.My.Resources.Resources._20732
        Me.PictureBox1.Location = New System.Drawing.Point(453, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btni
        '
        Me.btni.AnimationHoverSpeed = 0.07!
        Me.btni.AnimationSpeed = 0.03!
        Me.btni.BaseColor = System.Drawing.Color.RoyalBlue
        Me.btni.BorderColor = System.Drawing.Color.Black
        Me.btni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btni.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btni.FocusedColor = System.Drawing.Color.Empty
        Me.btni.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btni.ForeColor = System.Drawing.Color.White
        Me.btni.Image = Nothing
        Me.btni.ImageSize = New System.Drawing.Size(52, 52)
        Me.btni.Location = New System.Drawing.Point(136, 338)
        Me.btni.Name = "btni"
        Me.btni.OnHoverBaseColor = System.Drawing.Color.MidnightBlue
        Me.btni.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btni.OnHoverForeColor = System.Drawing.Color.White
        Me.btni.OnHoverImage = Nothing
        Me.btni.OnPressedColor = System.Drawing.Color.Black
        Me.btni.Size = New System.Drawing.Size(182, 62)
        Me.btni.TabIndex = 9
        Me.btni.Text = "INGRESAR"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.login.My.Resources.Resources.key
        Me.PictureBox4.Location = New System.Drawing.Point(371, 275)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.login.My.Resources.Resources.userlogin
        Me.PictureBox3.Location = New System.Drawing.Point(371, 211)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.login.My.Resources.Resources.userlogingrande
        Me.PictureBox2.Location = New System.Drawing.Point(177, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'pbcircle
        '
        Me.pbcircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbcircle.Location = New System.Drawing.Point(199, 338)
        Me.pbcircle.Name = "pbcircle"
        Me.pbcircle.ProgressColor = System.Drawing.Color.RoyalBlue
        Me.pbcircle.Size = New System.Drawing.Size(68, 62)
        Me.pbcircle.TabIndex = 14
        Me.pbcircle.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.pbcircle)
        Me.Controls.Add(Me.btni)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtpsswrd)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpsswrd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtuser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btni As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents pbcircle As Guna.UI.WinForms.GunaWinCircleProgressIndicator
End Class

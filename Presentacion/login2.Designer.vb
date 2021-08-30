<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login2))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnexit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 15
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.Panel1.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(452, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 450)
        Me.Panel1.TabIndex = 0
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.login.My.Resources.Resources.traje
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(404, 412)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(43, 35)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 8
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Brush Script MT", 72.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 117)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clothes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 72.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(147, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 117)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Trendy "
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 40
        Me.GunaElipse3.TargetControl = Me.GunaCirclePictureBox1
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Silver
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaCircleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Rockwell Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaCircleButton1.Image = Nothing
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(414, 3)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.DimGray
        Me.GunaCircleButton1.Size = New System.Drawing.Size(33, 29)
        Me.GunaCircleButton1.TabIndex = 12
        Me.GunaCircleButton1.Text = "?"
        '
        'btnexit
        '
        Me.btnexit.ActiveBorderThickness = 1
        Me.btnexit.ActiveCornerRadius = 20
        Me.btnexit.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btnexit.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnexit.ActiveLineColor = System.Drawing.Color.Transparent
        Me.btnexit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnexit.BackgroundImage = CType(resources.GetObject("btnexit.BackgroundImage"), System.Drawing.Image)
        Me.btnexit.ButtonText = "EXIT"
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnexit.IdleBorderThickness = 1
        Me.btnexit.IdleCornerRadius = 20
        Me.btnexit.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnexit.IdleForecolor = System.Drawing.Color.Gray
        Me.btnexit.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnexit.Location = New System.Drawing.Point(-3, 409)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 41)
        Me.btnexit.TabIndex = 11
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = Global.login.My.Resources.Resources.traje
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(-3, 0)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(43, 35)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 12
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.GunaCirclePictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class

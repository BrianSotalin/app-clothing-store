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
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnexit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btning = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.pbcircle = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 40
        Me.GunaElipse3.TargetControl = Me
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
        Me.btnexit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnexit.IdleBorderThickness = 1
        Me.btnexit.IdleCornerRadius = 20
        Me.btnexit.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnexit.IdleForecolor = System.Drawing.Color.Gray
        Me.btnexit.IdleLineColor = System.Drawing.Color.Transparent
        Me.btnexit.Location = New System.Drawing.Point(485, 1)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(101, 33)
        Me.btnexit.TabIndex = 11
        Me.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(1, 252)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Gray
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.DimGray
        Me.GunaCircleButton1.Size = New System.Drawing.Size(30, 27)
        Me.GunaCircleButton1.TabIndex = 18
        Me.GunaCircleButton1.Text = "?"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Sitka Heading", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GunaLabel1.Location = New System.Drawing.Point(193, 75)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(226, 35)
        Me.GunaLabel1.TabIndex = 19
        Me.GunaLabel1.Text = "Trendy Clothes APP"
        '
        'btning
        '
        Me.btning.ActiveBorderThickness = 1
        Me.btning.ActiveCornerRadius = 20
        Me.btning.ActiveFillColor = System.Drawing.Color.Silver
        Me.btning.ActiveForecolor = System.Drawing.Color.Black
        Me.btning.ActiveLineColor = System.Drawing.Color.Silver
        Me.btning.BackColor = System.Drawing.Color.Black
        Me.btning.BackgroundImage = CType(resources.GetObject("btning.BackgroundImage"), System.Drawing.Image)
        Me.btning.ButtonText = "INGRESAR"
        Me.btning.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btning.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btning.ForeColor = System.Drawing.Color.Goldenrod
        Me.btning.IdleBorderThickness = 1
        Me.btning.IdleCornerRadius = 20
        Me.btning.IdleFillColor = System.Drawing.Color.Black
        Me.btning.IdleForecolor = System.Drawing.Color.Silver
        Me.btning.IdleLineColor = System.Drawing.Color.Black
        Me.btning.Location = New System.Drawing.Point(199, 166)
        Me.btning.Margin = New System.Windows.Forms.Padding(5)
        Me.btning.Name = "btning"
        Me.btning.Size = New System.Drawing.Size(148, 41)
        Me.btning.TabIndex = 20
        Me.btning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'pbcircle
        '
        Me.pbcircle.BackColor = System.Drawing.Color.Transparent
        Me.pbcircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbcircle.Location = New System.Drawing.Point(253, 144)
        Me.pbcircle.Name = "pbcircle"
        Me.pbcircle.ProgressColor = System.Drawing.Color.Silver
        Me.pbcircle.Size = New System.Drawing.Size(80, 77)
        Me.pbcircle.TabIndex = 21
        Me.pbcircle.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(313, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "0"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(215, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CARGANDO"
        Me.Label2.Visible = False
        '
        'Timer1
        '
        '
        'login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.login.My.Resources.Resources.mn
        Me.ClientSize = New System.Drawing.Size(570, 280)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbcircle)
        Me.Controls.Add(Me.btning)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaCircleButton1)
        Me.Controls.Add(Me.btnexit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnexit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btning As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents pbcircle As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class

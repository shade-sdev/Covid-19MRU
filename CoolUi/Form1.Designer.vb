<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaCircleProgressBar2 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaCircleProgressBar3 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaCircleProgressBar4 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel2.Controls.Add(Me.GunaCircleProgressBar1)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel2)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(12, 80)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(376, 142)
        Me.GunaElipsePanel2.TabIndex = 1
        '
        'GunaCircleProgressBar1
        '
        Me.GunaCircleProgressBar1.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaCircleProgressBar1.IdleOffset = 20
        Me.GunaCircleProgressBar1.IdleThickness = 10
        Me.GunaCircleProgressBar1.Image = Nothing
        Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(10, 10)
        Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(273, 39)
        Me.GunaCircleProgressBar1.Maximum = 5000
        Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
        Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressOffset = 20
        Me.GunaCircleProgressBar1.ProgressThickness = 10
        Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(100, 100)
        Me.GunaCircleProgressBar1.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Doubleplus", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GunaLabel2.Location = New System.Drawing.Point(6, 40)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(283, 51)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "DisplayCount"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Doubleplus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(167, 17)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Total Cases In MAURITIUS"
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.GunaCircleProgressBar2)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel4)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(401, 80)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(387, 142)
        Me.GunaElipsePanel3.TabIndex = 2
        '
        'GunaCircleProgressBar2
        '
        Me.GunaCircleProgressBar2.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar2.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaCircleProgressBar2.IdleOffset = 20
        Me.GunaCircleProgressBar2.IdleThickness = 10
        Me.GunaCircleProgressBar2.Image = Nothing
        Me.GunaCircleProgressBar2.ImageSize = New System.Drawing.Size(10, 10)
        Me.GunaCircleProgressBar2.Location = New System.Drawing.Point(284, 41)
        Me.GunaCircleProgressBar2.Maximum = 5000
        Me.GunaCircleProgressBar2.Name = "GunaCircleProgressBar2"
        Me.GunaCircleProgressBar2.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar2.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar2.ProgressOffset = 20
        Me.GunaCircleProgressBar2.ProgressThickness = 10
        Me.GunaCircleProgressBar2.Size = New System.Drawing.Size(100, 100)
        Me.GunaCircleProgressBar2.TabIndex = 1
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Doubleplus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 11)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(174, 17)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "Cases Today In MAURITUS"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Doubleplus", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GunaLabel4.Location = New System.Drawing.Point(6, 40)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(283, 51)
        Me.GunaLabel4.TabIndex = 3
        Me.GunaLabel4.Text = "DisplayCount"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.GunaCircleProgressBar3)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(12, 234)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(376, 142)
        Me.GunaElipsePanel1.TabIndex = 3
        '
        'GunaCircleProgressBar3
        '
        Me.GunaCircleProgressBar3.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar3.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaCircleProgressBar3.IdleOffset = 20
        Me.GunaCircleProgressBar3.IdleThickness = 10
        Me.GunaCircleProgressBar3.Image = Nothing
        Me.GunaCircleProgressBar3.ImageSize = New System.Drawing.Size(10, 10)
        Me.GunaCircleProgressBar3.Location = New System.Drawing.Point(273, 41)
        Me.GunaCircleProgressBar3.Maximum = 5000
        Me.GunaCircleProgressBar3.Name = "GunaCircleProgressBar3"
        Me.GunaCircleProgressBar3.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar3.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar3.ProgressOffset = 20
        Me.GunaCircleProgressBar3.ProgressThickness = 10
        Me.GunaCircleProgressBar3.Size = New System.Drawing.Size(100, 100)
        Me.GunaCircleProgressBar3.TabIndex = 1
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Doubleplus", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GunaLabel5.Location = New System.Drawing.Point(6, 41)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(283, 51)
        Me.GunaLabel5.TabIndex = 4
        Me.GunaLabel5.Text = "DisplayCount"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Doubleplus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaLabel6.Location = New System.Drawing.Point(12, 12)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(263, 17)
        Me.GunaLabel6.TabIndex = 3
        Me.GunaLabel6.Text = "DEATH Caused by COVID-19 In MAURITUS"
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel4.Controls.Add(Me.GunaCircleProgressBar4)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel8)
        Me.GunaElipsePanel4.Controls.Add(Me.GunaLabel7)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(401, 234)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(387, 142)
        Me.GunaElipsePanel4.TabIndex = 4
        '
        'GunaCircleProgressBar4
        '
        Me.GunaCircleProgressBar4.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar4.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar4.IdleColor = System.Drawing.Color.Gainsboro
        Me.GunaCircleProgressBar4.IdleOffset = 20
        Me.GunaCircleProgressBar4.IdleThickness = 10
        Me.GunaCircleProgressBar4.Image = Nothing
        Me.GunaCircleProgressBar4.ImageSize = New System.Drawing.Size(10, 10)
        Me.GunaCircleProgressBar4.Location = New System.Drawing.Point(286, 41)
        Me.GunaCircleProgressBar4.Maximum = 780000000
        Me.GunaCircleProgressBar4.Name = "GunaCircleProgressBar4"
        Me.GunaCircleProgressBar4.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar4.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar4.ProgressOffset = 20
        Me.GunaCircleProgressBar4.ProgressThickness = 10
        Me.GunaCircleProgressBar4.Size = New System.Drawing.Size(100, 100)
        Me.GunaCircleProgressBar4.TabIndex = 5
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Doubleplus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaLabel8.Location = New System.Drawing.Point(25, 12)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(157, 17)
        Me.GunaLabel8.TabIndex = 6
        Me.GunaLabel8.Text = "Total Cases Worldwide"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Doubleplus", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GunaLabel7.Location = New System.Drawing.Point(19, 41)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(283, 51)
        Me.GunaLabel7.TabIndex = 7
        Me.GunaLabel7.Text = "DisplayCount"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(721, 10)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(67, 25)
        Me.GunaControlBox1.TabIndex = 0
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(500, 10)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(105, 25)
        Me.GunaButton1.TabIndex = 5
        Me.GunaButton1.Text = "Refresh"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(611, 10)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(105, 25)
        Me.GunaButton2.TabIndex = 6
        Me.GunaButton2.Text = "Minimize"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaElipsePanel4)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "4"
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.GunaElipsePanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaCircleProgressBar2 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaCircleProgressBar3 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaCircleProgressBar4 As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
End Class

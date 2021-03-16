<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BTNregistrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNingresar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNregistrar
        '
        Me.BTNregistrar.BackColor = System.Drawing.Color.Transparent
        Me.BTNregistrar.BackgroundImage = Global.Pasteleria.My.Resources.Resources._464_4648869_boton_png_transparent_png2
        Me.BTNregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNregistrar.FlatAppearance.BorderSize = 0
        Me.BTNregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNregistrar.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNregistrar.Location = New System.Drawing.Point(123, 462)
        Me.BTNregistrar.Name = "BTNregistrar"
        Me.BTNregistrar.Size = New System.Drawing.Size(116, 34)
        Me.BTNregistrar.TabIndex = 1
        Me.BTNregistrar.Text = "Registrarse"
        Me.BTNregistrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(82, 521)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Recuperar Contraseña"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bienvenido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "_____________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "_____________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pasteleria.My.Resources.Resources.muffin
        Me.PictureBox1.Location = New System.Drawing.Point(91, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BTNingresar
        '
        Me.BTNingresar.BackColor = System.Drawing.Color.Transparent
        Me.BTNingresar.BackgroundImage = Global.Pasteleria.My.Resources.Resources._464_4648869_boton_png_transparent_png2
        Me.BTNingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNingresar.FlatAppearance.BorderSize = 0
        Me.BTNingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNingresar.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNingresar.Location = New System.Drawing.Point(132, 409)
        Me.BTNingresar.Name = "BTNingresar"
        Me.BTNingresar.Size = New System.Drawing.Size(97, 32)
        Me.BTNingresar.TabIndex = 0
        Me.BTNingresar.Text = "Ingresar"
        Me.BTNingresar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNingresar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(138, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Dream Pasteleria"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 588)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNregistrar)
        Me.Controls.Add(Me.BTNingresar)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNingresar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNregistrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class

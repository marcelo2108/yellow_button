<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.YButton2 = New yellowButton.yButton()
        Me.YButton1 = New yellowButton.yButton()
        Me.YButton3 = New yellowButton.yButton()
        Me.YButton4 = New yellowButton.yButton()
        Me.SuspendLayout()
        '
        'YButton2
        '
        Me.YButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.YButton2.image = CType(resources.GetObject("YButton2.image"), System.Drawing.Image)
        Me.YButton2.Location = New System.Drawing.Point(50, 45)
        Me.YButton2.Name = "YButton2"
        Me.YButton2.Size = New System.Drawing.Size(60, 70)
        Me.YButton2.TabIndex = 0
        Me.YButton2.y_imageSizeClicked = 80
        Me.YButton2.y_imageSizePercent = 90
        '
        'YButton1
        '
        Me.YButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.YButton1.image = CType(resources.GetObject("YButton1.image"), System.Drawing.Image)
        Me.YButton1.Location = New System.Drawing.Point(405, 0)
        Me.YButton1.Name = "YButton1"
        Me.YButton1.Size = New System.Drawing.Size(35, 35)
        Me.YButton1.TabIndex = 0
        Me.YButton1.y_imageSizeClicked = 3
        Me.YButton1.y_imageSizePercent = 60
        '
        'YButton3
        '
        Me.YButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.YButton3.image = CType(resources.GetObject("YButton3.image"), System.Drawing.Image)
        Me.YButton3.Location = New System.Drawing.Point(135, 75)
        Me.YButton3.Name = "YButton3"
        Me.YButton3.Size = New System.Drawing.Size(60, 70)
        Me.YButton3.TabIndex = 0
        Me.YButton3.y_imageSizeClicked = 80
        Me.YButton3.y_imageSizePercent = 90
        '
        'YButton4
        '
        Me.YButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.YButton4.image = CType(resources.GetObject("YButton4.image"), System.Drawing.Image)
        Me.YButton4.Location = New System.Drawing.Point(235, 110)
        Me.YButton4.Name = "YButton4"
        Me.YButton4.Size = New System.Drawing.Size(60, 70)
        Me.YButton4.TabIndex = 0
        Me.YButton4.y_imageSizeClicked = 80
        Me.YButton4.y_imageSizePercent = 90
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 265)
        Me.Controls.Add(Me.YButton4)
        Me.Controls.Add(Me.YButton3)
        Me.Controls.Add(Me.YButton2)
        Me.Controls.Add(Me.YButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents YButton1 As yButton
    Friend WithEvents YButton2 As yButton
    Friend WithEvents YButton3 As yButton
    Friend WithEvents YButton4 As yButton
End Class

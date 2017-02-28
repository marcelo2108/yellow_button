<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yButton
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.pb_image = New System.Windows.Forms.PictureBox()
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_image
        '
        Me.pb_image.BackColor = System.Drawing.Color.Transparent
        Me.pb_image.Location = New System.Drawing.Point(15, 15)
        Me.pb_image.Name = "pb_image"
        Me.pb_image.Size = New System.Drawing.Size(50, 50)
        Me.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_image.TabIndex = 2
        Me.pb_image.TabStop = False
        '
        'yButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pb_image)
        Me.Name = "yButton"
        CType(Me.pb_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb_image As PictureBox
End Class

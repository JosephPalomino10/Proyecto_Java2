<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblCarteristas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbCarteristas = New System.Windows.Forms.ComboBox()
        Me.CmbTenderos = New System.Windows.Forms.ComboBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LblTenderos = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Visual3.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(90, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 217)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblCarteristas
        '
        Me.LblCarteristas.AutoSize = True
        Me.LblCarteristas.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarteristas.Location = New System.Drawing.Point(33, 294)
        Me.LblCarteristas.Name = "LblCarteristas"
        Me.LblCarteristas.Size = New System.Drawing.Size(146, 31)
        Me.LblCarteristas.TabIndex = 1
        Me.LblCarteristas.Text = "Carteristas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(23, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(371, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pro Sistema De Control"
        '
        'CmbCarteristas
        '
        Me.CmbCarteristas.FormattingEnabled = True
        Me.CmbCarteristas.Items.AddRange(New Object() {"Juan Perez", "Miguel Aguirre", "Carlos Prado"})
        Me.CmbCarteristas.Location = New System.Drawing.Point(238, 305)
        Me.CmbCarteristas.Name = "CmbCarteristas"
        Me.CmbCarteristas.Size = New System.Drawing.Size(121, 21)
        Me.CmbCarteristas.TabIndex = 4
        '
        'CmbTenderos
        '
        Me.CmbTenderos.FormattingEnabled = True
        Me.CmbTenderos.Items.AddRange(New Object() {"Maria Campos", "Julia Pacheco", "Martin Valverde"})
        Me.CmbTenderos.Location = New System.Drawing.Point(238, 336)
        Me.CmbTenderos.Name = "CmbTenderos"
        Me.CmbTenderos.Size = New System.Drawing.Size(121, 21)
        Me.CmbTenderos.TabIndex = 5
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(45, 386)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(313, 76)
        Me.TxtDescripcion.TabIndex = 6
        '
        'LblTenderos
        '
        Me.LblTenderos.AutoSize = True
        Me.LblTenderos.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTenderos.Location = New System.Drawing.Point(39, 326)
        Me.LblTenderos.Name = "LblTenderos"
        Me.LblTenderos.Size = New System.Drawing.Size(121, 31)
        Me.LblTenderos.TabIndex = 2
        Me.LblTenderos.Text = "Tenderos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 480)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.CmbTenderos)
        Me.Controls.Add(Me.CmbCarteristas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblTenderos)
        Me.Controls.Add(Me.LblCarteristas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblCarteristas As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbCarteristas As ComboBox
    Friend WithEvents CmbTenderos As ComboBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LblTenderos As Label
End Class

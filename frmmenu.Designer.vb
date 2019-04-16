<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmdviewrecords = New System.Windows.Forms.Button
        Me.cmdaddrecords = New System.Windows.Forms.Button
        Me.cmdback = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cmdviewrecords
        '
        Me.cmdviewrecords.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cmdviewrecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdviewrecords.Location = New System.Drawing.Point(74, 170)
        Me.cmdviewrecords.Name = "cmdviewrecords"
        Me.cmdviewrecords.Size = New System.Drawing.Size(137, 59)
        Me.cmdviewrecords.TabIndex = 1
        Me.cmdviewrecords.Text = "View records"
        Me.cmdviewrecords.UseVisualStyleBackColor = False
        '
        'cmdaddrecords
        '
        Me.cmdaddrecords.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cmdaddrecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaddrecords.Location = New System.Drawing.Point(74, 266)
        Me.cmdaddrecords.Name = "cmdaddrecords"
        Me.cmdaddrecords.Size = New System.Drawing.Size(137, 56)
        Me.cmdaddrecords.TabIndex = 2
        Me.cmdaddrecords.Text = "Add records"
        Me.cmdaddrecords.UseVisualStyleBackColor = False
        '
        'cmdback
        '
        Me.cmdback.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cmdback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.Location = New System.Drawing.Point(74, 358)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(137, 59)
        Me.cmdback.TabIndex = 3
        Me.cmdback.Text = "Exit"
        Me.cmdback.UseVisualStyleBackColor = False
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(279, 494)
        Me.Controls.Add(Me.cmdback)
        Me.Controls.Add(Me.cmdaddrecords)
        Me.Controls.Add(Me.cmdviewrecords)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmmenu"
        Me.Text = "frmmenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdviewrecords As System.Windows.Forms.Button
    Friend WithEvents cmdaddrecords As System.Windows.Forms.Button
    Friend WithEvents cmdback As System.Windows.Forms.Button
End Class

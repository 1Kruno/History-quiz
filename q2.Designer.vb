<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q2))
        Me.txttimer = New System.Windows.Forms.TextBox
        Me.txtanswer = New System.Windows.Forms.TextBox
        Me.cmdsubmit = New System.Windows.Forms.Button
        Me.lblscore = New System.Windows.Forms.Label
        Me.lblanswer = New System.Windows.Forms.Label
        Me.lblqno = New System.Windows.Forms.Label
        Me.lblanswera = New System.Windows.Forms.Label
        Me.lblanswerb = New System.Windows.Forms.Label
        Me.lblanswerc = New System.Windows.Forms.Label
        Me.lblanswerd = New System.Windows.Forms.Label
        Me.lblq2 = New System.Windows.Forms.Label
        Me.cmdcalc = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblcorrectanswer = New System.Windows.Forms.Label
        Me.cmhelp = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttimer
        '
        Me.txttimer.Location = New System.Drawing.Point(462, 224)
        Me.txttimer.Name = "txttimer"
        Me.txttimer.Size = New System.Drawing.Size(132, 20)
        Me.txttimer.TabIndex = 0
        Me.txttimer.Text = "You have 20 seconds left"
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(210, 508)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(226, 20)
        Me.txtanswer.TabIndex = 1
        '
        'cmdsubmit
        '
        Me.cmdsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsubmit.Location = New System.Drawing.Point(338, 557)
        Me.cmdsubmit.Name = "cmdsubmit"
        Me.cmdsubmit.Size = New System.Drawing.Size(209, 71)
        Me.cmdsubmit.TabIndex = 2
        Me.cmdsubmit.Text = "&Submit"
        Me.cmdsubmit.UseVisualStyleBackColor = True
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(278, 157)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(115, 16)
        Me.lblscore.TabIndex = 3
        Me.lblscore.Text = "Your score so far: "
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswer.Location = New System.Drawing.Point(206, 475)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(230, 20)
        Me.lblanswer.TabIndex = 4
        Me.lblanswer.Text = "Type in you answer A, B, C or D"
        '
        'lblqno
        '
        Me.lblqno.AutoSize = True
        Me.lblqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqno.Location = New System.Drawing.Point(49, 185)
        Me.lblqno.Name = "lblqno"
        Me.lblqno.Size = New System.Drawing.Size(144, 20)
        Me.lblqno.TabIndex = 5
        Me.lblqno.Text = "Question number 2"
        '
        'lblanswera
        '
        Me.lblanswera.AutoSize = True
        Me.lblanswera.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswera.Location = New System.Drawing.Point(104, 263)
        Me.lblanswera.Name = "lblanswera"
        Me.lblanswera.Size = New System.Drawing.Size(75, 25)
        Me.lblanswera.TabIndex = 6
        Me.lblanswera.Text = "A) 485"
        '
        'lblanswerb
        '
        Me.lblanswerb.AutoSize = True
        Me.lblanswerb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerb.Location = New System.Drawing.Point(104, 308)
        Me.lblanswerb.Name = "lblanswerb"
        Me.lblanswerb.Size = New System.Drawing.Size(75, 25)
        Me.lblanswerb.TabIndex = 7
        Me.lblanswerb.Text = "B) 621"
        '
        'lblanswerc
        '
        Me.lblanswerc.AutoSize = True
        Me.lblanswerc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerc.Location = New System.Drawing.Point(104, 352)
        Me.lblanswerc.Name = "lblanswerc"
        Me.lblanswerc.Size = New System.Drawing.Size(76, 25)
        Me.lblanswerc.TabIndex = 8
        Me.lblanswerc.Text = "C) 529"
        '
        'lblanswerd
        '
        Me.lblanswerd.AutoSize = True
        Me.lblanswerd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerd.Location = New System.Drawing.Point(104, 396)
        Me.lblanswerd.Name = "lblanswerd"
        Me.lblanswerd.Size = New System.Drawing.Size(76, 25)
        Me.lblanswerd.TabIndex = 9
        Me.lblanswerd.Text = "D) 493"
        '
        'lblq2
        '
        Me.lblq2.AutoSize = True
        Me.lblq2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblq2.Location = New System.Drawing.Point(48, 224)
        Me.lblq2.Name = "lblq2"
        Me.lblq2.Size = New System.Drawing.Size(254, 25)
        Me.lblq2.TabIndex = 10
        Me.lblq2.Text = "45+89+65+342-14-1+3=?"
        '
        'cmdcalc
        '
        Me.cmdcalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcalc.Location = New System.Drawing.Point(97, 557)
        Me.cmdcalc.Name = "cmdcalc"
        Me.cmdcalc.Size = New System.Drawing.Size(205, 71)
        Me.cmdcalc.TabIndex = 11
        Me.cmdcalc.Text = "&Use calculator"
        Me.cmdcalc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(668, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblcorrectanswer
        '
        Me.lblcorrectanswer.AutoSize = True
        Me.lblcorrectanswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrectanswer.ForeColor = System.Drawing.Color.Lime
        Me.lblcorrectanswer.Location = New System.Drawing.Point(247, 455)
        Me.lblcorrectanswer.Name = "lblcorrectanswer"
        Me.lblcorrectanswer.Size = New System.Drawing.Size(146, 20)
        Me.lblcorrectanswer.TabIndex = 14
        Me.lblcorrectanswer.Text = "Correct answer is C"
        Me.lblcorrectanswer.Visible = False
        '
        'cmhelp
        '
        Me.cmhelp.Location = New System.Drawing.Point(609, 637)
        Me.cmhelp.Name = "cmhelp"
        Me.cmhelp.Size = New System.Drawing.Size(75, 23)
        Me.cmhelp.TabIndex = 15
        Me.cmhelp.Text = "&Help"
        Me.cmhelp.UseVisualStyleBackColor = True
        '
        'q2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.Controls.Add(Me.cmhelp)
        Me.Controls.Add(Me.lblcorrectanswer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdcalc)
        Me.Controls.Add(Me.lblq2)
        Me.Controls.Add(Me.lblanswerd)
        Me.Controls.Add(Me.lblanswerc)
        Me.Controls.Add(Me.lblanswerb)
        Me.Controls.Add(Me.lblanswera)
        Me.Controls.Add(Me.lblqno)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.cmdsubmit)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.txttimer)
        Me.Name = "q2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttimer As System.Windows.Forms.TextBox
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents cmdsubmit As System.Windows.Forms.Button
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents lblanswer As System.Windows.Forms.Label
    Friend WithEvents lblqno As System.Windows.Forms.Label
    Friend WithEvents lblanswera As System.Windows.Forms.Label
    Friend WithEvents lblanswerb As System.Windows.Forms.Label
    Friend WithEvents lblanswerc As System.Windows.Forms.Label
    Friend WithEvents lblanswerd As System.Windows.Forms.Label
    Friend WithEvents lblq2 As System.Windows.Forms.Label
    Friend WithEvents cmdcalc As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblcorrectanswer As System.Windows.Forms.Label
    Friend WithEvents cmhelp As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q6))
        Me.cmdsubmit = New System.Windows.Forms.Button
        Me.txtanswer = New System.Windows.Forms.TextBox
        Me.txttimer = New System.Windows.Forms.TextBox
        Me.lblscore = New System.Windows.Forms.Label
        Me.lblqno = New System.Windows.Forms.Label
        Me.lblq6 = New System.Windows.Forms.Label
        Me.lblanswera = New System.Windows.Forms.Label
        Me.lblanswerb = New System.Windows.Forms.Label
        Me.lblanswerc = New System.Windows.Forms.Label
        Me.lblanswerd = New System.Windows.Forms.Label
        Me.lblanswer = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblcorrectanswer = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdhelp = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdsubmit
        '
        Me.cmdsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsubmit.Location = New System.Drawing.Point(264, 547)
        Me.cmdsubmit.Name = "cmdsubmit"
        Me.cmdsubmit.Size = New System.Drawing.Size(176, 71)
        Me.cmdsubmit.TabIndex = 0
        Me.cmdsubmit.Text = "&Submit"
        Me.cmdsubmit.UseVisualStyleBackColor = True
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(264, 521)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(176, 20)
        Me.txtanswer.TabIndex = 1
        '
        'txttimer
        '
        Me.txttimer.Location = New System.Drawing.Point(502, 206)
        Me.txttimer.Name = "txttimer"
        Me.txttimer.Size = New System.Drawing.Size(135, 20)
        Me.txttimer.TabIndex = 2
        Me.txttimer.Tag = ""
        Me.txttimer.Text = "You have 20 seconds left"
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(272, 158)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(118, 16)
        Me.lblscore.TabIndex = 3
        Me.lblscore.Text = "Your score so far : "
        '
        'lblqno
        '
        Me.lblqno.AutoSize = True
        Me.lblqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqno.Location = New System.Drawing.Point(67, 206)
        Me.lblqno.Name = "lblqno"
        Me.lblqno.Size = New System.Drawing.Size(144, 20)
        Me.lblqno.TabIndex = 4
        Me.lblqno.Text = "Question number 6"
        '
        'lblq6
        '
        Me.lblq6.AutoSize = True
        Me.lblq6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblq6.Location = New System.Drawing.Point(66, 241)
        Me.lblq6.Name = "lblq6"
        Me.lblq6.Size = New System.Drawing.Size(324, 25)
        Me.lblq6.TabIndex = 5
        Me.lblq6.Text = "What is the name of this animal?"
        '
        'lblanswera
        '
        Me.lblanswera.AutoSize = True
        Me.lblanswera.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswera.Location = New System.Drawing.Point(92, 291)
        Me.lblanswera.Name = "lblanswera"
        Me.lblanswera.Size = New System.Drawing.Size(104, 25)
        Me.lblanswera.TabIndex = 6
        Me.lblanswera.Text = "A) Mouse"
        '
        'lblanswerb
        '
        Me.lblanswerb.AutoSize = True
        Me.lblanswerb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerb.Location = New System.Drawing.Point(92, 338)
        Me.lblanswerb.Name = "lblanswerb"
        Me.lblanswerb.Size = New System.Drawing.Size(111, 25)
        Me.lblanswerb.TabIndex = 7
        Me.lblanswerb.Text = "B) Weasel"
        '
        'lblanswerc
        '
        Me.lblanswerc.AutoSize = True
        Me.lblanswerc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerc.Location = New System.Drawing.Point(92, 379)
        Me.lblanswerc.Name = "lblanswerc"
        Me.lblanswerc.Size = New System.Drawing.Size(125, 25)
        Me.lblanswerc.TabIndex = 8
        Me.lblanswerc.Text = "C) Elephant"
        '
        'lblanswerd
        '
        Me.lblanswerd.AutoSize = True
        Me.lblanswerd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerd.Location = New System.Drawing.Point(92, 419)
        Me.lblanswerd.Name = "lblanswerd"
        Me.lblanswerd.Size = New System.Drawing.Size(119, 25)
        Me.lblanswerd.TabIndex = 9
        Me.lblanswerd.Text = "D) Wombat"
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswer.Location = New System.Drawing.Point(250, 489)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(201, 20)
        Me.lblanswer.TabIndex = 10
        Me.lblanswer.Text = "Type in answer A, B, C or D"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(383, 291)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'lblcorrectanswer
        '
        Me.lblcorrectanswer.AutoSize = True
        Me.lblcorrectanswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorrectanswer.ForeColor = System.Drawing.Color.Lime
        Me.lblcorrectanswer.Location = New System.Drawing.Point(282, 469)
        Me.lblcorrectanswer.Name = "lblcorrectanswer"
        Me.lblcorrectanswer.Size = New System.Drawing.Size(147, 20)
        Me.lblcorrectanswer.TabIndex = 12
        Me.lblcorrectanswer.Text = "Correct answer is D"
        Me.lblcorrectanswer.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(664, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cmdhelp
        '
        Me.cmdhelp.Location = New System.Drawing.Point(608, 637)
        Me.cmdhelp.Name = "cmdhelp"
        Me.cmdhelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdhelp.TabIndex = 14
        Me.cmdhelp.Text = "&Help"
        Me.cmdhelp.UseVisualStyleBackColor = True
        '
        'q6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.Controls.Add(Me.cmdhelp)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblcorrectanswer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblanswerd)
        Me.Controls.Add(Me.lblanswerc)
        Me.Controls.Add(Me.lblanswerb)
        Me.Controls.Add(Me.lblanswera)
        Me.Controls.Add(Me.lblq6)
        Me.Controls.Add(Me.lblqno)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.txttimer)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.cmdsubmit)
        Me.Name = "q6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q6"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdsubmit As System.Windows.Forms.Button
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents txttimer As System.Windows.Forms.TextBox
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents lblqno As System.Windows.Forms.Label
    Friend WithEvents lblq6 As System.Windows.Forms.Label
    Friend WithEvents lblanswera As System.Windows.Forms.Label
    Friend WithEvents lblanswerb As System.Windows.Forms.Label
    Friend WithEvents lblanswerc As System.Windows.Forms.Label
    Friend WithEvents lblanswerd As System.Windows.Forms.Label
    Friend WithEvents lblanswer As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcorrectanswer As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmdhelp As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q1))
        Me.txttimer = New System.Windows.Forms.TextBox
        Me.txtanswer = New System.Windows.Forms.TextBox
        Me.cmdsubmit = New System.Windows.Forms.Button
        Me.lblscore = New System.Windows.Forms.Label
        Me.lblqno = New System.Windows.Forms.Label
        Me.lblq1 = New System.Windows.Forms.Label
        Me.lblanswera = New System.Windows.Forms.Label
        Me.lblanswerb = New System.Windows.Forms.Label
        Me.lblanswerc = New System.Windows.Forms.Label
        Me.lblanswerd = New System.Windows.Forms.Label
        Me.lblanswer = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblcorrectanswer = New System.Windows.Forms.Label
        Me.cmdhelp = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttimer
        '
        Me.txttimer.Location = New System.Drawing.Point(462, 171)
        Me.txttimer.Name = "txttimer"
        Me.txttimer.Size = New System.Drawing.Size(152, 20)
        Me.txttimer.TabIndex = 0
        Me.txttimer.Text = "You have 20 seconds"
        '
        'txtanswer
        '
        Me.txtanswer.Location = New System.Drawing.Point(253, 501)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(203, 20)
        Me.txtanswer.TabIndex = 1
        '
        'cmdsubmit
        '
        Me.cmdsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsubmit.Location = New System.Drawing.Point(253, 536)
        Me.cmdsubmit.Name = "cmdsubmit"
        Me.cmdsubmit.Size = New System.Drawing.Size(203, 65)
        Me.cmdsubmit.TabIndex = 2
        Me.cmdsubmit.Text = "&Submit"
        Me.cmdsubmit.UseVisualStyleBackColor = True
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(246, 140)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(92, 16)
        Me.lblscore.TabIndex = 3
        Me.lblscore.Text = "Your score is :"
        '
        'lblqno
        '
        Me.lblqno.AutoSize = True
        Me.lblqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqno.Location = New System.Drawing.Point(64, 188)
        Me.lblqno.Name = "lblqno"
        Me.lblqno.Size = New System.Drawing.Size(144, 20)
        Me.lblqno.TabIndex = 4
        Me.lblqno.Text = "Question number 1"
        '
        'lblq1
        '
        Me.lblq1.AutoSize = True
        Me.lblq1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblq1.Location = New System.Drawing.Point(63, 225)
        Me.lblq1.Name = "lblq1"
        Me.lblq1.Size = New System.Drawing.Size(275, 25)
        Me.lblq1.TabIndex = 5
        Me.lblq1.Text = "Prefix for country Russia is:"
        '
        'lblanswera
        '
        Me.lblanswera.AutoSize = True
        Me.lblanswera.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswera.Location = New System.Drawing.Point(92, 279)
        Me.lblanswera.Name = "lblanswera"
        Me.lblanswera.Size = New System.Drawing.Size(106, 25)
        Me.lblanswera.TabIndex = 6
        Me.lblanswera.Text = "A) Mother"
        '
        'lblanswerb
        '
        Me.lblanswerb.AutoSize = True
        Me.lblanswerb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerb.Location = New System.Drawing.Point(92, 321)
        Me.lblanswerb.Name = "lblanswerb"
        Me.lblanswerb.Size = New System.Drawing.Size(101, 25)
        Me.lblanswerb.TabIndex = 7
        Me.lblanswerb.Text = "B) Father"
        '
        'lblanswerc
        '
        Me.lblanswerc.AutoSize = True
        Me.lblanswerc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerc.Location = New System.Drawing.Point(92, 363)
        Me.lblanswerc.Name = "lblanswerc"
        Me.lblanswerc.Size = New System.Drawing.Size(95, 25)
        Me.lblanswerc.TabIndex = 8
        Me.lblanswerc.Text = "C) Uncle"
        '
        'lblanswerd
        '
        Me.lblanswerd.AutoSize = True
        Me.lblanswerd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswerd.Location = New System.Drawing.Point(92, 402)
        Me.lblanswerd.Name = "lblanswerd"
        Me.lblanswerd.Size = New System.Drawing.Size(84, 25)
        Me.lblanswerd.TabIndex = 9
        Me.lblanswerd.Text = "D) Aunt"
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanswer.Location = New System.Drawing.Point(238, 468)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(235, 20)
        Me.lblanswer.TabIndex = 10
        Me.lblanswer.Text = "Type in your answer A, B, C or D"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(673, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
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
        Me.lblcorrectanswer.Location = New System.Drawing.Point(280, 448)
        Me.lblcorrectanswer.Name = "lblcorrectanswer"
        Me.lblcorrectanswer.Size = New System.Drawing.Size(146, 20)
        Me.lblcorrectanswer.TabIndex = 13
        Me.lblcorrectanswer.Text = "Correct answer is A"
        Me.lblcorrectanswer.Visible = False
        '
        'cmdhelp
        '
        Me.cmdhelp.Location = New System.Drawing.Point(603, 637)
        Me.cmdhelp.Name = "cmdhelp"
        Me.cmdhelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdhelp.TabIndex = 14
        Me.cmdhelp.Text = "&Help"
        Me.cmdhelp.UseVisualStyleBackColor = True
        '
        'q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.Controls.Add(Me.cmdhelp)
        Me.Controls.Add(Me.lblcorrectanswer)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblanswerd)
        Me.Controls.Add(Me.lblanswerc)
        Me.Controls.Add(Me.lblanswerb)
        Me.Controls.Add(Me.lblanswera)
        Me.Controls.Add(Me.lblq1)
        Me.Controls.Add(Me.lblqno)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.cmdsubmit)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.txttimer)
        Me.Name = "q1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q10"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttimer As System.Windows.Forms.TextBox
    Friend WithEvents txtanswer As System.Windows.Forms.TextBox
    Friend WithEvents cmdsubmit As System.Windows.Forms.Button
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents lblqno As System.Windows.Forms.Label
    Friend WithEvents lblq1 As System.Windows.Forms.Label
    Friend WithEvents lblanswera As System.Windows.Forms.Label
    Friend WithEvents lblanswerb As System.Windows.Forms.Label
    Friend WithEvents lblanswerc As System.Windows.Forms.Label
    Friend WithEvents lblanswerd As System.Windows.Forms.Label
    Friend WithEvents lblanswer As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblcorrectanswer As System.Windows.Forms.Label
    Friend WithEvents cmdhelp As System.Windows.Forms.Button
End Class

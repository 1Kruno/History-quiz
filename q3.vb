﻿Public Class q3
    'user has a question to answer'
    'user has 4 answers to pick from'
    'only one answer is correct'
    'user has 20 seconds to answer every question'
    Private Sub cmdsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
        On Error Resume Next
        Timer1.Enabled = False
        accumulator1 = accumulator1 + counter
        correct_A = lblcorrectanswer.Text
        Q_count = Q_count + 1
        lblcorrectanswer.Show()
        MsgBox("Correct answer is B. Your score so far:" & score)
        q4.Show()

        Me.Hide()
        txtanswer.Text = ""




        lblscore.Text = "Your score so far: "
        txttimer.Text = "You have 20 seconds"
    End Sub

    Private Sub q3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Q_count = 2
        lblscore.Text = "Your score " & score
        lblcorrectanswer.Text = "Correct answer is " & correct_answer(2)
        Timer1.Enabled = True
        txtanswer.Focus()
        counter = 20
        lblqno.Text = "Question number " & numbers(2)
        lblanswera.Text = answera(2)
        lblanswerb.Text = answerb(2)
        lblanswerc.Text = answerc(2)
        lblanswerd.Text = answerd(2)
        If user = "tester" Then
            lblcorrectanswer.Visible = True

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        counter = counter - 1
        txttimer.Text = counter & " seconds left"
        If counter < 6 Then
            txttimer.Text = "Hurry up " & user & " " & counter & " seconds left "
        End If

        If counter = 0 Then
            Timer1.Enabled = False
            Call cmdsubmit_Click(cmdsubmit, New System.EventArgs())

        End If
    End Sub

    Private Sub txtanswer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtanswer.TextChanged
        answer_selected = txtanswer.Text
        If (answer_selected = "B") Or (answer_selected = "b") Then
            score = score + 1
            lblscore.Text = "Your score " & score


        End If
    End Sub

    Private Sub cmdhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdhelp.Click
        On Error Resume Next
        frmhelp.Show()

    End Sub

    Private Sub lblqno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblqno.Click

    End Sub
End Class
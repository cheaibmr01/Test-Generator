Public Class frmTest

    Dim cqpos As Integer

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cqpos = 0
        ShowQuestions(cqpos)
        cmdFinish.Hide()
    End Sub
    Public Sub ShowQuestions(qpos As Integer)
        lblqnum.Text = CStr(cqpos + 1) + "."
        lblquestion.Text = test(qpos).question
        optChoiceA.Text = test(qpos).choiceA
        optChoiceB.Text = test(qpos).choiceB
        optChoiceC.Text = test(qpos).choiceC
        optChoiceD.Text = test(qpos).choiceD

    End Sub
    Private Sub cmdNext_Click(sender As System.Object, e As System.EventArgs) Handles cmdNext.Click

        CalculateGrade()
        If (cqpos < NumOfQuest - 1) Then
            cqpos = cqpos + 1
            ShowQuestions(cqpos)
            If (cqpos = NumOfQuest - 1) Then
                cmdNext.Hide()
                cmdFinish.Show()
            End If
        End If
        optChoiceA.Checked = False
        optChoiceB.Checked = False
        optChoiceC.Checked = False
        optChoiceD.Checked = False
    End Sub

    Private Sub CalculateGrade()
        Dim StudentAnswer As String


        If optChoiceA.Checked Then
            StudentAnswer = "A"
        ElseIf optChoiceB.Checked Then
            StudentAnswer = "B"
        ElseIf optChoiceC.Checked Then
            StudentAnswer = "C"
        ElseIf optChoiceD.Checked Then
            StudentAnswer = "D"
        Else
            StudentAnswer = "*"
        End If
        StudentChoice(cqpos) = StudentAnswer
        optChoiceA.Checked = False
        optChoiceB.Checked = False
        optChoiceC.Checked = False
        optChoiceD.Checked = False

        If (StudentAnswer = test(cqpos).correctAnswer) Then
            StudentTotalScore = StudentTotalScore + CorrectAnswer
        ElseIf (StudentAnswer = "*") Then
            StudentTotalScore = StudentTotalScore + 0
        Else
            StudentTotalScore = StudentTotalScore - WrongAnswer
        End If

    End Sub

    Private Sub cmdFinish_Click(sender As System.Object, e As System.EventArgs) Handles cmdFinish.Click
        Dim StudentMessageBox As String
        Dim count As Integer

        CalculateGrade()
        count = 0
        StudentMessageBox = "Correct Answers          Student Answers" + vbNewLine + vbNewLine
        Do While (count < NumOfQuest)
            StudentMessageBox = StudentMessageBox + "           " + test(count).correctAnswer + "                                         " +
                                                    StudentChoice(count) + vbNewLine

            count = count + 1
        Loop

        MessageBox.Show(StudentMessageBox + vbNewLine + "Your Score: " + CStr(StudentTotalScore) + vbNewLine + vbNewLine + "* indicates that you did not answer the question", "Test Results")
        Me.Hide()
        FrmMain.Show()
    End Sub

    Private Sub optChoiceD_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optChoiceD.CheckedChanged

    End Sub

    Private Sub optChoiceA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optChoiceA.CheckedChanged

    End Sub

    Private Sub optChoiceC_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optChoiceC.CheckedChanged

    End Sub

    Private Sub optChoiceB_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optChoiceB.CheckedChanged

    End Sub
End Class
Public Class frmQNums
    Dim MaxNum As Integer

    Private Sub lstBegin_Click(sender As System.Object, e As System.EventArgs) Handles lstBegin.Click
        frmTest.Show()
        Me.Hide()
    End Sub

    Private Sub lstNumberQuestions_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstNumberQuestions.SelectedIndexChanged
        NumOfQuest = lstNumberQuestions.SelectedIndex + 5
        CorrectAnswer = 100 / NumOfQuest
        WrongAnswer = CorrectAnswer / 2

        'MessageBox.Show(CorrectAnswer, "correct")
        'MessageBox.Show(WrongAnswer, "wrong")
    End Sub

    Private Sub frmQNums_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstNumberQuestions.SelectedIndex = 5
    End Sub
End Class
Option Explicit On

Imports System.IO

Public Class FrmMain
    Dim qc As Integer

    


    Private Sub FrmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        qc = 0
        TookTest = False
        FileOpen(1, "test1.dat", OpenMode.Random, , , Len(test(0)))

        While (qc < MaxNoOfQuestions)
            FileGet(1, test(qc))
            qc = qc + 1
        End While
    End Sub

    Private Sub cmdTakeTest_Click(sender As System.Object, e As System.EventArgs) Handles cmdTakeTest.Click
        Dim MsgBoxChoice As DialogResult
        If (TookTest = False) Then
            TookTest = True
            frmQNums.Show()
            Me.Hide()
        Else
            MsgBoxChoice = MessageBox.Show("You already took the test!", "Testing Error", _
                      MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cmdExitTest_Click(sender As System.Object, e As System.EventArgs) Handles cmdExitTest.Click
        End
    End Sub
End Class


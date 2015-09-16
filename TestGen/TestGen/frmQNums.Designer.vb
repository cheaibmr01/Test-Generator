<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQNums
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
        Me.lstNumberQuestions = New System.Windows.Forms.ListBox()
        Me.lstBegin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstNumberQuestions
        '
        Me.lstNumberQuestions.FormattingEnabled = True
        Me.lstNumberQuestions.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10"})
        Me.lstNumberQuestions.Location = New System.Drawing.Point(123, 69)
        Me.lstNumberQuestions.Name = "lstNumberQuestions"
        Me.lstNumberQuestions.Size = New System.Drawing.Size(26, 95)
        Me.lstNumberQuestions.TabIndex = 0
        '
        'lstBegin
        '
        Me.lstBegin.Location = New System.Drawing.Point(76, 181)
        Me.lstBegin.Name = "lstBegin"
        Me.lstBegin.Size = New System.Drawing.Size(133, 31)
        Me.lstBegin.TabIndex = 1
        Me.lstBegin.Text = "Begin Test"
        Me.lstBegin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select the number of questions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for your test:"
        '
        'frmQNums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBegin)
        Me.Controls.Add(Me.lstNumberQuestions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQNums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Number of Questions?"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstNumberQuestions As System.Windows.Forms.ListBox
    Friend WithEvents lstBegin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

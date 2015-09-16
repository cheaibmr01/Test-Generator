<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.optChoiceA = New System.Windows.Forms.RadioButton()
        Me.optChoiceD = New System.Windows.Forms.RadioButton()
        Me.optChoiceC = New System.Windows.Forms.RadioButton()
        Me.optChoiceB = New System.Windows.Forms.RadioButton()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.cmdFinish = New System.Windows.Forms.Button()
        Me.lblqnum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblquestion
        '
        Me.lblquestion.Location = New System.Drawing.Point(103, 57)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(416, 43)
        Me.lblquestion.TabIndex = 0
        Me.lblquestion.Text = "Label1"
        '
        'optChoiceA
        '
        Me.optChoiceA.AutoSize = True
        Me.optChoiceA.Location = New System.Drawing.Point(97, 116)
        Me.optChoiceA.Name = "optChoiceA"
        Me.optChoiceA.Size = New System.Drawing.Size(14, 13)
        Me.optChoiceA.TabIndex = 1
        Me.optChoiceA.TabStop = True
        Me.optChoiceA.UseVisualStyleBackColor = True
        '
        'optChoiceD
        '
        Me.optChoiceD.AutoSize = True
        Me.optChoiceD.Location = New System.Drawing.Point(97, 223)
        Me.optChoiceD.Name = "optChoiceD"
        Me.optChoiceD.Size = New System.Drawing.Size(14, 13)
        Me.optChoiceD.TabIndex = 2
        Me.optChoiceD.TabStop = True
        Me.optChoiceD.UseVisualStyleBackColor = True
        '
        'optChoiceC
        '
        Me.optChoiceC.AutoSize = True
        Me.optChoiceC.Location = New System.Drawing.Point(97, 186)
        Me.optChoiceC.Name = "optChoiceC"
        Me.optChoiceC.Size = New System.Drawing.Size(14, 13)
        Me.optChoiceC.TabIndex = 3
        Me.optChoiceC.TabStop = True
        Me.optChoiceC.UseVisualStyleBackColor = True
        '
        'optChoiceB
        '
        Me.optChoiceB.AutoSize = True
        Me.optChoiceB.Location = New System.Drawing.Point(97, 151)
        Me.optChoiceB.Name = "optChoiceB"
        Me.optChoiceB.Size = New System.Drawing.Size(14, 13)
        Me.optChoiceB.TabIndex = 4
        Me.optChoiceB.TabStop = True
        Me.optChoiceB.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(414, 256)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(135, 33)
        Me.cmdNext.TabIndex = 0
        Me.cmdNext.Text = "Next Question"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdFinish
        '
        Me.cmdFinish.Location = New System.Drawing.Point(414, 256)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(135, 33)
        Me.cmdFinish.TabIndex = 5
        Me.cmdFinish.Text = "Finished"
        Me.cmdFinish.UseVisualStyleBackColor = True
        '
        'lblqnum
        '
        Me.lblqnum.Location = New System.Drawing.Point(34, 76)
        Me.lblqnum.Name = "lblqnum"
        Me.lblqnum.Size = New System.Drawing.Size(36, 24)
        Me.lblqnum.TabIndex = 6
        Me.lblqnum.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select the correct answer:"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblqnum)
        Me.Controls.Add(Me.cmdFinish)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.optChoiceB)
        Me.Controls.Add(Me.optChoiceC)
        Me.Controls.Add(Me.optChoiceD)
        Me.Controls.Add(Me.optChoiceA)
        Me.Controls.Add(Me.lblquestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mrc wishes you good Luck!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents optChoiceA As System.Windows.Forms.RadioButton
    Friend WithEvents optChoiceD As System.Windows.Forms.RadioButton
    Friend WithEvents optChoiceC As System.Windows.Forms.RadioButton
    Friend WithEvents optChoiceB As System.Windows.Forms.RadioButton
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdFinish As System.Windows.Forms.Button
    Friend WithEvents lblqnum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

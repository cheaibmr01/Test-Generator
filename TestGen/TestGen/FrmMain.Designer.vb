﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.cmdTakeTest = New System.Windows.Forms.Button()
        Me.cmdExitTest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdTakeTest
        '
        Me.cmdTakeTest.Location = New System.Drawing.Point(99, 219)
        Me.cmdTakeTest.Name = "cmdTakeTest"
        Me.cmdTakeTest.Size = New System.Drawing.Size(148, 41)
        Me.cmdTakeTest.TabIndex = 2
        Me.cmdTakeTest.Text = "Take Test"
        Me.cmdTakeTest.UseVisualStyleBackColor = True
        '
        'cmdExitTest
        '
        Me.cmdExitTest.Location = New System.Drawing.Point(99, 292)
        Me.cmdExitTest.Name = "cmdExitTest"
        Me.cmdExitTest.Size = New System.Drawing.Size(148, 41)
        Me.cmdExitTest.TabIndex = 3
        Me.cmdExitTest.Text = "Exit TestGen"
        Me.cmdExitTest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 130)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 43)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "This Program administers and records your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "answers to a ten-question test."
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 345)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExitTest)
        Me.Controls.Add(Me.cmdTakeTest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mrc's Test Generator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdTakeTest As System.Windows.Forms.Button
    Friend WithEvents cmdExitTest As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

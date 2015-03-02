<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResults
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
        Me.lstResults = New System.Windows.Forms.ListBox
        Me.btnFinish = New System.Windows.Forms.Button
        Me.lblRound = New System.Windows.Forms.Label
        Me.lblPlayer1 = New System.Windows.Forms.Label
        Me.lblPlayer2 = New System.Windows.Forms.Label
        Me.lblPlayer1Score = New System.Windows.Forms.Label
        Me.lblPlayer2Score = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(12, 29)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(172, 95)
        Me.lstResults.TabIndex = 0
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(109, 202)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 1
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Location = New System.Drawing.Point(12, 10)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(39, 13)
        Me.lblRound.TabIndex = 2
        Me.lblRound.Text = "Round"
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(66, 9)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(20, 13)
        Me.lblPlayer1.TabIndex = 3
        Me.lblPlayer1.Text = "P1"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(106, 9)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(20, 13)
        Me.lblPlayer2.TabIndex = 4
        Me.lblPlayer2.Text = "P2"
        '
        'lblPlayer1Score
        '
        Me.lblPlayer1Score.AutoSize = True
        Me.lblPlayer1Score.Location = New System.Drawing.Point(9, 132)
        Me.lblPlayer1Score.Name = "lblPlayer1Score"
        Me.lblPlayer1Score.Size = New System.Drawing.Size(0, 13)
        Me.lblPlayer1Score.TabIndex = 5
        '
        'lblPlayer2Score
        '
        Me.lblPlayer2Score.AutoSize = True
        Me.lblPlayer2Score.Location = New System.Drawing.Point(9, 169)
        Me.lblPlayer2Score.Name = "lblPlayer2Score"
        Me.lblPlayer2Score.Size = New System.Drawing.Size(0, 13)
        Me.lblPlayer2Score.TabIndex = 6
        '
        'frmResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 246)
        Me.Controls.Add(Me.lblPlayer2Score)
        Me.Controls.Add(Me.lblPlayer1Score)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.lblRound)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.lstResults)
        Me.Name = "frmResults"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents lblRound As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer1Score As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2Score As System.Windows.Forms.Label
End Class

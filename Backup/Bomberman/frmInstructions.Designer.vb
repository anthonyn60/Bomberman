<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Me.lblInstructions = New System.Windows.Forms.Label
        Me.lblInstructions2 = New System.Windows.Forms.Label
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblInstructions3 = New System.Windows.Forms.Label
        Me.lblInstructions4 = New System.Windows.Forms.Label
        Me.lblInstructions5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(13, 13)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(271, 13)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Player 1 Controls: WASD for movement, U to drop bomb"
        '
        'lblInstructions2
        '
        Me.lblInstructions2.AutoSize = True
        Me.lblInstructions2.Location = New System.Drawing.Point(12, 41)
        Me.lblInstructions2.Name = "lblInstructions2"
        Me.lblInstructions2.Size = New System.Drawing.Size(336, 13)
        Me.lblInstructions2.TabIndex = 1
        Me.lblInstructions2.Text = "Player 2 Controls: Up Down Left Right for movement, ""Delete"" to drop"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(308, 140)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblInstructions3
        '
        Me.lblInstructions3.AutoSize = True
        Me.lblInstructions3.Location = New System.Drawing.Point(13, 65)
        Me.lblInstructions3.Name = "lblInstructions3"
        Me.lblInstructions3.Size = New System.Drawing.Size(239, 13)
        Me.lblInstructions3.TabIndex = 3
        Me.lblInstructions3.Text = "Collect power-ups to make a more powerful bomb"
        '
        'lblInstructions4
        '
        Me.lblInstructions4.AutoSize = True
        Me.lblInstructions4.Location = New System.Drawing.Point(12, 89)
        Me.lblInstructions4.Name = "lblInstructions4"
        Me.lblInstructions4.Size = New System.Drawing.Size(297, 13)
        Me.lblInstructions4.TabIndex = 4
        Me.lblInstructions4.Text = "Avoid the bomb explosions, try to get the other player into one"
        '
        'lblInstructions5
        '
        Me.lblInstructions5.AutoSize = True
        Me.lblInstructions5.Location = New System.Drawing.Point(15, 117)
        Me.lblInstructions5.Name = "lblInstructions5"
        Me.lblInstructions5.Size = New System.Drawing.Size(256, 13)
        Me.lblInstructions5.TabIndex = 5
        Me.lblInstructions5.Text = "Do NOT try button mashing, drop one bomb at a time"
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(395, 178)
        Me.Controls.Add(Me.lblInstructions5)
        Me.Controls.Add(Me.lblInstructions4)
        Me.Controls.Add(Me.lblInstructions3)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblInstructions2)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "frmInstructions"
        Me.Text = "frmInstructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblInstructions2 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblInstructions3 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions4 As System.Windows.Forms.Label
    Friend WithEvents lblInstructions5 As System.Windows.Forms.Label
End Class

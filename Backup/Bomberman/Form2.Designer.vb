<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Me.lblWelcome = New System.Windows.Forms.Label
        Me.picBomberman = New System.Windows.Forms.PictureBox
        Me.lblPlayer1 = New System.Windows.Forms.Label
        Me.lblPlayer2 = New System.Windows.Forms.Label
        Me.txtPlayer1 = New System.Windows.Forms.TextBox
        Me.txtPlayer2 = New System.Windows.Forms.TextBox
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblMessage = New System.Windows.Forms.Label
        CType(Me.picBomberman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(29, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(410, 39)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Bomberman!"
        '
        'picBomberman
        '
        Me.picBomberman.Image = Global.Bomberman.My.Resources.Resources.Bomberman1
        Me.picBomberman.Location = New System.Drawing.Point(157, 60)
        Me.picBomberman.Name = "picBomberman"
        Me.picBomberman.Size = New System.Drawing.Size(147, 165)
        Me.picBomberman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBomberman.TabIndex = 1
        Me.picBomberman.TabStop = False
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Location = New System.Drawing.Point(95, 244)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(79, 13)
        Me.lblPlayer1.TabIndex = 2
        Me.lblPlayer1.Text = "Player 1 Name:"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Location = New System.Drawing.Point(95, 275)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(79, 13)
        Me.lblPlayer2.TabIndex = 3
        Me.lblPlayer2.Text = "Player 2 Name:"
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Location = New System.Drawing.Point(180, 241)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(185, 20)
        Me.txtPlayer1.TabIndex = 4
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Location = New System.Drawing.Point(180, 272)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(185, 20)
        Me.txtPlayer2.TabIndex = 5
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(355, 298)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(13, 60)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(131, 13)
        Me.lblMessage.TabIndex = 7
        Me.lblMessage.Text = "Game by Anthony Nguyen"
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(471, 336)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.picBomberman)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "frmIntro"
        Me.Text = "Bomberman"
        CType(Me.picBomberman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents picBomberman As System.Windows.Forms.PictureBox
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class

Public Class frmIntro
    'Anthony Nguyen
    'Submitted to Mr. MacAskill
    'Final Project

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        strName1 = txtPlayer1.Text
        strName2 = txtPlayer2.Text
        Me.Hide()
        frmInstructions.Show()
    End Sub

    Private Sub frmIntro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMessage.Text = "Game by Anthony Nguyen" & vbCrLf & "June 15, 2012" & vbCrLf & "ICS4U1 MacAskill"
    End Sub
End Class
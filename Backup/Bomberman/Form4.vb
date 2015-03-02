Public Class frmResults

    Private Sub frmResults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For intRound As Integer = 1 To 5
            lstResults.Items.Add(intRound & vbTab & intScore1(intRound) & vbTab & intScore2(intRound))
        Next intRound

        For intRound As Integer = 1 To 5
            intTotal1 += intScore1(intRound)
            intTotal2 += intScore2(intRound)
        Next intRound
        lblPlayer1Score.Text = strName1 & " score: " & intTotal1
        lblPlayer2Score.Text = strName2 & " score: " & intTotal2

    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        Me.Close()
    End Sub
End Class
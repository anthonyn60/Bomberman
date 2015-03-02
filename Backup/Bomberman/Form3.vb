Public Class frmLoad

    Private Sub frmLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblRound.Text = "Round " & (intRound + 1)
        If intRound = 5 Then
            Me.Close()
            frmResults.Show()
        End If
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        frmGame.Show()
        Me.Close()

    End Sub
End Class
Public Class frmGame

    Dim intX1 = 27, intY1 = 56, intX2 = 279, intY2 = 504, intFire1, intFire2 As Integer
    Dim intTimer2 As Integer
    Dim intTimer As Integer
    Dim intTimer3, intTimer4 As Integer



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If intRound <= 5 Then
            intRound += 1
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            picBomberman1.Image = My.Resources.bomberman_1_up
            intY1 -= 28
            picBomberman1.Location = New Point(intX1, intY1)
            If picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBomberman2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intY1 += 28
                picBomberman1.Location = New Point(intX1, intY1)

            ElseIf picBomberman1.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire1 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire1 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
            picBomberman1.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
            picBomberman1.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
            picBomberman1.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
            picBomberman1.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
            picBomberman1.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
            picBomberman1.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
            picBomberman1.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 0
                intScore2(intRound) = 1
                MessageBox.Show("Player 2 wins!")
                frmLoad.Show()
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.S Then
            picBomberman1.Image = My.Resources.bomberman_1_down
            intY1 += 28
            picBomberman1.Location = New Point(intX1, intY1)
            If picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBomberman2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intY1 -= 28
                picBomberman1.Location = New Point(intX1, intY1)
            ElseIf picBomberman1.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire1 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire1 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 0
                intScore2(intRound) = 1
                MessageBox.Show("Player 2 wins!")
                frmLoad.Show()
                Me.Close()

            End If
        End If

        If e.KeyCode = Keys.A Then
            picBomberman1.Image = My.Resources.bomberman_1_left
            intX1 -= 21
            picBomberman1.Location = New Point(intX1, intY1)
            If picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBomberman2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picFrameLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intX1 += 21
                picBomberman1.Location = New Point(intX1, intY1)

            ElseIf picBomberman1.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire1 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire1 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 0
                intScore2(intRound) = 1
                MessageBox.Show("Player 2 wins!")
                frmLoad.Show()
                Me.Close()
            End If

        End If

        If e.KeyCode = Keys.D Then
            picBomberman1.Image = My.Resources.bomberman_1_right
            intX1 += 21
            picBomberman1.Location = New Point(intX1, intY1)
            If picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picBomberman2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameTop.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picFrameLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picFrameRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intX1 -= 21
                picBomberman1.Location = New Point(intX1, intY1)

            ElseIf picBomberman1.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire1 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire1 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman1.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 0
                intScore2(intRound) = 1
                MessageBox.Show("Player 2 wins!")
                frmLoad.Show()
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Up Then
            picBomberman2.Image = My.Resources.bomberman_2_up
            intY2 -= 28
            picBomberman2.Location = New Point(intX2, intY2)
            If picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBomberman1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intY2 += 28
                picBomberman2.Location = New Point(intX2, intY2)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire2 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire2 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 1
                intScore2(intRound) = 0
                MessageBox.Show("Player 1 wins!")
                frmLoad.Show()
                Me.Close()
            End If

        End If
        If e.KeyCode = Keys.Down Then
            picBomberman2.Image = My.Resources.bomberman_2_down
            intY2 += 28
            picBomberman2.Location = New Point(intX2, intY2)
            If picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBomberman1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intY2 -= 28
                picBomberman2.Location = New Point(intX2, intY2)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire2 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire2 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 1
                intScore2(intRound) = 0
                MessageBox.Show("Player 1 wins!")
                frmLoad.Show()
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Left Then
            picBomberman2.Image = My.Resources.bomberman_2_left
            intX2 -= 21
            picBomberman2.Location = New Point(intX2, intY2)
            If picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBomberman1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picFrameLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intX2 += 21
                picBomberman2.Location = New Point(intX2, intY2)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire2 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire2 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 1
                intScore2(intRound) = 0
                MessageBox.Show("Player 1 wins!")
                frmLoad.Show()
                Me.Close()
            End If
        End If

        If e.KeyCode = Keys.Right Then
            picBomberman2.Image = My.Resources.bomberman_2_right
            intX2 += 21
            picBomberman2.Location = New Point(intX2, intY2)
            If picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picMetal46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picMetal48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick2.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick4.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick7.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick8.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick9.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick10.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick11.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick12.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick13.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick14.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick15.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick16.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick17.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick18.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick19.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick20.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick21.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick22.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick23.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick24.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick25.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick26.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick27.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick28.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick29.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick30.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick31.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick32.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick33.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick34.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick35.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick36.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick37.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick38.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick39.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick40.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick41.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick42.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick43.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick44.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick45.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick46.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick47.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick48.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick49.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick50.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick51.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick52.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick53.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick54.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick55.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick56.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick57.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick58.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick59.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick60.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick61.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick62.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick63.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick64.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick65.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick66.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick67.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick68.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick69.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick70.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick71.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBrick72.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBrick73.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picBomberman1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameBottom.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameTop.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picFrameLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picFrameRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picBomb2.Bounds) Then
                intX2 -= 21
                picBomberman2.Location = New Point(intX2, intY2)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire1.Bounds) Then
                intFire2 += 1
                picFire1.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picFire2.Bounds) Then
                intFire2 += 1
                picFire2.Location = New Point(1500, 1500)
            ElseIf picBomberman2.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
                intScore1(intRound) = 1
                intScore2(intRound) = 0
                MessageBox.Show("Player 1 wins!")
                frmLoad.Show()
                Me.Close()

            End If
        End If

        If e.KeyCode = Keys.U Then
            If tmrBomb.Enabled = False Then
                picBomb1.Bounds = picBomberman1.Bounds
                tmrBomb.Enabled = True
            End If
        End If

        If e.KeyCode = Keys.Delete Then
            If tmrBomb2.Enabled = False Then
                picBomb2.Bounds = picBomberman2.Bounds
                tmrBomb2.Enabled = True
            End If
        End If




    End Sub

    Private Sub tmrBomb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBomb.Tick
        intTimer += 1
        If intTimer = 1 Then
            tmrExplosion1.Enabled = True
            intTimer = 0
            tmrBomb.Enabled = False

            picExplode1.Bounds = picBomb1.Bounds
            picExplodeLeft.Location = New Point((picExplode1.Location.X - 21), picExplode1.Location.Y)
            picExplodeRight.Location = New Point((picExplode1.Location.X + 21), picExplode1.Location.Y)
            picExplodeUp.Location = New Point((picExplode1.Location.X), picExplode1.Location.Y - 28)
            picExplodeDown.Location = New Point((picExplode1.Location.X), picExplode1.Location.Y + 28)
            If picExplodeLeft.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeLeft.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picFrameLeft.Bounds) Then
                picExplodeLeft.Location = New Point(1000, 1000)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If

            If picExplodeRight.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeRight.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeRight.Bounds.IntersectsWith(picFrameRight.Bounds) Then
                picExplodeRight.Location = New Point(1000, 1000)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeRight.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
        End If
        If picExplodeUp.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeUp.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeUp.Bounds.IntersectsWith(picFrameTop.Bounds) Then
            picExplodeUp.Location = New Point(1000, 1000)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeUp.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If
        If picExplodeDown.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeDown.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeDown.Bounds.IntersectsWith(picFrameBottom.Bounds) Then
            picExplodeDown.Location = New Point(1000, 1000)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeDown.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If

        If intFire1 >= 1 Then
            picExplodeLeft2.Location = New Point((picExplodeLeft.Location.X - 21), picExplodeLeft.Location.Y)
            picExplodeRight2.Location = New Point((picExplodeRight.Location.X + 21), picExplodeRight.Location.Y)
            picExplodeUp2.Location = New Point((picExplodeUp.Location.X), picExplodeUp.Location.Y - 28)
            picExplodeDown2.Location = New Point((picExplodeDown.Location.X), picExplodeDown.Location.Y + 28)
            If picExplodeLeft2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeLeft2.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeLeft2.Bounds.IntersectsWith(picFrameLeft.Bounds) Then
                picExplodeLeft2.Location = New Point(1000, 1000)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft2.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
            If picExplodeRight2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeRight2.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeRight2.Bounds.IntersectsWith(picFrameRight.Bounds) Then
                picExplodeRight2.Location = New Point(1000, 1000)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeRight2.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
        End If
        If picExplodeUp2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeUp2.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeUp2.Bounds.IntersectsWith(picFrameTop.Bounds) Then
            picExplodeUp2.Location = New Point(1000, 1000)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeUp2.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If
        If picExplodeDown2.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeDown2.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeDown2.Bounds.IntersectsWith(picFrameBottom.Bounds) Then
            picExplodeDown2.Location = New Point(1000, 1000)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeDown2.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If

        If intFire1 >= 2 Then
            picExplodeLeft3.Location = New Point((picExplodeLeft2.Location.X - 21), picExplodeLeft2.Location.Y)
            picExplodeRight3.Location = New Point((picExplodeRight2.Location.X + 21), picExplodeRight2.Location.Y)
            picExplodeUp3.Location = New Point((picExplodeUp2.Location.X), picExplodeUp2.Location.Y - 28)
            picExplodeDown3.Location = New Point((picExplodeDown2.Location.X), picExplodeDown2.Location.Y + 28)
            If picExplodeLeft3.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeLeft3.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeLeft3.Bounds.IntersectsWith(picFrameLeft.Bounds) Then
                picExplodeLeft3.Location = New Point(1000, 1000)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft3.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
            If picExplodeRight3.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeRight3.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeRight3.Bounds.IntersectsWith(picFrameRight.Bounds) Then
                picExplodeRight3.Location = New Point(1000, 1000)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeRight3.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
        End If
        If picExplodeUp3.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeUp3.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeUp3.Bounds.IntersectsWith(picFrameTop.Bounds) Then
            picExplodeUp3.Location = New Point(1000, 1000)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeUp3.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If
        If picExplodeDown3.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeDown3.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeDown3.Bounds.IntersectsWith(picFrameBottom.Bounds) Then
            picExplodeDown3.Location = New Point(1000, 1000)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeDown3.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If

        If picBomberman1.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman1.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
            intScore1(intRound) = 0
            intScore2(intRound) = 1
            MessageBox.Show("Player 2 wins!")
            frmLoad.Show()
            Me.Close()
        End If
        If picBomberman2.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
            intScore1(intRound) = 1
            intScore2(intRound) = 0
            MessageBox.Show("Player 1 wins!")
            frmLoad.Show()
            Me.Close()
        End If
        picBomb1.Location = New Point(1500, 1500)


    End Sub

    Private Sub tmrExplosion1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrExplosion1.Tick



        intTimer2 += 1
        If intTimer2 = 1 Then
            picBomb1.Location = New Point(1500, 1500)
            picBomb1.Visible = True
            picExplode1.Bounds = picBomb1.Bounds
            picExplodeUp.Bounds = picBomb1.Bounds
            picExplodeDown.Bounds = picBomb1.Bounds
            picExplodeLeft.Bounds = picBomb1.Bounds
            picExplodeRight.Bounds = picBomb1.Bounds
            picExplodeUp2.Bounds = picBomb1.Bounds
            picExplodeDown2.Bounds = picBomb1.Bounds
            picExplodeLeft2.Bounds = picBomb1.Bounds
            picExplodeRight2.Bounds = picBomb1.Bounds
            picExplodeUp3.Bounds = picBomb1.Bounds
            picExplodeDown3.Bounds = picBomb1.Bounds
            picExplodeLeft3.Bounds = picBomb1.Bounds
            picExplodeRight3.Bounds = picBomb1.Bounds

            intTimer2 = 0
            tmrExplosion1.Enabled = False
        End If
    End Sub

    Private Sub picBomberman2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBomberman2.Click

    End Sub

    Private Sub tmrBomb2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBomb2.Tick

        intTimer3 += 1
        If intTimer3 = 1 Then
            tmrExplosion2.Enabled = True
            intTimer3 = 0
            tmrBomb2.Enabled = False


            picExplode2.Bounds = picBomb2.Bounds
            picExplodeLeft4.Location = New Point((picExplode2.Location.X - 21), picExplode2.Location.Y)
            picExplodeRight4.Location = New Point((picExplode2.Location.X + 21), picExplode2.Location.Y)
            picExplodeUp4.Location = New Point((picExplode2.Location.X), picExplode2.Location.Y - 28)
            picExplodeDown4.Location = New Point((picExplode2.Location.X), picExplode2.Location.Y + 28)
            If picExplodeLeft4.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeLeft4.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeLeft4.Bounds.IntersectsWith(picFrameLeft.Bounds) Then
                picExplodeLeft4.Location = New Point(1000, 1000)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft4.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
            If picExplodeRight4.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeRight4.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeRight4.Bounds.IntersectsWith(picFrameRight.Bounds) Then
                picExplodeRight4.Location = New Point(1000, 1000)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeRight4.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
        End If
        If picExplodeUp4.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeUp4.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeUp4.Bounds.IntersectsWith(picFrameTop.Bounds) Then
            picExplodeUp4.Location = New Point(1000, 1000)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeUp4.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If
        If picExplodeDown4.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeDown4.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeDown4.Bounds.IntersectsWith(picFrameBottom.Bounds) Then
            picExplodeDown4.Location = New Point(1000, 1000)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeDown4.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If

        If intFire2 >= 1 Then
            picExplodeLeft5.Location = New Point((picExplodeLeft4.Location.X - 21), picExplodeLeft4.Location.Y)
            picExplodeRight5.Location = New Point((picExplodeRight4.Location.X + 21), picExplodeRight4.Location.Y)
            picExplodeUp5.Location = New Point((picExplodeUp4.Location.X), picExplodeUp4.Location.Y - 28)
            picExplodeDown5.Location = New Point((picExplodeDown4.Location.X), picExplodeDown4.Location.Y + 28)
            If picExplodeLeft5.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeLeft5.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeLeft5.Bounds.IntersectsWith(picFrameLeft.Bounds) Then
                picExplodeLeft5.Location = New Point(1000, 1000)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft5.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
            If picExplodeRight5.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeRight5.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeRight5.Bounds.IntersectsWith(picFrameRight.Bounds) Then
                picExplodeRight5.Location = New Point(1000, 1000)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeRight5.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
        End If
        If picExplodeUp5.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeUp5.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeUp5.Bounds.IntersectsWith(picFrameTop.Bounds) Then
            picExplodeUp5.Location = New Point(1000, 1000)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeUp5.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If
        If picExplodeDown5.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeDown5.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeDown5.Bounds.IntersectsWith(picFrameBottom.Bounds) Then
            picExplodeDown5.Location = New Point(1000, 1000)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeDown5.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If

        If intFire1 >= 2 Then
            picExplodeLeft6.Location = New Point((picExplodeLeft5.Location.X - 21), picExplodeLeft5.Location.Y)
            picExplodeRight6.Location = New Point((picExplodeRight5.Location.X + 21), picExplodeRight5.Location.Y)
            picExplodeUp6.Location = New Point((picExplodeUp5.Location.X), picExplodeUp5.Location.Y - 28)
            picExplodeDown6.Location = New Point((picExplodeDown5.Location.X), picExplodeDown5.Location.Y + 28)
            If picExplodeLeft6.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeLeft.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeLeft6.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeLeft6.Bounds.IntersectsWith(picFrameLeft.Bounds) Then
                picExplodeLeft6.Location = New Point(1000, 1000)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeLeft6.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
            If picExplodeRight6.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeRight6.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeRight6.Bounds.IntersectsWith(picFrameRight.Bounds) Then
                picExplodeRight6.Location = New Point(1000, 1000)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick1.Bounds) Then
                picBrick1.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick2.Bounds) Then
                picBrick2.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick3.Bounds) Then
                picBrick3.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick4.Bounds) Then
                picBrick4.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick5.Bounds) Then
                picBrick5.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick6.Bounds) Then
                picBrick6.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick7.Bounds) Then
                picBrick7.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick8.Bounds) Then
                picBrick8.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick9.Bounds) Then
                picBrick9.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick10.Bounds) Then
                picBrick10.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick11.Bounds) Then
                picBrick11.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick12.Bounds) Then
                picBrick12.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick13.Bounds) Then
                picBrick13.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick14.Bounds) Then
                picBrick14.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick15.Bounds) Then
                picBrick15.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick16.Bounds) Then
                picBrick16.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick17.Bounds) Then
                picBrick17.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick18.Bounds) Then
                picBrick18.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick19.Bounds) Then
                picBrick19.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick20.Bounds) Then
                picBrick20.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick21.Bounds) Then
                picBrick21.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick22.Bounds) Then
                picBrick22.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick23.Bounds) Then
                picBrick23.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick24.Bounds) Then
                picBrick24.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick25.Bounds) Then
                picBrick25.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick26.Bounds) Then
                picBrick26.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick27.Bounds) Then
                picBrick27.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick28.Bounds) Then
                picBrick28.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick29.Bounds) Then
                picBrick29.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick30.Bounds) Then
                picBrick30.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick31.Bounds) Then
                picBrick31.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick32.Bounds) Then
                picBrick32.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick33.Bounds) Then
                picBrick33.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick34.Bounds) Then
                picBrick34.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick35.Bounds) Then
                picBrick35.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick36.Bounds) Then
                picBrick36.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick37.Bounds) Then
                picBrick37.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick38.Bounds) Then
                picBrick38.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick39.Bounds) Then
                picBrick39.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick40.Bounds) Then
                picBrick40.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick41.Bounds) Then
                picBrick41.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick42.Bounds) Then
                picBrick42.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick43.Bounds) Then
                picBrick43.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick44.Bounds) Then
                picBrick44.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick45.Bounds) Then
                picBrick45.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick46.Bounds) Then
                picBrick46.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick47.Bounds) Then
                picBrick47.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick48.Bounds) Then
                picBrick48.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick49.Bounds) Then
                picBrick49.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick50.Bounds) Then
                picBrick50.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick51.Bounds) Then
                picBrick51.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick52.Bounds) Then
                picBrick52.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick53.Bounds) Then
                picBrick53.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick54.Bounds) Then
                picBrick54.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick55.Bounds) Then
                picBrick55.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick56.Bounds) Then
                picBrick56.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick57.Bounds) Then
                picBrick57.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick58.Bounds) Then
                picBrick58.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick59.Bounds) Then
                picBrick59.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick60.Bounds) Then
                picBrick60.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick61.Bounds) Then
                picBrick61.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick62.Bounds) Then
                picBrick62.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick63.Bounds) Then
                picBrick63.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick64.Bounds) Then
                picBrick64.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick65.Bounds) Then
                picBrick65.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick66.Bounds) Then
                picBrick66.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick67.Bounds) Then
                picBrick67.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick68.Bounds) Then
                picBrick68.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick69.Bounds) Then
                picBrick69.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick70.Bounds) Then
                picBrick70.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick71.Bounds) Then
                picBrick71.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick72.Bounds) Then
                picBrick72.Location = New Point(1500, 1500)
            ElseIf picExplodeRight6.Bounds.IntersectsWith(picBrick73.Bounds) Then
                picBrick73.Location = New Point(1500, 1500)
            End If
        End If
        If picExplodeUp6.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeUp6.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeUp6.Bounds.IntersectsWith(picFrameTop.Bounds) Then
            picExplodeUp6.Location = New Point(1000, 1000)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeUp6.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If
        If picExplodeDown6.Bounds.IntersectsWith(picFrameTop.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal2.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal3.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal4.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal5.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal6.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal7.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal8.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal9.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal10.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal11.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal12.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal13.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal14.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal15.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal16.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal17.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal18.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal19.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal20.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal21.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal22.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal23.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal24.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal25.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal26.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal27.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal28.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal29.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal30.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal31.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal32.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal33.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal34.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal35.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal36.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal37.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal38.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal39.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal40.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal41.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal42.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal43.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal44.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal45.Bounds) Or _
picExplodeDown6.Bounds.IntersectsWith(picMetal46.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal47.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picMetal48.Bounds) Or picExplodeDown6.Bounds.IntersectsWith(picFrameBottom.Bounds) Then
            picExplodeDown6.Location = New Point(1000, 1000)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick1.Bounds) Then
            picBrick1.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick2.Bounds) Then
            picBrick2.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick3.Bounds) Then
            picBrick3.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick4.Bounds) Then
            picBrick4.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick5.Bounds) Then
            picBrick5.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick6.Bounds) Then
            picBrick6.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick7.Bounds) Then
            picBrick7.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick8.Bounds) Then
            picBrick8.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick9.Bounds) Then
            picBrick9.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick10.Bounds) Then
            picBrick10.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick11.Bounds) Then
            picBrick11.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick12.Bounds) Then
            picBrick12.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick13.Bounds) Then
            picBrick13.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick14.Bounds) Then
            picBrick14.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick15.Bounds) Then
            picBrick15.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick16.Bounds) Then
            picBrick16.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick17.Bounds) Then
            picBrick17.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick18.Bounds) Then
            picBrick18.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick19.Bounds) Then
            picBrick19.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick20.Bounds) Then
            picBrick20.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick21.Bounds) Then
            picBrick21.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick22.Bounds) Then
            picBrick22.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick23.Bounds) Then
            picBrick23.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick24.Bounds) Then
            picBrick24.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick25.Bounds) Then
            picBrick25.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick26.Bounds) Then
            picBrick26.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick27.Bounds) Then
            picBrick27.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick28.Bounds) Then
            picBrick28.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick29.Bounds) Then
            picBrick29.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick30.Bounds) Then
            picBrick30.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick31.Bounds) Then
            picBrick31.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick32.Bounds) Then
            picBrick32.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick33.Bounds) Then
            picBrick33.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick34.Bounds) Then
            picBrick34.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick35.Bounds) Then
            picBrick35.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick36.Bounds) Then
            picBrick36.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick37.Bounds) Then
            picBrick37.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick38.Bounds) Then
            picBrick38.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick39.Bounds) Then
            picBrick39.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick40.Bounds) Then
            picBrick40.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick41.Bounds) Then
            picBrick41.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick42.Bounds) Then
            picBrick42.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick43.Bounds) Then
            picBrick43.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick44.Bounds) Then
            picBrick44.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick45.Bounds) Then
            picBrick45.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick46.Bounds) Then
            picBrick46.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick47.Bounds) Then
            picBrick47.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick48.Bounds) Then
            picBrick48.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick49.Bounds) Then
            picBrick49.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick50.Bounds) Then
            picBrick50.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick51.Bounds) Then
            picBrick51.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick52.Bounds) Then
            picBrick52.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick53.Bounds) Then
            picBrick53.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick54.Bounds) Then
            picBrick54.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick55.Bounds) Then
            picBrick55.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick56.Bounds) Then
            picBrick56.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick57.Bounds) Then
            picBrick57.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick58.Bounds) Then
            picBrick58.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick59.Bounds) Then
            picBrick59.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick60.Bounds) Then
            picBrick60.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick61.Bounds) Then
            picBrick61.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick62.Bounds) Then
            picBrick62.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick63.Bounds) Then
            picBrick63.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick64.Bounds) Then
            picBrick64.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick65.Bounds) Then
            picBrick65.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick66.Bounds) Then
            picBrick66.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick67.Bounds) Then
            picBrick67.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick68.Bounds) Then
            picBrick68.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick69.Bounds) Then
            picBrick69.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick70.Bounds) Then
            picBrick70.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick71.Bounds) Then
            picBrick71.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick72.Bounds) Then
            picBrick72.Location = New Point(1500, 1500)
        ElseIf picExplodeDown6.Bounds.IntersectsWith(picBrick73.Bounds) Then
            picBrick73.Location = New Point(1500, 1500)
        End If
        If picBomberman1.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
    picBomberman1.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
    picBomberman1.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
    picBomberman1.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
    picBomberman1.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
    picBomberman1.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
    picBomberman1.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
    picBomberman1.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman1.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
            intScore1(intRound) = 0
            intScore2(intRound) = 1
            MessageBox.Show("Player 2 wins!")
            frmLoad.Show()
            Me.Close()
        End If
        If picBomberman2.Bounds.IntersectsWith(picExplode1.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplode2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeDown5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeDown6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeUp5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeUp6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeLeft5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeLeft6.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight2.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight3.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight4.Bounds) Or _
picBomberman2.Bounds.IntersectsWith(picExplodeRight5.Bounds) Or picBomberman2.Bounds.IntersectsWith(picExplodeRight6.Bounds) Then
            intScore1(intRound) = 1
            intScore2(intRound) = 0
            MessageBox.Show("Player 1 wins!")
            frmLoad.Show()
            Me.Close()
        End If
        picBomb2.Visible = False
    End Sub

    Private Sub tmrExplosion2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrExplosion2.Tick
        intTimer4 += 1
        If intTimer4 = 1 Then
            picBomb2.Location = New Point(1500, 1500)
            picBomb2.Visible = True
            picExplode2.Bounds = picBomb2.Bounds
            picExplodeUp4.Bounds = picBomb2.Bounds
            picExplodeDown4.Bounds = picBomb2.Bounds
            picExplodeLeft4.Bounds = picBomb2.Bounds
            picExplodeRight4.Bounds = picBomb2.Bounds
            picExplodeUp5.Bounds = picBomb2.Bounds
            picExplodeDown5.Bounds = picBomb2.Bounds
            picExplodeLeft5.Bounds = picBomb2.Bounds
            picExplodeRight5.Bounds = picBomb2.Bounds
            picExplodeUp6.Bounds = picBomb2.Bounds
            picExplodeDown6.Bounds = picBomb2.Bounds
            picExplodeLeft6.Bounds = picBomb2.Bounds
            picExplodeRight6.Bounds = picBomb2.Bounds

            intTimer4 = 0
            tmrExplosion2.Enabled = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

Public Class frmSims

    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click
        'Declarations
        Dim intTrials As Integer = 0
        Dim rand As New Random
        Dim dblNum As Double

        Dim dblWinPercentage2 As Double
        Dim dblWinPercentage3 As Double
        'See Win Percentage
        If radAbzan.Checked Then
            dblWinPercentage2 = 54.48
        ElseIf radAffinity.Checked Then
            dblWinPercentage2 = 48.2
        ElseIf radBurn.Checked Then
            dblWinPercentage2 = 49.2
        ElseIf radDevoted.Checked Then
            dblWinPercentage2 = 44.89
        ElseIf radDredge.Checked Then
            dblWinPercentage2 = 44.23
        ElseIf radEldrazi.Checked Then
            dblWinPercentage2 = 50.47
        ElseIf radFiveColor.Checked Then
            dblWinPercentage2 = 51.73
        ElseIf radGreenTron.Checked Then
            dblWinPercentage2 = 50.73
        ElseIf radGrixis.Checked Then
            dblWinPercentage2 = 62.0
        ElseIf radJeskai.Checked Then
            dblWinPercentage2 = 47.54
        ElseIf radStorm.Checked Then
            dblWinPercentage2 = 45.54
        ElseIf radTitanShift.Checked Then
            dblWinPercentage2 = 43.28
        ElseIf radTraverse.Checked Then
            dblWinPercentage2 = 58.72
        ElseIf radMardu.Checked Then
            dblWinPercentage2 = 53.7
        ElseIf radWU.Checked Then
            dblWinPercentage2 = 48.51
        ElseIf radAbzan2.Checked Then
            dblWinPercentage3 = 54.48
        ElseIf radAffinity2.Checked Then
            dblWinPercentage3 = 48.2
        ElseIf radBurn2.Checked Then
            dblWinPercentage3 = 49.2
        ElseIf radDevoted2.Checked Then
            dblWinPercentage3 = 44.89
        ElseIf radDredge2.Checked Then
            dblWinPercentage3 = 44.23
        ElseIf radEldrazi2.Checked Then
            dblWinPercentage3 = 50.47
        ElseIf radFiveColor2.Checked Then
            dblWinPercentage3 = 51.73
        ElseIf radGreen2.Checked Then
            dblWinPercentage3 = 50.73
        ElseIf radGrixis2.Checked Then
            dblWinPercentage3 = 62.0
        ElseIf radJeskai2.Checked Then
            dblWinPercentage3 = 47.54
        ElseIf radStorm2.Checked Then
            dblWinPercentage3 = 45.54
        ElseIf radTitan2.Checked Then
            dblWinPercentage3 = 43.28
        ElseIf radTraverse2.Checked Then
            dblWinPercentage3 = 58.72
        ElseIf radMardu2.Checked Then
            dblWinPercentage3 = 53.7
        ElseIf radWU2.Checked Then
            dblWinPercentage3 = 48.51
            If ((radOther.Checked Or radOther2.Checked) And (frmEnterDeck.dblWinPercent = -1)) Then
                MsgBox("You never entered a deck, so there is no win percentage for this option!", MsgBoxStyle.Exclamation)
            ElseIf radOther.Checked Then
                dblWinPercentage2 = frmEnterDeck.dblWinPercent
            ElseIf radOther2.Checked Then
                dblWinPercentage3 = frmEnterDeck.dblWinPercent
            End If
        End If
        'Execute number of inputed simulations and also catch for invalid input
        Try
            Do While intTrials <> CInt(txtGames.Text)
                dblNum = (rand.Next(99) + rand.NextDouble())
                If (dblNum <= dblWinPercentage2) Then
                    lblWin.Text = (Val(lblWin.Text) + 1).ToString
                End If
                If (dblNum >= dblWinPercentage2) Then
                    lblLoss.Text = (Val(lblLoss.Text) + 1).ToString
                End If
                If (dblWinPercentage2 = dblWinPercentage3) Then
                    dblNum = rand.Next(9)
                    If dblNum >= 5 Then
                        lblWin.Text = (Val(lblWin.Text) + 1).ToString
                    End If
                    If dblNum <= 5 Then
                        lblLoss.Text = (Val(lblLoss.Text) + 1).ToString
                    End If
                End If
                intTrials += 1
            Loop
        Catch ex As Exception
            MsgBox("This is not a number. Please enter a valid number.", MsgBoxStyle.Exclamation)
            txtGames.Focus()
        End Try

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblLoss.Text = ((Val(lblLoss.Text)) - (Val(lblLoss.Text))).ToString
        lblWin.Text = ((Val(lblWin.Text)) - (Val(lblWin.Text))).ToString

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
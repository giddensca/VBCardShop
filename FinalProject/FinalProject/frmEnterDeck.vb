Public Class frmEnterDeck
    Public dblPrice As Double
    Public dblWinPercent As Double = -1
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Check errors in user input
        If Double.TryParse(txtPrice.Text, dblPrice) Then
            dblPrice = txtPrice.Text
        Else
            MsgBox("You must enter a valid price!", MsgBoxStyle.Exclamation)
            txtPrice.Focus()
        End If
        If Double.TryParse(txtWinPercentage.Text, dblWinPercent) Then
            If (txtWinPercentage.Text >= 0 And txtWinPercentage.Text <= 100) Then
                dblWinPercent = txtWinPercentage.Text
            Else
                MsgBox("You must enter a number between 0 and 100", MsgBoxStyle.Exclamation)
                txtWinPercentage.Focus()
            End If
        Else
            MsgBox("You must enter a number for Win %", MsgBoxStyle.Exclamation)
            txtWinPercentage.Focus()
        End If

        If (txtDeckName.Text = String.Empty) Then
            MsgBox("You must enter a name for the deck!", MsgBoxStyle.Exclamation)
            txtDeckName.Focus()
        End If
        If (txtDeckName.Text <> String.Empty And IsNumeric(txtPrice.Text) And (IsNumeric(txtWinPercentage.Text) And (dblWinPercent >= 0 And dblWinPercent <= 100))) Then
            updateCart(txtDeckName.Text)
            MsgBox("Your deck was added!", MsgBoxStyle.Information)
        End If
        frmMain.btnCheckout.Enabled = True


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmEnterDeck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class frmDeckBuying

    Private Sub btnAddTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTo.Click
        'See selections made
        If (chkAbzan.Checked Or chkAffinity.Checked Or chkBurn.Checked Or chkDevoted.Checked Or chkDredge.Checked Or chkElTron.Checked Or chkFiveColor.Checked Or chkGrixis.Checked Or chkGTron.Checked Or chkJeskai.Checked Or
            chkMardu.Checked Or chkStorm.Checked Or chkTitan.Checked Or chkTraverse.Checked Or chkWU.Checked) Then
            If chkAbzan.Checked Then
                updateCart("Abzan")
            End If
            If chkAffinity.Checked Then
                updateCart("Affinity")
            End If
            If chkDevoted.Checked Then
                updateCart("Devoted Company")
            End If
            If chkDredge.Checked Then
                updateCart("Dredge")
            End If
            If chkElTron.Checked Then
                updateCart("Eldrazi Tron")
            End If
            If chkFiveColor.Checked Then
                updateCart("Five-Color Humans")
            End If
            If chkGTron.Checked Then
                updateCart("Green Tron")
            End If
            If chkGrixis.Checked Then
                updateCart("Grixis Control")
            End If
            If chkJeskai.Checked Then
                updateCart("Jeskai Control")
            End If
            If chkStorm.Checked Then
                updateCart("Storm")
            End If
            If chkTitan.Checked Then
                updateCart("Titan Shift")
            End If
            If chkTraverse.Checked Then
                updateCart("Traverse Shadow")
            End If
            If chkMardu.Checked Then
                updateCart("Mardu Pyromancer")
            End If
            If chkWU.Checked Then
                updateCart("White/Blue Control")
            End If
            If chkBurn.Checked Then
                updateCart("Burn")
            End If
            MsgBox("Items were added to your cart!", MsgBoxStyle.Information)
        Else
            MsgBox("Nothing was selected. Please select something or click Exit", MsgBoxStyle.Exclamation)
        End If
        frmMain.btnCheckout.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDeck.Click
        frmEnterDeck.ShowDialog()
    End Sub
End Class
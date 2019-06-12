Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtLUsername.Text = My.Settings.Username And
            txtLPassword.Text = My.Settings.Password Then
            frmMain.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub lnkCreate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCreate.LinkClicked
        frmCreate.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

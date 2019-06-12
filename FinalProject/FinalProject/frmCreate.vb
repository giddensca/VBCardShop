Public Class frmCreate

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        'Create username and password
        My.Settings.Username = txtCUsername.Text
        My.Settings.Password = txtCPassword.Text
        My.Settings.Save()
        MsgBox("Account Created!", MsgBoxStyle.Information, "Create")
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmCreate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
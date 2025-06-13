Public Class formSignup
    Private Sub txtEmailUser_TextChanged(sender As Object, e As EventArgs) Handles txtEmailUser.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmailUser.Text = "Email"
        txtEmailUser.ForeColor = Color.Gray
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.Gray
        txtUser.Text = "Username"
        txtUser.ForeColor = Color.Gray
    End Sub

    Private Sub txtEmailUser_Enter(sender As Object, e As EventArgs) Handles txtEmailUser.Enter
        If txtEmailUser.Text = "Email" Then
            txtEmailUser.Text = ""
            txtEmailUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmailUser_Leave(sender As Object, e As EventArgs) Handles txtEmailUser.Leave
        If txtEmailUser.Text = "" Then
            txtEmailUser.Text = "Email"
            txtEmailUser.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUser_Enter(sender As Object, e As EventArgs) Handles txtUser.Enter
        If txtUser.Text = "Username" Then
            txtUser.Text = ""
            txtUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUser_Leave(sender As Object, e As EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then
            txtUser.Text = "Username"
            txtUser.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        Me.Hide()
        formLogin.Show()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

    End Sub
End Class
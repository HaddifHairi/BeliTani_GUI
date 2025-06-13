Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formLogin

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.AutoSize = True
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink

        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink

        ' optional: remove scrollbars/margins if used
        Me.Padding = New Padding(0)

        Panel1.Padding = New Padding(0, 0, 0, 30)



        Me.StartPosition = FormStartPosition.CenterScreen

        txtEmailUser.Text = "Email / Username"
        txtEmailUser.ForeColor = Color.Gray
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.Gray

    End Sub

    Private Sub txtEmailUser_TextChanged(sender As Object, e As EventArgs) Handles txtEmailUser.TextChanged

    End Sub

    Private Sub txtEmailUser_Enter(sender As Object, e As EventArgs) Handles txtEmailUser.Enter
        If txtEmailUser.Text = "Email / Username" Then
            txtEmailUser.Text = ""
            txtEmailUser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmailUser_Leave(sender As Object, e As EventArgs) Handles txtEmailUser.Leave
        If txtEmailUser.Text = "" Then
            txtEmailUser.Text = "Email / Username"
            txtEmailUser.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Hide()
        formSignup.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

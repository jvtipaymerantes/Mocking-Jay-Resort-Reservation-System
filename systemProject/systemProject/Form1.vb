Public Class frmLogin


    Private Sub txtboxUsername_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtboxUsername.MouseClick

        RectangleShape1.BorderColor = Color.DodgerBlue

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Hide()
        End If

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Visible = True
        End If

        RectangleShape3.BorderColor = Color.FromArgb(240, 240, 240)

    End Sub

    Private Sub txtboxPassword_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtboxPassword.MouseClick

        RectangleShape3.BorderColor = Color.DodgerBlue

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Hide()
        End If

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Visible = True
        End If

        RectangleShape1.BorderColor = Color.FromArgb(240, 240, 240)

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick

        RectangleShape1.BorderColor = Color.FromArgb(240, 240, 240)
        RectangleShape3.BorderColor = Color.FromArgb(240, 240, 240)

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Visible = True
        End If

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Visible = True
        End If

    End Sub


    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.FromArgb(49, 170, 82)
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.FromArgb(49, 170, 82)
        Button2.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAdmin.Show()
        Me.Close()

    End Sub
End Class

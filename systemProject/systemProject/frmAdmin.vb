Public Class frmAdmin
    Dim widthSize As Integer

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized



    End Sub


    Private Sub Panel8_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel8_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelView.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub Panel8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelView.MouseLeave
        panelView.BackColor = Color.White
    End Sub

    Private Sub Label4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelReserve_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelReserve.MouseHover
        panelReserve.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelReserve_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelReserve.MouseLeave
        panelReserve.BackColor = Color.White
    End Sub

    Private Sub Label5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseHover
        panelReserve.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        panelReserve.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelMap_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelMap.MouseHover
        panelMap.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelMap_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelMap.MouseLeave
        panelMap.BackColor = Color.White
    End Sub

    Private Sub Label6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseHover
        panelMap.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseHover
        panelMap.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelLogout_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelLogout.MouseHover
        panelLogout.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelLogout_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelLogout.MouseLeave
        panelLogout.BackColor = Color.White
    End Sub

    Private Sub Label7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.MouseHover
        panelLogout.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        panelLogout.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim control As New ucAdminReservedRooms
        flpAdminReserved.Controls.Add(control)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frmAdminViewRooms.Show()
        Me.Close()
    End Sub

End Class
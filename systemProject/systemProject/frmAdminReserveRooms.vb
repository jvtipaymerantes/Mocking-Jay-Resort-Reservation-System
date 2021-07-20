Public Class frmAdminReserveRooms
    Dim widthSize As Integer

    Private Sub frmAdminReserveRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

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


    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles panelHome.MouseHover
        panelHome.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        panelHome.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        panelHome.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelHome_MouseLeave(sender As Object, e As EventArgs) Handles panelHome.MouseLeave
        panelHome.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = New frmAdminAddRoom()
        a.Show()
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmAdmin.Show()
        Me.Close()
    End Sub
End Class
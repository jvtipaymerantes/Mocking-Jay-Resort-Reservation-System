Imports System.IO
Imports System.Data.OleDb

Public Class frmAdminHistory
    Dim widthSize As Integer
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String

    Private Sub frmAdminHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim sql As String

        'Table flp
        Dim a As Integer
        Dim b As Integer

        a = Panel14.Height
        b = Panel14.Width

        a = a - 10
        b = b - 10

        RectangleShape1.Size = New Size(b, a)
        RectangleShape2.Size = New Size(b - 4, 54)

        Panel22.Size = New Size(b - 60, 1)
        Panel26.Size = New Size(18, a - 44)

        a = a - 50
        b = b - 20

        Panel18.Size = New Size(b, a)

        con.Open()

        'Flowlayout Panel / User Control
        sql = "select roomName, customerName, reservationDate from tblCustomer where status='Complete'"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()


        While (myreader.Read())

            Dim uc As New ucMainHistory
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtName.Text = myreader("customerName")
            uc.txtDate.Text = myreader("reservationDate")

            Me.flpAdminReserved.Controls.Add(uc)

        End While

        con.Close()

    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles panelHome.MouseHover
        panelHome.BackColor = Color.FromArgb(255, 242, 239)
        Label3.BackColor = Color.FromArgb(255, 242, 239)
        PictureBox2.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        panelHome.BackColor = Color.FromArgb(255, 242, 239)
        Label3.BackColor = Color.FromArgb(255, 242, 239)
        PictureBox2.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        panelHome.BackColor = Color.FromArgb(255, 242, 239)
        Label3.BackColor = Color.FromArgb(255, 242, 239)
        PictureBox2.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelHome_MouseLeave(sender As Object, e As EventArgs) Handles panelHome.MouseLeave
        panelHome.BackColor = Color.White
        Label3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frmAdminViewRooms.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmAdminViewRooms.Show()
        Me.Close()
    End Sub

    Private Sub panelView_Click(sender As Object, e As EventArgs) Handles panelView.Click
        frmAdminViewRooms.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmAdminReserveRooms.Show()
        Me.Close()
    End Sub

    Private Sub panelReserve_Click(sender As Object, e As EventArgs) Handles panelReserve.Click
        frmAdminReserveRooms.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmAdminReserveRooms.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        frmAdminMaps.Show()
        Me.Close()
    End Sub

    Private Sub panelMap_Click(sender As Object, e As EventArgs) Handles panelMap.Click
        frmAdminMaps.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmAdminMaps.Show()
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub panelHome_Click(sender As Object, e As EventArgs) Handles panelHome.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub panelLogout_MouseClick(sender As Object, e As MouseEventArgs) Handles panelLogout.MouseClick
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        flpAdminReserved.Controls.Clear()

        con.Open()

        sql = "select customerName, roomName, reservationDate from tblCustomer where customerName LIKE '" + txtSearch.Text + "%' AND status='Complete'"
        Dim cmdReader As New OleDbCommand(Sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucMainHistory

            uc.txtName.Text = myreader("customerName")
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDate.Text = myreader("reservationDate")
            

            Me.flpAdminReserved.Controls.Add(uc)

        End While

        con.Close()
    End Sub

   
    Private Sub txtSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseClick
        txtSearch.Text = ""
    End Sub
End Class
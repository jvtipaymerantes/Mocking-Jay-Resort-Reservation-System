Imports System.IO
Imports System.Data.OleDb

Public Class frmAdminViewRooms
    Dim widthSize As Integer
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String

    Public Sub reload()
        Me.WindowState = FormWindowState.Maximized

        Dim a As Integer
        Dim b As Integer

        a = Panel14.Height
        b = Panel14.Width

        RectangleShape3.Size = New Size(b - 10, a - 10)
        Panel17.Size = New Size(b - 26, a - 28)
        Panel18.Size = New Size(18, a - 14)



        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice, roomStatus from tblRooms"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucViewRoom

            uc.lblroomCode.Text = myreader("roomCode")
            uc.pbRoomImage.Tag = myreader("roomImage")
            uc.pbRoomImage.Image = Image.FromFile(uc.pbRoomImage.Tag)
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDescription.Text = myreader("roomDescription")
            uc.txtPrice.Text = myreader("roomPrice")
            uc.txtStatus.Text = myreader("roomStatus")

            Me.flpViewRooms.Controls.Add(uc)

        End While

        con.Close()
    End Sub

    Private Sub frmAdminViewRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim a As Integer
        Dim b As Integer

        a = Panel14.Height
        b = Panel14.Width

        RectangleShape3.Size = New Size(b - 10, a - 10)
        Panel17.Size = New Size(b - 26, a - 28)
        Panel18.Size = New Size(18, a - 14)



        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice, roomStatus from tblRooms"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucViewRoom

            uc.lblroomCode.Text = myreader("roomCode")
            uc.pbRoomImage.Tag = myreader("roomImage")
            uc.pbRoomImage.Image = Image.FromFile(uc.pbRoomImage.Tag)
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDescription.Text = myreader("roomDescription")
            uc.txtPrice.Text = myreader("roomPrice")
            uc.txtStatus.Text = myreader("roomStatus")

            Me.flpViewRooms.Controls.Add(uc)

        End While

        con.Close()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim a = New frmAdminAddRoom()
        a.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmAdminReserveRooms.Show()
        Me.Close()
    End Sub

    Private Sub panelHome_Click(sender As Object, e As EventArgs) Handles panelHome.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmAdmin.Show()
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

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        frmAdminAddRoom.Show()
    End Sub

    Private Sub Label10_MouseHover(sender As Object, e As EventArgs) Handles Label10.MouseHover
        RectangleShape1.BackColor = Color.FromArgb(40, 180, 99)
        Label10.BackColor = Color.FromArgb(40, 180, 99)
        PictureBox9.BackColor = Color.FromArgb(40, 180, 99)
    End Sub

    Private Sub PictureBox9_MouseHover(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover
        RectangleShape1.BackColor = Color.FromArgb(40, 180, 99)
        PictureBox9.BackColor = Color.FromArgb(40, 180, 99)
        Label10.BackColor = Color.FromArgb(40, 180, 99)
    End Sub

    Private Sub RectangleShape1_MouseHover(sender As Object, e As EventArgs) Handles RectangleShape1.MouseHover
        RectangleShape1.BackColor = Color.FromArgb(40, 180, 99)
        PictureBox9.BackColor = Color.FromArgb(40, 180, 99)
        Label10.BackColor = Color.FromArgb(40, 180, 99)
    End Sub

    Private Sub RectangleShape1_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape1.MouseLeave
        RectangleShape1.BackColor = Color.FromArgb(46, 204, 113)
        Label10.BackColor = Color.FromArgb(46, 204, 113)
        PictureBox9.BackColor = Color.FromArgb(46, 204, 113)
    End Sub

    Private Sub RectangleShape2_MouseHover(sender As Object, e As EventArgs) Handles RectangleShape2.MouseHover
        RectangleShape2.BackColor = Color.FromArgb(224, 224, 224)
        RectangleShape2.BorderColor = Color.FromArgb(224, 224, 224)
        Label11.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub RectangleShape2_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape2.MouseLeave
        RectangleShape2.BackColor = Color.Transparent
        RectangleShape2.BorderColor = Color.Transparent
        Label11.BackColor = Color.Transparent
    End Sub

    Private Sub Label11_MouseHover(sender As Object, e As EventArgs) Handles Label11.MouseHover
        RectangleShape2.BackColor = Color.FromArgb(224, 224, 224)
        Label11.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        RectangleShape2.BackColor = Color.FromArgb(224, 224, 224)
        Label11.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        frmAdminServices.Show()
    End Sub

    Private Sub txtSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseClick
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        txtSearch.Text = "Search Room"
        flpViewRooms.Controls.Clear()
        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice, roomStatus from tblRooms"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucViewRoom

            uc.lblroomCode.Text = myreader("roomCode")
            uc.pbRoomImage.Tag = myreader("roomImage")
            uc.pbRoomImage.Image = Image.FromFile(uc.pbRoomImage.Tag)
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDescription.Text = myreader("roomDescription")
            uc.txtPrice.Text = myreader("roomPrice")
            uc.txtStatus.Text = myreader("roomStatus")

            Me.flpViewRooms.Controls.Add(uc)

        End While

        con.Close()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter

        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice, roomStatus from tblRooms where roomName LIKE '" + txtSearch.Text + "%' "
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucViewRoom

            uc.lblroomCode.Text = myreader("roomCode")
            uc.pbRoomImage.Tag = myreader("roomImage")
            uc.pbRoomImage.Image = Image.FromFile(uc.pbRoomImage.Tag)
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDescription.Text = myreader("roomDescription")
            uc.txtPrice.Text = myreader("roomPrice")
            uc.txtStatus.Text = myreader("roomStatus")

            Me.flpViewRooms.Controls.Add(uc)

        End While

        con.Close()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        flpViewRooms.Controls.Clear()

        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice, roomStatus from tblRooms where roomName LIKE '" + txtSearch.Text + "%' "
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucViewRoom

            uc.lblroomCode.Text = myreader("roomCode")
            uc.pbRoomImage.Tag = myreader("roomImage")
            uc.pbRoomImage.Image = Image.FromFile(uc.pbRoomImage.Tag)
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDescription.Text = myreader("roomDescription")
            uc.txtPrice.Text = myreader("roomPrice")
            uc.txtStatus.Text = myreader("roomStatus")

            Me.flpViewRooms.Controls.Add(uc)

        End While

        con.Close()
    End Sub

    Private Sub Panel27_MouseHover(sender As Object, e As EventArgs) Handles panelHistory.MouseHover
        panelHistory.BackColor = Color.FromArgb(255, 242, 239)
        Label18.BackColor = Color.FromArgb(255, 242, 239)
        PictureBox12.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelHistory_MouseLeave(sender As Object, e As EventArgs) Handles panelHistory.MouseLeave
        panelHistory.BackColor = Color.White
        Label18.BackColor = Color.White
        PictureBox12.BackColor = Color.White
    End Sub

    Private Sub Label18_MouseHover(sender As Object, e As EventArgs) Handles Label18.MouseHover
        panelHistory.BackColor = Color.FromArgb(255, 242, 239)
        Label18.BackColor = Color.FromArgb(255, 242, 239)
        PictureBox12.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox12_MouseHover(sender As Object, e As EventArgs) Handles PictureBox12.MouseHover
        panelHistory.BackColor = Color.FromArgb(255, 242, 239)
        Label18.BackColor = Color.FromArgb(255, 242, 239)
        PictureBox12.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        frmAdminHistory.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        frmAdminHistory.Show()
        Me.Close()
    End Sub

    Private Sub panelHistory_Click(sender As Object, e As EventArgs) Handles panelHistory.Click
        frmAdminHistory.Show()
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


End Class
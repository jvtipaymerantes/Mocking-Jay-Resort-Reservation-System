Imports System.IO
Imports System.Data.OleDb

Public Class frmAdminReserveRooms
    Dim widthSize As Integer
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")

    Private Sub frmAdminReserveRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        Dim a As Integer
        Dim b As Integer

        a = Panel14.Height
        b = Panel14.Width

        RectangleShape3.Size = New Size(b - 20, a - 20)
        Panel17.Size = New Size(b - 40, a - 40)
        Panel18.Size = New Size(18, a - 30)

        Dim sql As String
        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice from tblRooms where roomStatus='Vaccant' "
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucReserveRoom

            uc.lblroomCode.Text = myreader("roomCode")
            uc.pbRoomImage.Tag = myreader("roomImage")
            uc.pbRoomImage.Image = Image.FromFile(uc.pbRoomImage.Tag)
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDescription.Text = myreader("roomDescription")
            uc.txtPrice.Text = myreader("roomPrice")

            Me.flpReserveRooms.Controls.Add(uc)


        End While

        con.Close()

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

    Private Sub panelView_MouseHover(sender As Object, e As EventArgs) Handles panelView.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelView_MouseLeave(sender As Object, e As EventArgs) Handles panelView.MouseLeave
        panelView.BackColor = Color.White
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub panelHome_Click(sender As Object, e As EventArgs) Handles panelHome.Click
        frmAdmin.Show()
        Me.Close()
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        frmAdminMaps.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frmAdminMaps.Show()
        Me.Close()
    End Sub

    Private Sub panelMap_Click(sender As Object, e As EventArgs) Handles panelMap.Click
        frmAdminMaps.Show()
        Me.Close()
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
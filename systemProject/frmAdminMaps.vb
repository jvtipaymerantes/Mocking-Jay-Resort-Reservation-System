Imports System.IO
Imports System.Data.OleDb

Public Class frmAdminMaps
    Dim widthSize As Integer
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As New Integer

    Private Sub frmAdminMaps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        con.Open()

        sql = "select * from tblMaps where ID = (select max(ID) from tblMaps)"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        myreader.Read()
        pbMap.Tag = myreader("mapImage")
        pbMap.Image = Image.FromFile(pbMap.Tag)

        con.Close()


    End Sub

    Private Sub panelView_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelView.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelView_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelView.MouseLeave
        panelView.BackColor = Color.White
    End Sub

    Private Sub panelReserve_MouseHover(sender As Object, e As EventArgs) Handles panelReserve.MouseHover
        panelReserve.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub panelReserve_MouseLeave(sender As Object, e As EventArgs) Handles panelReserve.MouseLeave
        panelReserve.BackColor = Color.White
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        panelView.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub Label5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.MouseHover
        panelReserve.BackColor = Color.FromArgb(255, 242, 239)
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseHover
        panelReserve.BackColor = Color.FromArgb(255, 242, 239)
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        frmAdminViewRooms.Show()
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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmAdminReserveRooms.Show()
        Me.Close()
    End Sub

    Private Sub panelReserve_Click(sender As Object, e As EventArgs) Handles panelReserve.Click
        frmAdminReserveRooms.Show()
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

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        Using img As OpenFileDialog = New OpenFileDialog()

            img.Filter = " choose image(*.jpg;* .png;* .jpeg)|*.jpg;* .png;* .jpeg"

            If img.ShowDialog() = DialogResult.OK Then

                pbMap.Image = Image.FromFile(img.FileName)
                pbMap.Tag = img.FileName
                pbMap.Image = Image.FromFile(pbMap.Tag)

                con.Open()

                Dim fileName As String = "images/" + CStr(Date.Now().Ticks) + ".jpeg"
                'To Create Random Filename
                File.Copy(pbMap.Tag, fileName)
                'Copied Image

                sql = "INSERT INTO tblMaps (mapImage) values ('" & fileName & "') "
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    con.Close()

                    Dim a As New frmAdminMaps
                    a.Show()

                    MsgBox("Map Successful!")

                    Me.Close()

                Else
                    MsgBox("Error!")
                End If

                con.Close()

            End If

        End Using

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
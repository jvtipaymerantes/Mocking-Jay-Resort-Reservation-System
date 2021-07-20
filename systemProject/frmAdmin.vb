Imports System.IO
Imports System.Data.OleDb

Public Class frmAdmin
    Dim widthSize As Integer
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim sql As String
        Dim sqlTwo As String

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

        'For Vaccant
        Dim strsql As String
        strsql = "Select Count(*) from tblRooms where roomStatus='Vaccant'"
        Dim cmd As New OleDbCommand(strsql, con)

        Dim vaccantCount As Int32 = 0
        vaccantCount = Convert.ToInt32(cmd.ExecuteScalar())
        lblVaccant.Text = vaccantCount.ToString

        'For Occupied
        strsql = "Select Count(*) from tblRooms where roomStatus='Occupied'"
        Dim cmdTwo As New OleDbCommand(strsql, con)

        Dim occupiedCount As Int32 = 0
        occupiedCount = Convert.ToInt32(cmdTwo.ExecuteScalar())
        lblOccupied.Text = occupiedCount.ToString

        'For Downpayment
        strsql = "Select Count(*) from tblCustomer where modeOfPayment='Downpayment'"
        Dim cmdThree As New OleDbCommand(strsql, con)

        Dim downPaymentCount As Int32 = 0
        downPaymentCount = Convert.ToInt32(cmdThree.ExecuteScalar())
        lblDownpayment.Text = downPaymentCount.ToString


        'Flowlayout Panel / User Control
        sql = "select roomName, customerName, modeOfPayment, status from tblCustomer where status='Waiting' Or status='Waiting For Arrival'"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()


        While (myreader.Read())

            Dim uc As New ucMainCustomer
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtName.Text = myreader("customerName")
            uc.txtMode.Text = myreader("modeOfPayment")
            uc.txtStatus.Text = myreader("status")

            Me.flpAdminReserved.Controls.Add(uc)

            sqlTwo = "select roomCode from tblRooms where roomName='" + uc.txtRoomName.Text + "' "
            Dim cmdReaderTwo As New OleDbCommand(sqlTwo, con)
            Dim myreaderTwo As OleDbDataReader
            myreaderTwo = cmdReaderTwo.ExecuteReader()
            myreaderTwo.Read()
            uc.Label1.Text = myreaderTwo("roomCode")

        End While

        con.Close()

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


    Private Sub panelHistory_Click(sender As Object, e As EventArgs) Handles panelHistory.Click
        frmAdminHistory.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        frmAdminHistory.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub panelLogout_Click(sender As Object, e As EventArgs) Handles panelLogout.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
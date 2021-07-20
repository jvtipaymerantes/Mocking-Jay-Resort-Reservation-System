Imports System.IO
Imports System.Data.OleDb
Imports System.Text

Public Class frmCustomerReserve

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Public reserveRoomCodeTwo As String
    Dim total As New Integer
    Public customerService As String
    Public customerServicePrice As Integer

    Public condition As Boolean


    Private Sub frmCustomerReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmShadowBg.Show()

        txtRoomName.ReadOnly = True
        txtRoomName.BackColor = Color.White
        txtPrice.ReadOnly = True
        txtPrice.BackColor = Color.White
        txtDescription.ReadOnly = True
        txtDescription.BackColor = Color.White

        lblCode.Text = reserveRoomCodeTwo

        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice from tblRooms where roomCode='" + reserveRoomCodeTwo + "' "
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        myreader.Read()


        pbRoomImage.Tag = myreader("roomImage")
        pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
        txtRoomName.Text = myreader("roomName")
        txtDescription.Text = myreader("roomDescription")
        txtPrice.Text = myreader("roomPrice")

        sql = "select servicesName, servicesPrice from tblServices"
        Dim cmdReaderTwo As New OleDbCommand(sql, con)
        Dim myreaderTwo As OleDbDataReader
        myreaderTwo = cmdReaderTwo.ExecuteReader()

        While (myreaderTwo.Read())
            Label3.Visible = False

            Dim uc As New ucReserveServices

            uc.Panel1.Visible = False
            uc.txtService.Text = myreaderTwo("servicesName")
            uc.txtPrice.Text = myreaderTwo("servicesPrice")

            Me.flpServices.Controls.Add(uc)


        End While

        con.Close()

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        Panel2.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.BackColor = Color.Transparent

    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Panel2.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        frmShadowBg.Close()
        Me.Close()
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        Me.Close()
    End Sub

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs)
        Dim control As New ucAddServices
        flpServices.Controls.Add(control)

        Label3.Hide()

    End Sub

    Private Sub flpServices_ControlRemoved(sender As Object, e As ControlEventArgs) Handles flpServices.ControlRemoved

        If flpServices.Controls.Count.Equals(0) Then
            Label3.Visible = True
        End If

    End Sub

    Private Sub txtCustomerName_Click(sender As Object, e As EventArgs) Handles txtCustomerName.Click
        RectangleShape5.BorderColor = Color.DodgerBlue

    End Sub

    Private Sub txtCustomerName_Leave(sender As Object, e As EventArgs) Handles txtCustomerName.Leave
        RectangleShape5.BorderColor = Color.Transparent

        If String.IsNullOrEmpty(txtCustomerName.Text) Then
            label4.Visible = True
        End If
    End Sub

    Private Sub txtContact_Click(sender As Object, e As EventArgs) Handles txtContact.Click
        RectangleShape6.BorderColor = Color.DodgerBlue


    End Sub

    Private Sub txtContact_Leave(sender As Object, e As EventArgs) Handles txtContact.Leave
        RectangleShape6.BorderColor = Color.Transparent

        If String.IsNullOrEmpty(txtContact.Text) Then
            Label6.Visible = True
        End If
    End Sub

    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click
        RectangleShape7.BorderColor = Color.DodgerBlue


    End Sub

    Private Sub txtTotal_Leave(sender As Object, e As EventArgs) Handles txtTotal.Leave
        RectangleShape7.BorderColor = Color.Transparent

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim uc2 As New ucReserveServices
        Me.TopMost = False

        If condition = True Then
            msgError.Show()

        ElseIf txtTotal.Text = "" Then
            msgError.Show()

        Else
            frmCustomerReservePayment.reserveRoomCodeThree = reserveRoomCodeTwo
            frmCustomerReservePayment.reserveRoomCodeThree = lblCode.Text
            frmCustomerReservePayment.customerName = txtCustomerName.Text
            frmCustomerReservePayment.customerNumber = txtContact.Text

            Dim reservedDate As DateTime = datePicker.Value.Date
            frmCustomerReservePayment.customerDate = reservedDate.ToString("dddd dd, MMMMM, yyyy")

            frmCustomerReservePayment.customerHeads = txtTotal.Text
            frmCustomerReservePayment.customerDiscount = lblDiscount.Text
            frmCustomerReservePayment.customerPercentage = txtPercentage.Text
            frmCustomerReservePayment.customerEntranceFee = txtEntranceFee.Text

            'Service

            Dim sb As New StringBuilder
            Dim sbTwo As New StringBuilder
            Dim customerService As Integer
            Dim customerServiceTwo As Integer

            For Each uc As ucReserveServices In Me.flpServicesTwo.Controls()
                sb.Append(uc.txtService.Text)
                sbTwo.Append(uc.txtPrice.Text)
                customerService = uc.txtCount.Text * uc.txtPrice.Text
                frmCustomerReservePayment.txtService.AppendText("Service Name:   " & sb.ToString & "  ---  Price:   " & sbTwo.ToString & "  ---  Heads:   " & uc.txtCount.Text & "  ---  Total =   " & customerService.ToString & Environment.NewLine)
                frmCustomerReservePayment.txtServiceTwo.AppendText("Service Name: " & sb.ToString & ",  Price: " & sbTwo.ToString & ",  Heads: " & uc.txtCount.Text & ",  Total = " & customerService.ToString & Environment.NewLine)
                customerServiceTwo = customerServiceTwo + customerService
                sb.Clear()
                sbTwo.Clear()

            Next
            frmCustomerReservePayment.customerServicePrice = customerServiceTwo
            frmCustomerReservePayment.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        total += 1
        lblDiscount.Text = total

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If lblDiscount.Text <> 0 Then
            total -= 1
            lblDiscount.Text = total
        End If
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        frmShadowBg.Close()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        RectangleShape12.BackColor = Color.White
        RectangleShape12.BorderColor = Color.DodgerBlue
        txtEntranceFee.Enabled = True
        txtEntranceFee.BackColor = Color.White
        Label5.BackColor = Color.White
    End Sub

    Private Sub OvalShape3_Click(sender As Object, e As EventArgs) Handles OvalShape3.Click
        OvalShape3.BackColor = Color.LightGray
        OvalShape4.BackColor = Color.FromArgb(235, 235, 235)

        frmCustomerReservePayment.status = "Waiting"

    End Sub

    Private Sub OvalShape4_Click(sender As Object, e As EventArgs) Handles OvalShape4.Click
        OvalShape4.BackColor = Color.LightGray
        OvalShape3.BackColor = Color.FromArgb(235, 235, 235)

        datePicker.Visible = True
        datePicker.Location = New Point(124, 10)
        Label16.Location = New Point(80, 12)
        Label14.Visible = False
        Label15.Visible = False

        OvalShape3.Visible = False
        OvalShape4.Visible = False

        frmCustomerReservePayment.status = "Waiting For Arrival"

    End Sub
End Class
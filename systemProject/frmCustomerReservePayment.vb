Imports System.IO
Imports System.Data.OleDb

Public Class frmCustomerReservePayment

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim modeOfPayment As String
    Dim payment As Integer

    Public reserveRoomCodeThree As String

    Public customerName As String
    Public customerNumber As String
    Public customerDate As String
    Public customerHeads As Integer
    Public customerDiscount As Integer
    Public customerPercentage As Integer
    Public customerEntranceFee As Integer
    Public customerServicePrice As Integer

    Public status As String

    Private Sub frmCustomerReservePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmShadowBg.Show()

        con.Open()

        sql = "select roomCode, roomImage, roomName, roomPrice from tblRooms where roomCode='" + reserveRoomCodeThree + "' "
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        myreader.Read()


        pbRoomImage.Tag = myreader("roomImage")
        pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
        txtRoomName.Text = myreader("roomName")
        txtPrice.Text = myreader("roomPrice")

        con.Close()

        'Room
        txtRoomName.ReadOnly = True
        txtRoomName.BackColor = Color.White
        txtPrice.ReadOnly = True
        txtPrice.BackColor = Color.White
        txtService.ReadOnly = True
        txtService.BackColor = Color.White

        lblCode.Text = reserveRoomCodeThree

        'Customer Info
        txtCustomerName.Text = customerName
        txtContact.Text = customerNumber
        txtDate.Text = customerDate
        txtTotal.Text = customerHeads
        lblDiscount.Text = customerDiscount
        txtPercentage.Text = customerPercentage
        txtEntranceFee.Text = customerEntranceFee

        'Payment Info

        'Room
        txtPriceRoom.Text = txtPrice.Text

        'Entrace Fee
        Dim entranceFee As Integer
        entranceFee = customerHeads * customerEntranceFee
        txtPriceEntranceFee.Text = entranceFee

        'Service
        txtPriceService.Text = customerServicePrice

        'Discounted Price
        Dim discount As Integer
        Dim percentage As Double
        discount = customerDiscount * customerEntranceFee
        percentage = customerPercentage / 100
        discount = discount * percentage
        txtPriceDiscount.Text = discount

        txtPriceDiscount.ReadOnly = True
        txtPriceDiscount.ForeColor = Color.Red

        'Total
        Dim total
        total = txtPriceRoom.Text + entranceFee + customerServicePrice - discount
        txtPriceTotal.Text = total


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
        frmCustomerReserve.Visible = True
        Me.Close()
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        Me.Close()
    End Sub

    Private Sub txtCustomerName_Click(sender As Object, e As EventArgs) Handles txtCustomerName.Click
        RectangleShape5.BorderColor = Color.DodgerBlue


    End Sub

    Private Sub txtCustomerName_Leave(sender As Object, e As EventArgs) Handles txtCustomerName.Leave
        RectangleShape5.BorderColor = Color.Transparent

        If String.IsNullOrEmpty(txtCustomerName.Text) Then
            Label4.Visible = True
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

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        frmCustomerReserve.Visible = True
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        RectangleShape12.BackColor = Color.White
        RectangleShape12.BorderColor = Color.White
        txtEntranceFee.Enabled = True
        txtEntranceFee.BackColor = Color.White
        Label5.BackColor = Color.White
    End Sub

    Private Sub OvalShape3_Click(sender As Object, e As EventArgs) Handles OvalShape3.Click
        OvalShape3.BackColor = Color.LightGray
        OvalShape4.BackColor = Color.FromArgb(235, 235, 235)

        Panel16.Visible = False

        modeOfPayment = "Full Payment"
        txtDownpaymentAmount.Text = txtPriceTotal.Text
        payment = txtDownpaymentAmount.Text

    End Sub

    Private Sub OvalShape4_Click(sender As Object, e As EventArgs) Handles OvalShape4.Click
        OvalShape4.BackColor = Color.LightGray
        OvalShape3.BackColor = Color.FromArgb(235, 235, 235)
        RectangleShape10.BorderColor = Color.DodgerBlue

        Panel16.Visible = True

        modeOfPayment = "Downpayment"

        txtDownpaymentAmount.Text = ""

    End Sub

    Private Sub txtDownpaymentAmount_Click(sender As Object, e As EventArgs) Handles txtDownpaymentAmount.Click
        RectangleShape10.BorderColor = Color.DodgerBlue
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim cmd As New OleDbCommand
        Dim i As Integer
        Dim reservationDate As DateTime = datePicker.Value.Date

        Me.TopMost = False

        If modeOfPayment = "" Then

            msgError.Show()

        ElseIf txtDownpaymentAmount.Text = "" Then

            msgError.Show()

        Else

            Try
                con.Open()
                payment = txtDownpaymentAmount.Text
                sql = "Insert into tblCustomer(roomName, roomPrice, customerName, customerContact, reservationDate ,reservedDate, totalHeads, totalDiscountedHeads, entranceFee, services, overallEntranceFee, overallServices, discountedFee, overallCost, modeOfPayment, payment, status) values('" + txtRoomName.Text + "', '" + txtPrice.Text + "', '" + txtCustomerName.Text + "' , '" + txtContact.Text + "', '" + reservationDate.ToString("dddd dd, MMMMM, yyyy") + "' , '" + txtDate.Text + "', '" + txtTotal.Text + "', '" + lblDiscount.Text + "', '" + txtEntranceFee.Text + "', '" + txtServiceTwo.Text + "', '" + txtPriceEntranceFee.Text + "', '" + txtPriceService.Text + "', '" + txtPriceDiscount.Text + "', '" + txtPriceTotal.Text + "', '" + modeOfPayment.ToString + "', '" + payment.ToString + "', '" + status.ToString + "') "
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    Me.TopMost = False
                Else
                    MsgBox("Error!")
                End If

                sql = "Update tblRooms set [roomStatus]='Occupied' where roomCode='" + reserveRoomCodeThree + "'"
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If

        If i > 0 Then
            msgReserved.Show()
            Me.Close()
        End If

    End Sub

End Class
Imports System.IO
Imports System.Data.OleDb

Public Class frmCustomerDetailHistory

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim sqlTwo As String
    Dim modeOfPayment As String
    Dim payment As Integer

    Public reserveRoomName As String
    Public reserveCustomerName As String
    Public reserveRoomCode As String

    Private Shadows Sub refresh()

        'For Vaccant
        Dim strsql As String
        strsql = "Select Count(*) from tblRooms where roomStatus='Vaccant'"
        Dim cmd As New OleDbCommand(strsql, con)

        Dim vaccantCount As Int32 = 0
        vaccantCount = Convert.ToInt32(cmd.ExecuteScalar())
        frmAdmin.lblVaccant.Text = vaccantCount.ToString

        'For Occupied
        strsql = "Select Count(*) from tblRooms where roomStatus='Occupied'"
        Dim cmdTwo As New OleDbCommand(strsql, con)

        Dim occupiedCount As Int32 = 0
        occupiedCount = Convert.ToInt32(cmdTwo.ExecuteScalar())
        frmAdmin.lblOccupied.Text = occupiedCount.ToString

        'For Downpayment
        strsql = "Select Count(*) from tblCustomer where modeOfPayment='Downpayment'"
        Dim cmdThree As New OleDbCommand(strsql, con)

        Dim downPaymentCount As Int32 = 0
        downPaymentCount = Convert.ToInt32(cmdThree.ExecuteScalar())
        frmAdmin.lblDownpayment.Text = downPaymentCount.ToString

        'Flowlayoutpanel Refresh
        frmAdmin.flpAdminReserved.Controls.Clear()
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

            frmAdmin.flpAdminReserved.Controls.Add(uc)

            sqlTwo = "select roomCode from tblRooms where roomName='" + uc.txtRoomName.Text + "' "
            Dim cmdReaderTwo As New OleDbCommand(sqlTwo, con)
            Dim myreaderTwo As OleDbDataReader
            myreaderTwo = cmdReaderTwo.ExecuteReader()
            myreaderTwo.Read()
            uc.Label1.Text = myreaderTwo("roomCode")

        End While

    End Sub

    Private Sub frmCustomerDetailHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmShadowBg.Show()
        con.Open()

        sql = "select  roomName, customerName, services, customerContact, reservedDate, totalHeads, totalDiscountedHeads, entranceFee, modeOfPayment, payment, overallEntranceFee, overallServices, roomPrice, discountedFee, overallCost from tblCustomer where roomName='" + reserveRoomName + "' AND customerName='" + reserveCustomerName + "'  "
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        myreader.Read()

        txtRoomName.Text = myreader("roomName")
        txtCustomerName.Text = myreader("customerName")
        txtService.Text = myreader("services")
        txtContact.Text = myreader("customerContact")
        txtDate.Text = myreader("reservedDate")
        txtTotal.Text = myreader("totalHeads")
        lblDiscount.Text = myreader("totalDiscountedHeads")
        txtEntranceFee.Text = myreader("entranceFee")
        txtMode.Text = myreader("modeOfPayment")
        txtDownpaymentAmount.Text = myreader("payment")
        If txtMode.Text = "Downpayment" Then
            txtDownpaymentAmount.Visible = True
        End If
        txtPriceEntranceFee.Text = myreader("overallEntranceFee")
        txtPriceService.Text = myreader("overallServices")
        txtPriceRoom.Text = myreader("roomPrice")
        txtPriceDiscount.Text = myreader("discountedFee")
        txtPriceTotal.Text = myreader("overallCost")

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

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        frmShadowBg.Close()
        Me.Close()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim cmd As New OleDbCommand
        Dim i As Integer

        Try
            con.Open()
            sql = "Update tblCustomer set [status]='Complete', [modeOfPayment]='Full Payment' where roomName='" + txtRoomName.Text + "' And customerName='" + txtCustomerName.Text + "' "
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            sql = "Update tblRooms set [roomStatus]='Vaccant' where roomCode='" + reserveRoomCode + "' "
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then

                'Refresh Dashboard / frmAdmin
                refresh()

                con.Close()

                Me.TopMost = False
                MsgBox("Customer Finish")
                frmShadowBg.Close()
                Me.Close()

            Else
                MsgBox("Error!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try

        con.Close()

    End Sub

End Class
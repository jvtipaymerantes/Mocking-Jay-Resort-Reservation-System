Public Class ucMainCustomer


    Private Sub ucMainCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ucMainCustomer_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        frmCustomerDetail.reserveRoomName = txtRoomName.Text
        frmCustomerDetail.reserveCustomerName = txtName.Text
        frmCustomerDetail.reserveRoomCode = Label1.Text

        frmCustomerDetail.Show()

    End Sub

End Class

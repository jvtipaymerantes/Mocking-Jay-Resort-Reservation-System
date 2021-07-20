Public Class ucMainHistory


    Private Sub ucMainHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ucMainHistory_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        frmCustomerDetail.reserveRoomName = txtRoomName.Text
        frmCustomerDetail.reserveCustomerName = txtName.Text

        frmCustomerDetail.Show()

    End Sub

End Class

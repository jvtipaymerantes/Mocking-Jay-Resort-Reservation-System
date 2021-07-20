Public Class ucReserveRoom

    Public reserveRoomCode As String

    Private Sub ucReserveRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtRoomName.Enabled = False
        txtRoomName.BackColor = Color.White

        txtPrice.Enabled = False
        txtPrice.BackColor = Color.White

        txtDescription.Enabled = False
        txtDescription.BackColor = Color.White

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        reserveRoomCode = lblroomCode.Text

        frmCustomerReserve.reserveRoomCodeTwo = reserveRoomCode
        frmCustomerReserve.Show()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click
        reserveRoomCode = lblroomCode.Text

        frmCustomerReserve.reserveRoomCodeTwo = reserveRoomCode
        frmCustomerReserve.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        reserveRoomCode = lblroomCode.Text

        frmCustomerReserve.reserveRoomCodeTwo = reserveRoomCode
        frmCustomerReserve.Show()
    End Sub

    Private Sub RectangleShape2_MouseHover(sender As Object, e As EventArgs) Handles RectangleShape2.MouseHover
        RectangleShape2.BackColor = Color.FromArgb(229, 158, 0)
        RectangleShape2.BorderColor = Color.FromArgb(229, 158, 0)
        Label3.BackColor = Color.FromArgb(229, 158, 0)
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        RectangleShape2.BackColor = Color.FromArgb(229, 158, 0)
        RectangleShape2.BorderColor = Color.FromArgb(229, 158, 0)
        Label3.BackColor = Color.FromArgb(229, 158, 0)
    End Sub

    Private Sub RectangleShape2_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape2.MouseLeave
        RectangleShape2.BackColor = Color.FromArgb(243, 170, 24)
        RectangleShape2.BorderColor = Color.FromArgb(243, 170, 24)
        Label3.BackColor = Color.FromArgb(243, 170, 24)
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        RectangleShape2.BackColor = Color.FromArgb(243, 170, 24)
        RectangleShape2.BorderColor = Color.FromArgb(243, 170, 24)
        Label3.BackColor = Color.FromArgb(243, 170, 24)
    End Sub
End Class

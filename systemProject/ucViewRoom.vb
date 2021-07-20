Public Class ucViewRoom

    Public reserveRoomCode As String

    Private Sub ucViewRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRoomName.Enabled = False
        txtRoomName.BackColor = Color.White

        txtPrice.Enabled = False
        txtPrice.BackColor = Color.White

        txtDescription.Enabled = False
        txtDescription.BackColor = Color.White

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If txtStatus.Text = "Occupied" Then
            MsgBox("Room Occupied Unable to Edit")
        Else
            frmAdminAddRoom.boolEdit = True
            reserveRoomCode = lblroomCode.Text
            frmAdminAddRoom.PictureBox3.Visible = True
            frmAdminAddRoom.PictureBox1.Visible = True
            frmAdminAddRoom.viewRoomCode = reserveRoomCode
            frmAdminAddRoom.Show()
        End If

    End Sub

End Class

Imports System.IO
Imports System.Data.OleDb
Imports System.Text
Public Class msgWarning

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer

    Private Shadows Sub refresh()
        con.Open()

        sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice, roomStatus from tblRooms"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())

            Dim uc As New ucViewRoom

            uc.lblroomCode.Text = myreader("roomCode")
            uc.pbRoomImage.Tag = myreader("roomImage")
            uc.pbRoomImage.Image = Image.FromFile(uc.pbRoomImage.Tag)
            uc.txtRoomName.Text = myreader("roomName")
            uc.txtDescription.Text = myreader("roomDescription")
            uc.txtPrice.Text = myreader("roomPrice")
            uc.txtStatus.Text = myreader("roomStatus")

            frmAdminViewRooms.flpViewRooms.Controls.Add(uc)

        End While

        con.Close()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        frmAdminAddRoom.boolDelete = True

        con.Open()

        Try

            sql = "delete * from tblRooms where roomCode='" + frmAdminAddRoom.txtRoomCode.Text + "' AND roomName='" + frmAdminAddRoom.txtRoomName.Text + "' "
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then

                con.Close()

                frmAdminViewRooms.flpViewRooms.Controls.Clear()
                Refresh()

                frmAdminAddRoom.Close()
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
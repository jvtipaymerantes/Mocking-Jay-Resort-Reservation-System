Imports System.IO
Imports System.Data.OleDb
Imports System.Text

Public Class frmAdminAddRoom

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As New Integer
    Dim status As String = "Vaccant"

    Public boolEdit As Boolean
    Public viewRoomCode As String
    Public boolDelete As Boolean

    Dim cmdReader As OleDbDataReader

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

    Private Sub frmAdminAddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmShadowBg.Show()

        If boolEdit = True Then

            PictureBox4.Visible = False

            lblRoomName.Visible = False
            lblDescription.Visible = False
            lblPrice.Visible = False
            Panel9.Hide()
            pbRoomImage.BackColor = Color.Transparent
            RectangleShape5.Visible = False
            pbRoomImage.Enabled = False

            con.Open()

            sql = "select roomCode, roomImage, roomName, roomDescription, roomPrice from tblRooms where roomCode='" + viewRoomCode + "' "
            Dim cmdReader As New OleDbCommand(sql, con)
            Dim myreader As OleDbDataReader
            myreader = cmdReader.ExecuteReader()

            myreader.Read()


            pbRoomImage.Tag = myreader("roomImage")
            pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
            txtRoomCode.Text = myreader("roomCode")
            txtRoomName.Text = myreader("roomName")
            txtDescription.Text = myreader("roomDescription")
            txtPrice.Text = myreader("roomPrice")

            con.Close()

        Else

            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To 6
                Dim idx As Integer = r.Next(0, 35)
                sb.Append(s.Substring(idx, 1))
            Next

            txtRoomCode.Text = sb.ToString


            con.Open()
            sql = "select roomCode from tblRooms where roomCode='" + txtRoomCode.Text + "'"
            Dim cmd2 As New OleDbCommand(sql, con)
            cmdReader = cmd2.ExecuteReader

            While (cmdReader.Read())
                For i As Integer = 1 To 6
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next

                txtRoomCode.Text = sb.ToString
            End While


            con.Close()

        End If

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
        frmShadowBg.Close()
        Me.Close()
    End Sub

    Private Sub txtRoomName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtRoomName.MouseClick

        RectangleShape1.BorderColor = Color.DeepSkyBlue

        If String.IsNullOrEmpty(txtRoomName.Text) Then
            lblRoomName.Hide()
        End If

    End Sub

    Private Sub txtRoomName_Leave(sender As Object, e As EventArgs) Handles txtRoomName.Leave

        If String.IsNullOrEmpty(txtRoomName.Text) Then
            lblRoomName.Visible = True
        End If

        RectangleShape1.BorderColor = Color.White

    End Sub

    Private Sub txtPrice_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPrice.MouseClick

        RectangleShape3.BorderColor = Color.DeepSkyBlue

        If String.IsNullOrEmpty(txtPrice.Text) Then
            lblPrice.Hide()
        End If

    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave

        If String.IsNullOrEmpty(txtPrice.Text) Then
            lblPrice.Visible = True
        End If

        RectangleShape3.BorderColor = Color.White

    End Sub

    Private Sub txtDescription_MouseClick(sender As Object, e As MouseEventArgs) Handles txtDescription.MouseClick

        RectangleShape2.BorderColor = Color.DeepSkyBlue

        If String.IsNullOrEmpty(txtDescription.Text) Then
            lblDescription.Hide()
        End If

    End Sub

    Private Sub txtDescription_Leave(sender As Object, e As EventArgs) Handles txtDescription.Leave

        If String.IsNullOrEmpty(txtDescription.Text) Then
            lblDescription.Visible = True
        End If

        RectangleShape2.BorderColor = Color.White

    End Sub

    Private Sub frmAdminAddRoom_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If String.IsNullOrEmpty(txtRoomName.Text) Then
            lblRoomName.Visible = True
        End If

        If String.IsNullOrEmpty(txtPrice.Text) Then
            lblPrice.Visible = True
        End If

        If String.IsNullOrEmpty(txtDescription.Text) Then
            lblDescription.Visible = True
        End If

        RectangleShape1.BorderColor = Color.White
        RectangleShape2.BorderColor = Color.White
        RectangleShape3.BorderColor = Color.White

    End Sub

    Private Sub pbRoomImage_Click(sender As Object, e As EventArgs) Handles pbRoomImage.Click

        Using img As OpenFileDialog = New OpenFileDialog()

            img.Filter = " choose image(*.jpg;* .png;* .jpeg)|*.jpg;* .png;* .jpeg"

            If img.ShowDialog() = DialogResult.OK Then

                pbRoomImage.Tag = img.FileName
                pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
                'pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
                Panel9.Hide()
                pbRoomImage.BackColor = Color.Transparent
                RectangleShape5.Visible = False
                pbRoomImage.Enabled = False

                PictureBox3.Visible = True

            End If

        End Using

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Using img As OpenFileDialog = New OpenFileDialog()

            img.Filter = " choose image(*.jpg;* .png;* .jpeg)|*.jpg;* .png;* .jpeg"

            If img.ShowDialog() = DialogResult.OK Then

                pbRoomImage.Image = Image.FromFile(img.FileName)
                Panel9.Hide()
                pbRoomImage.BackColor = Color.Transparent
                pbRoomImage.Enabled = False

                PictureBox3.Visible = True

            End If

        End Using
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        txtRoomCode.BackColor = Color.White
        RectangleShape4.BackColor = Color.White
        txtRoomCode.Enabled = True
        txtRoomCode.ReadOnly = False

        txtRoomCode.Select()

        RectangleShape4.BorderColor = Color.DeepSkyBlue
        RectangleShape1.BorderColor = Color.White
        RectangleShape2.BorderColor = Color.White
        RectangleShape3.BorderColor = Color.White
        RectangleShape4.BackColor = Color.White
        RectangleShape4.BorderColor = Color.White

    End Sub

    Private Sub txtRoomCode_Leave(sender As Object, e As EventArgs) Handles txtRoomCode.Leave
        RectangleShape4.BorderColor = Color.White
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If boolEdit = True Then

            con.Open()

            sql = "Update tblRooms set [roomName]='" + txtRoomName.Text + "', [roomPrice]='" + txtPrice.Text + "', [roomDescription]='" + txtDescription.Text + "' where roomCode='" + txtRoomCode.Text + "'"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

            MsgBox("Room Updated")

            con.Close()

            'Flowlayoutpanel Refresh
            frmAdminViewRooms.flpViewRooms.Controls.Clear()
            refresh()



        Else

            con.Open()

            sql = "select roomCode from tblRooms where roomCode='" + txtRoomCode.Text + "'"
            Dim cmd2 As New OleDbCommand(sql, con)
            cmdReader = cmd2.ExecuteReader

            If (cmdReader.Read()) Then
                RectangleShape4.BorderColor = Color.Red
            Else

                Try

                    Dim fileName As String = "images/" + CStr(Date.Now().Ticks) + ".jpeg"
                    'To Create Random Filename
                    File.Copy(pbRoomImage.Tag, fileName)
                    'Copied Image

                    sql = "INSERT INTO tblRooms (roomCode, roomImage, roomName, roomDescription, roomPrice, roomStatus) values ('" & txtRoomCode.Text & "', '" & fileName & "' , '" & txtRoomName.Text & "','" & txtDescription.Text & "','" & txtPrice.Text & "', '" & status.ToString & "');"
                    cmd.Connection = con
                    cmd.CommandText = sql

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then

                        con.Close()

                        'Flowlayoutpanel Refresh
                        frmAdminViewRooms.flpViewRooms.Controls.Clear()
                        refresh()

                        msgAdded.Show()
                        Me.Close()
                    Else
                        msgError.Show()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally

                End Try

            End If

            con.Close()

        End If

        

    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click

        Using img As OpenFileDialog = New OpenFileDialog()

            img.Filter = " choose image(*.jpg;* .png;* .jpeg)|*.jpg;* .png;* .jpeg"

            If img.ShowDialog() = DialogResult.OK Then

                pbRoomImage.Tag = img.FileName
                pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
                Panel9.Hide()
                pbRoomImage.BackColor = Color.Transparent
                RectangleShape5.Visible = False
                pbRoomImage.Enabled = False

                PictureBox3.Visible = True

            End If

        End Using

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Using img As OpenFileDialog = New OpenFileDialog()

            img.Filter = " choose image(*.jpg;* .png;* .jpeg)|*.jpg;* .png;* .jpeg"

            If img.ShowDialog() = DialogResult.OK Then

                pbRoomImage.Tag = img.FileName
                pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
                Panel9.Hide()
                pbRoomImage.BackColor = Color.Transparent
                RectangleShape5.Visible = False
                pbRoomImage.Enabled = False

                PictureBox3.Visible = True

            End If

        End Using
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Using img As OpenFileDialog = New OpenFileDialog()

            img.Filter = " choose image(*.jpg;* .png;* .jpeg)|*.jpg;* .png;* .jpeg"

            If img.ShowDialog() = DialogResult.OK Then

                pbRoomImage.Tag = img.FileName
                pbRoomImage.Image = Image.FromFile(pbRoomImage.Tag)
                Panel9.Hide()
                pbRoomImage.BackColor = Color.Transparent
                RectangleShape5.Visible = False
                pbRoomImage.Enabled = False

                PictureBox3.Visible = True

            End If

        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.TopMost = False
        msgWarning.Show()

        If boolDelete = True Then

            con.Open()

            Try

                sql = "delete * from tblRooms where roomCode='" + txtRoomCode.Text + "' AND roomName='" + txtRoomName.Text + "' "
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then

                    MsgBox("Room Removed Successful!")

                    con.Close()

                    frmAdminViewRooms.flpViewRooms.Controls.Clear()
                    refresh()

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

        End If

        

    End Sub

End Class

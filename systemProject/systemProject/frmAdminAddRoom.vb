Imports System.IO
Public Class frmAdminAddRoom
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Bahay\Documents\Visual Studio 2012\Projects\systemProject\resortDb.accdb")

    Private Sub frmAdminAddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmShadowBg.Show()

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

    Private Sub Panel8_MouseHover(sender As Object, e As EventArgs) Handles Panel8.MouseHover
        Panel8.BackColor = Color.FromArgb(47, 168, 79)
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Panel8.BackColor = Color.FromArgb(47, 168, 79)
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Panel8.BackColor = Color.FromArgb(47, 168, 79)
    End Sub

    Private Sub Panel8_MouseLeave(sender As Object, e As EventArgs) Handles Panel8.MouseLeave
        Panel8.BackColor = Color.FromArgb(52, 188, 89)
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim control As New ucAddServices
        flpServices.Controls.Add(control)

        Label3.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim control As New ucAddServices
        flpServices.Controls.Add(control)

        Label3.Hide()

    End Sub

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel8.MouseClick
        Dim control As New ucAddServices
        flpServices.Controls.Add(control)

        Label3.Hide()

    End Sub

    Private Sub pbRoomImage_MouseHover(sender As Object, e As EventArgs) Handles pbRoomImage.MouseHover
        pbRoomImage.BackColor = Color.FromArgb(220, 220, 220)
        Panel9.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub pbRoomImage_MouseLeave(sender As Object, e As EventArgs) Handles pbRoomImage.MouseLeave
        pbRoomImage.BackColor = Color.White
        Panel9.BackColor = Color.White
    End Sub

    Private Sub Panel9_MouseHover(sender As Object, e As EventArgs) Handles Panel9.MouseHover
        pbRoomImage.BackColor = Color.FromArgb(220, 220, 220)
        Panel9.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        pbRoomImage.BackColor = Color.FromArgb(220, 220, 220)
        Panel9.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        pbRoomImage.BackColor = Color.FromArgb(220, 220, 220)
        Panel9.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub pbRoomImage_Click(sender As Object, e As EventArgs) Handles pbRoomImage.Click

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

    End Sub

    Private Sub txtRoomCode_Leave(sender As Object, e As EventArgs) Handles txtRoomCode.Leave
        RectangleShape4.BorderColor = Color.White
    End Sub

    Private Sub flpServices_ControlRemoved(sender As Object, e As ControlEventArgs) Handles flpServices.ControlRemoved

        If flpServices.Controls.Count.Equals(0) Then
            Label3.Visible = True
        End If

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String
        Dim cmd As New OleDb.OleDbCommand
        Dim i As New Integer

        Try
            con.Open()
            sql = "INSERT INTO tblRooms (roomName, roomDescription, roomPrice) values ('" & txtRoomName.Text & "','" & txtDescription.Text & "'," & txtPrice.Text & ");"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Successful!")
            Else
                MsgBox("Error!")
            End If

            For Each uc As ucAddServices In flpServices.Controls()

                sql = "INSERT INTO tblServices (servicesName, servicesPrice) values ('" & uc.txtService.Text & "','" & uc.txtPrice.Text & "');"
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Services Successful!")
                Else
                    MsgBox("Error!")
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Class
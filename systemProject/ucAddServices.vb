Imports System.IO
Imports System.Data.OleDb
Imports System.Text

Public Class ucAddServices

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As New Integer

    Private Sub RemoveMe()
        Me.Parent.Controls.Remove(Me)
    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles txtService.MouseClick

        RectangleShape2.BorderColor = Color.DeepSkyBlue

        If String.IsNullOrEmpty(txtService.Text) Then
            lblService.Hide()
        End If



    End Sub


    Private Sub txtService_Leave(sender As Object, e As EventArgs) Handles txtService.Leave

        If String.IsNullOrEmpty(txtService.Text) Then
            lblService.Visible = True
        End If

        RectangleShape2.BorderColor = Color.White
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
        RectangleShape1.BorderColor = Color.White
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        con.Open()

        Try
            sql = "delete * from tblServices where servicesCode='" + lblCode.Text + "' AND servicesName='" + txtService.Text + "' "
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Service Removed Successful!")
                RemoveMe()
            Else
                MsgBox("Error!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try

        con.Close()

    End Sub

    Private Sub OvalShape1_Click(sender As Object, e As EventArgs) Handles OvalShape1.Click
        con.Open()

        Try
            sql = "delete * from tblServices where servicesCode='" + lblCode.Text + "' AND servicesName='" + txtService.Text + "' "
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Service Removed Successful!")
                RemoveMe()
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

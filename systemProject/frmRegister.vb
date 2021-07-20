Imports System.IO
Imports System.Data.OleDb
Imports System.Text

Public Class frmRegister
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As New Integer

    Private Sub txtboxUsername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtboxUsername.MouseClick
        RectangleShape1.BorderColor = Color.DodgerBlue

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Hide()
        End If

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Visible = True
        End If

        RectangleShape3.BorderColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub txtboxPassword_MouseClick(sender As Object, e As MouseEventArgs) Handles txtboxPassword.MouseClick
        RectangleShape3.BorderColor = Color.DodgerBlue

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Hide()
        End If

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Visible = True
        End If

        RectangleShape1.BorderColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If txtboxUsername.Text = "" Then
            RectangleShape1.BorderColor = Color.Red
        ElseIf txtboxPassword.Text = "" Then
            RectangleShape3.BorderColor = Color.Red
        Else

            con.Open()
            Try

                sql = "insert into tblUser (username, userPass) values('" & txtboxUsername.Text & "', '" & txtboxPassword.Text & "');"

                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Account Added")

                Else
                    MsgBox("Error!")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

            End Try

            con.Close()

            frmLogin.Show()
            Me.Close()

        End If
    End Sub

End Class
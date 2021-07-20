Imports System.IO
Imports System.Data.OleDb

Public Class frmLogin

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand


    Private Sub txtboxUsername_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtboxUsername.MouseClick

        RectangleShape1.BorderColor = Color.DodgerBlue

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Hide()
        End If

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Visible = True
        End If

        RectangleShape3.BorderColor = Color.FromArgb(240, 240, 240)

    End Sub

    Private Sub txtboxPassword_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtboxPassword.MouseClick

        RectangleShape3.BorderColor = Color.DodgerBlue

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Hide()
        End If

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Visible = True
        End If

        RectangleShape1.BorderColor = Color.FromArgb(240, 240, 240)

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick

        RectangleShape1.BorderColor = Color.FromArgb(240, 240, 240)
        RectangleShape3.BorderColor = Color.FromArgb(240, 240, 240)

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Visible = True
        End If

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Visible = True
        End If

    End Sub

    Private Sub Button2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2.BackColor = Color.FromArgb(49, 170, 82)
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Button2.ForeColor = Color.FromArgb(49, 170, 82)
        Button2.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        con.Open()

        sql = " Select * from tblUser where username='" & txtboxUsername.Text & "' and userPass='" & txtboxPassword.Text & "' "
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        Dim us As String = ""
        Dim pw As String = ""

        If myreader.Read Then
            us = myreader("username")
            pw = myreader("userPass")

            frmAdmin.Show()
            Me.Close()

        Else
            RectangleShape1.BorderColor = Color.Red

            RectangleShape3.BorderColor = Color.Red

        End If
        
        con.Close()

    End Sub

    Private Sub txtboxPassword_Click(sender As Object, e As EventArgs) Handles txtboxPassword.Click
        RectangleShape3.BorderColor = Color.DodgerBlue

        If String.IsNullOrEmpty(txtboxPassword.Text) Then
            lblPass.Hide()
        End If

        If String.IsNullOrEmpty(txtboxUsername.Text) Then
            lblUser.Visible = True
        End If

        RectangleShape1.BorderColor = Color.FromArgb(240, 240, 240)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frmLogin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim appPath As String = Application.StartupPath()

        con.Open()

        Dim strsql As String
        strsql = "Select Count(*) from tblUser"
        Dim cmd As New OleDbCommand(strsql, con)

        Dim userCount As Int32 = 0
        userCount = Convert.ToInt32(cmd.ExecuteScalar())

        con.Close()

        If userCount = 0 Then
            frmRegister.Show()
            Me.Close()
        End If

    End Sub
End Class

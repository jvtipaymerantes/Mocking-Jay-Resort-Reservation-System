Imports System.IO
Imports System.Data.OleDb
Imports System.Text

Public Class frmAdminServices
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=resortDb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As New Integer

    Dim cmdReader As OleDbDataReader
    Dim cmdReader2 As OleDbDataReader

    Private Sub frmAdminServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmShadowBg.Show()

        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 6
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next

        lblCode.Text = sb.ToString

        con.Open()

        sql = "select servicesCode from tblServices where servicesCode='" + lblCode.Text + "'"
        Dim cmd2 As New OleDbCommand(sql, con)
        cmdReader2 = cmd2.ExecuteReader

        While (cmdReader2.Read())
            For i As Integer = 1 To 6
                Dim idx As Integer = r.Next(0, 35)
                sb.Append(s.Substring(idx, 1))
            Next

            lblCode.Text = sb.ToString
        End While

        con.Close()



        con.Open()

        sql = "select servicesCode, servicesName, servicesPrice from tblServices"
        Dim cmdReader As New OleDbCommand(sql, con)
        Dim myreader As OleDbDataReader
        myreader = cmdReader.ExecuteReader()

        While (myreader.Read())
            Label3.Visible = False

            Dim uc As New ucAddServices

            uc.lblCode.Text = myreader("servicesCode")
            uc.txtService.Text = myreader("servicesName")
            uc.txtPrice.Text = myreader("servicesPrice")

            Me.flpServices.Controls.Add(uc)


        End While

        con.Close()

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

    Private Sub txtRoomName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtServiceName.MouseClick

        RectangleShape1.BorderColor = Color.DeepSkyBlue

    End Sub

    Private Sub txtRoomName_Leave(sender As Object, e As EventArgs) Handles txtServiceName.Leave


        RectangleShape1.BorderColor = Color.White

    End Sub

    Private Sub txtPrice_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPrice.MouseClick

        RectangleShape3.BorderColor = Color.DeepSkyBlue


    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave

        If String.IsNullOrEmpty(txtPrice.Text) Then
            lblServicePrice.Visible = True
        End If

        RectangleShape3.BorderColor = Color.White

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Dim control As New ucAddServices
        flpServices.Controls.Add(control)

        Label3.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim control As New ucAddServices
        flpServices.Controls.Add(control)

        Label3.Hide()

    End Sub

    Private Sub Panel8_MouseClick(sender As Object, e As MouseEventArgs)
        Dim control As New ucAddServices
        flpServices.Controls.Add(control)

        Label3.Hide()

    End Sub

    Private Sub txtRoomCode_Leave(sender As Object, e As EventArgs)
        RectangleShape4.BorderColor = Color.White
    End Sub

    Private Sub flpServices_ControlRemoved(sender As Object, e As ControlEventArgs) Handles flpServices.ControlRemoved

        If flpServices.Controls.Count.Equals(0) Then
            Label3.Visible = True
        End If

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        
        con.Open()

        Try
            sql = "INSERT INTO tblServices (servicesCode, servicesName, servicesPrice) values ('" & lblCode.Text & "', '" & txtServiceName.Text & "', '" & txtPrice.Text & "');"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Service Successful!")
                
            Else
                MsgBox("Error!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try

        con.Close()

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frmAdminServices_Load(e, e) 'Load everything in your form, load event again


    End Sub

    Private Sub txtServiceName_Click(sender As Object, e As EventArgs) Handles txtServiceName.Click

    End Sub
End Class
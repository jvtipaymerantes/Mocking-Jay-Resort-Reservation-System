Public Class ucReserveServices

    Private Sub RemoveMe()

        For Each uc As ucReserveServices In frmCustomerReserve.flpServicesTwo.Controls()
            If txtService.Text = uc.txtService.Text Then
                frmCustomerReserve.flpServicesTwo.Controls.Remove(uc)
            End If
        Next

    End Sub

    Private Sub RectangleShape4_MouseHover(sender As Object, e As EventArgs) Handles RectangleShape4.MouseHover
        

    End Sub

    Private Sub RectangleShape4_MouseLeave(sender As Object, e As EventArgs) Handles RectangleShape4.MouseLeave
        
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        RectangleShape4.BackColor = Color.FromArgb(46, 204, 113)
        RectangleShape4.BorderColor = Color.FromArgb(46, 204, 113)

        frmCustomerReserve.condition = True

        OvalShape2.Visible = True
        PictureBox1.Visible = True

        Label4.Visible = True
        Label11.Visible = False

        Label4.Location = New Point(205, 116)

        Panel1.Visible = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        RemoveMe()
        Label1.Visible = False
        Label11.Visible = True

        Panel1.Visible = False
        txtCount.Text = ""
        OvalShape3.Visible = False
        OvalShape1.Visible = True

        PictureBox2.Visible = False
        OvalShape2.Visible = False
        OvalShape2.BackColor = Color.Red

        RectangleShape4.BackColor = Color.FromArgb(243, 170, 24)
        RectangleShape4.BorderColor = Color.FromArgb(243, 170, 24)

    End Sub


    Private Sub OvalShape3_Click(sender As Object, e As EventArgs) Handles OvalShape3.Click

        OvalShape1.Visible = True
        OvalShape3.Visible = False

        RectangleShape5.Visible = False

    End Sub

    Private Sub OvalShape1_Click(sender As Object, e As EventArgs) Handles OvalShape1.Click
        OvalShape3.BackColor = Color.Silver
        OvalShape3.Visible = True
        RectangleShape5.Visible = False
        txtCount.Text = frmCustomerReserve.txtTotal.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        RectangleShape4.BackColor = Color.FromArgb(243, 170, 24)
        RectangleShape4.BorderColor = Color.FromArgb(243, 170, 24)

        Label1.Visible = False
        Label11.Visible = True

        Panel1.Visible = False
        txtCount.Text = ""
        OvalShape3.Visible = False
        OvalShape1.Visible = True
        RectangleShape5.Visible = False

        PictureBox1.Visible = False
        OvalShape2.Visible = False

        Label4.Visible = False
        Label11.Visible = True


    End Sub

    Private Sub OvalShape2_Click(sender As Object, e As EventArgs) Handles OvalShape2.Click
        Label1.Visible = False
        Label11.Visible = True

        Panel1.Visible = False
        txtCount.Text = ""
        OvalShape3.Visible = False
        OvalShape1.Visible = True

        RectangleShape5.Visible = False

        PictureBox1.Visible = False
        OvalShape2.Visible = False

        Label4.Visible = False
        Label11.Visible = True

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        If String.IsNullOrEmpty(txtCount.Text) Then
            RectangleShape5.Visible = True
            RectangleShape5.BorderColor = Color.Red
        Else

            RectangleShape4.BackColor = Color.FromArgb(235, 235, 235)
            RectangleShape4.BorderColor = Color.FromArgb(235, 235, 235)

            Dim uc As New ucReserveServices
            frmCustomerReserve.flpServicesTwo.Controls.Add(uc)

            uc.txtService.Text = txtService.Text
            uc.txtPrice.Text = txtPrice.Text
            uc.txtCount.Text = txtCount.Text

            Label4.Visible = False
            Label1.Visible = True
            Label1.Location = New Point(201, 116)

            OvalShape2.BackColor = Color.FromArgb(39, 174, 96)
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox2.Location = New Point(4, 3)

            frmCustomerReserve.condition = False

        End If

    End Sub


    Private Sub txtCount_Click(sender As Object, e As EventArgs) Handles txtCount.Click
        RectangleShape5.Visible = False
    End Sub
End Class

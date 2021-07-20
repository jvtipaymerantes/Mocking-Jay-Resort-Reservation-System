Public Class frmShadowBg

    Private Sub frmShadowBg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim a As New Integer
        Dim b As New Integer

        a = frmAdminViewRooms.Width
        b = frmAdminViewRooms.Height

        Me.Size = New Size(a, b)




    End Sub

End Class
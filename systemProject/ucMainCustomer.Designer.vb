<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMainCustomer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtRoomName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMode = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(56, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 1)
        Me.Panel1.TabIndex = 9
        '
        'txtRoomName
        '
        Me.txtRoomName.BackColor = System.Drawing.Color.White
        Me.txtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoomName.Enabled = False
        Me.txtRoomName.Font = New System.Drawing.Font("Gotham", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtRoomName.Location = New System.Drawing.Point(18, 7)
        Me.txtRoomName.Name = "txtRoomName"
        Me.txtRoomName.Size = New System.Drawing.Size(152, 18)
        Me.txtRoomName.TabIndex = 14
        Me.txtRoomName.Text = "Room"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Gotham", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtName.Location = New System.Drawing.Point(147, 7)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(331, 17)
        Me.txtName.TabIndex = 15
        Me.txtName.Text = "Guest's Name"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMode
        '
        Me.txtMode.BackColor = System.Drawing.Color.White
        Me.txtMode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMode.Enabled = False
        Me.txtMode.Font = New System.Drawing.Font("Gotham", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtMode.Location = New System.Drawing.Point(552, 7)
        Me.txtMode.Name = "txtMode"
        Me.txtMode.Size = New System.Drawing.Size(239, 18)
        Me.txtMode.TabIndex = 16
        Me.txtMode.Text = "Mode of Payment"
        Me.txtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.White
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Enabled = False
        Me.txtStatus.Font = New System.Drawing.Font("Gotham", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtStatus.Location = New System.Drawing.Point(831, 6)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(176, 18)
        Me.txtStatus.TabIndex = 17
        Me.txtStatus.Text = "Status"
        Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "--"
        Me.Label1.Visible = False
        '
        'ucMainCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtMode)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtRoomName)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.Name = "ucMainCustomer"
        Me.Size = New System.Drawing.Size(1063, 45)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtRoomName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMode As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class

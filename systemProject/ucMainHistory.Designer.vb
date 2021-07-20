<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMainHistory
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
        Me.txtDate = New System.Windows.Forms.TextBox()
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
        Me.txtRoomName.Location = New System.Drawing.Point(426, 7)
        Me.txtRoomName.Name = "txtRoomName"
        Me.txtRoomName.Size = New System.Drawing.Size(152, 18)
        Me.txtRoomName.TabIndex = 14
        Me.txtRoomName.Text = "Room"
        Me.txtRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Enabled = False
        Me.txtName.Font = New System.Drawing.Font("Gotham", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtName.Location = New System.Drawing.Point(23, 7)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(331, 17)
        Me.txtName.TabIndex = 15
        Me.txtName.Text = "Guest's Name"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.White
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Gotham", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDate.Location = New System.Drawing.Point(673, 7)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(335, 18)
        Me.txtDate.TabIndex = 17
        Me.txtDate.Text = "Date"
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ucMainHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtRoomName)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Margin = New System.Windows.Forms.Padding(0, 0, 0, 22)
        Me.Name = "ucMainHistory"
        Me.Size = New System.Drawing.Size(1063, 45)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtRoomName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox

End Class

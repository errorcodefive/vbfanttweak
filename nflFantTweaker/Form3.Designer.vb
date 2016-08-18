<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblCoor = New System.Windows.Forms.Label()
        Me.btnRedraw = New System.Windows.Forms.Button()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblAver = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.lblxy = New System.Windows.Forms.Label()
        Me.lblVar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCoor
        '
        Me.lblCoor.AutoSize = True
        Me.lblCoor.Location = New System.Drawing.Point(97, 44)
        Me.lblCoor.Name = "lblCoor"
        Me.lblCoor.Size = New System.Drawing.Size(0, 13)
        Me.lblCoor.TabIndex = 0
        '
        'btnRedraw
        '
        Me.btnRedraw.Location = New System.Drawing.Point(-2, 1)
        Me.btnRedraw.Name = "btnRedraw"
        Me.btnRedraw.Size = New System.Drawing.Size(61, 34)
        Me.btnRedraw.TabIndex = 1
        Me.btnRedraw.Text = "Redraw"
        Me.btnRedraw.UseVisualStyleBackColor = True
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(415, 6)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(25, 13)
        Me.lblN.TabIndex = 2
        Me.lblN.Text = "lblN"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(982, 12)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(37, 13)
        Me.lblMax.TabIndex = 3
        Me.lblMax.Text = "lblMax"
        '
        'lblAver
        '
        Me.lblAver.AutoEllipsis = True
        Me.lblAver.AutoSize = True
        Me.lblAver.Location = New System.Drawing.Point(656, 6)
        Me.lblAver.Name = "lblAver"
        Me.lblAver.Size = New System.Drawing.Size(39, 13)
        Me.lblAver.TabIndex = 4
        Me.lblAver.Text = "lblAver"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(269, 44)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(57, 20)
        Me.lblPlayer.TabIndex = 5
        Me.lblPlayer.Text = "Label1"
        '
        'lblxy
        '
        Me.lblxy.AutoSize = True
        Me.lblxy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblxy.Location = New System.Drawing.Point(490, 44)
        Me.lblxy.Name = "lblxy"
        Me.lblxy.Size = New System.Drawing.Size(57, 20)
        Me.lblxy.TabIndex = 6
        Me.lblxy.Text = "Label1"
        '
        'lblVar
        '
        Me.lblVar.AutoSize = True
        Me.lblVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVar.Location = New System.Drawing.Point(655, 44)
        Me.lblVar.Name = "lblVar"
        Me.lblVar.Size = New System.Drawing.Size(57, 20)
        Me.lblVar.TabIndex = 7
        Me.lblVar.Text = "Label1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1076, 580)
        Me.Controls.Add(Me.lblVar)
        Me.Controls.Add(Me.lblxy)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.lblAver)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.btnRedraw)
        Me.Controls.Add(Me.lblCoor)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCoor As Label
    Friend WithEvents btnRedraw As Button
    Friend WithEvents lblN As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents lblAver As Label
    Friend WithEvents lblPlayer As Label
    Friend WithEvents lblxy As Label
    Friend WithEvents lblVar As Label
End Class

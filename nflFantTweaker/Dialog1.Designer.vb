<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.btnExcelOnly = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnExcelPlusScoring = New System.Windows.Forms.Button()
        Me.Player_StatsTableAdapter = New WindowsApplication1.PlayerStatsDataSetTableAdapters.Player_StatsTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExcelOnly
        '
        Me.btnExcelOnly.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExcelOnly.AutoSize = True
        Me.btnExcelOnly.Location = New System.Drawing.Point(14, 16)
        Me.btnExcelOnly.Name = "btnExcelOnly"
        Me.btnExcelOnly.Size = New System.Drawing.Size(192, 23)
        Me.btnExcelOnly.TabIndex = 0
        Me.btnExcelOnly.Text = "Excel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Load just the Excel file or Excel and scoring file?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnExcelPlusScoring, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExcelOnly, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(435, 55)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnExcelPlusScoring
        '
        Me.btnExcelPlusScoring.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExcelPlusScoring.AutoSize = True
        Me.btnExcelPlusScoring.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExcelPlusScoring.Location = New System.Drawing.Point(233, 16)
        Me.btnExcelPlusScoring.Name = "btnExcelPlusScoring"
        Me.btnExcelPlusScoring.Size = New System.Drawing.Size(188, 23)
        Me.btnExcelPlusScoring.TabIndex = 1
        Me.btnExcelPlusScoring.Text = "CSV"
        '
        'Player_StatsTableAdapter
        '
        Me.Player_StatsTableAdapter.ClearBeforeFill = True
        '
        'Dialog1
        '
        Me.AcceptButton = Me.btnExcelOnly
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExcelPlusScoring
        Me.ClientSize = New System.Drawing.Size(435, 110)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExcelOnly As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnExcelPlusScoring As Button
    Friend WithEvents Player_StatsTableAdapter As PlayerStatsDataSetTableAdapters.Player_StatsTableAdapter
End Class

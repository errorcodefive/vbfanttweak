<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PlayerStatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerStatsDataSet = New WindowsApplication1.PlayerStatsDataSet()
        Me.dataPlayer = New System.Windows.Forms.DataGridView()
        Me.btnToCSV = New System.Windows.Forms.Button()
        Me.btnGraph = New System.Windows.Forms.Button()
        CType(Me.PlayerStatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayerStatsBindingSource
        '
        Me.PlayerStatsBindingSource.DataMember = "Player Stats"
        Me.PlayerStatsBindingSource.DataSource = Me.PlayerStatsDataSet
        '
        'PlayerStatsDataSet
        '
        Me.PlayerStatsDataSet.DataSetName = "PlayerStatsDataSet"
        Me.PlayerStatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dataPlayer
        '
        Me.dataPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataPlayer.Location = New System.Drawing.Point(13, 13)
        Me.dataPlayer.Name = "dataPlayer"
        Me.dataPlayer.Size = New System.Drawing.Size(865, 444)
        Me.dataPlayer.TabIndex = 0
        '
        'btnToCSV
        '
        Me.btnToCSV.Location = New System.Drawing.Point(11, 479)
        Me.btnToCSV.Name = "btnToCSV"
        Me.btnToCSV.Size = New System.Drawing.Size(237, 30)
        Me.btnToCSV.TabIndex = 1
        Me.btnToCSV.Text = "Save to CSV"
        Me.btnToCSV.UseVisualStyleBackColor = True
        '
        'btnGraph
        '
        Me.btnGraph.Location = New System.Drawing.Point(342, 479)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(237, 30)
        Me.btnGraph.TabIndex = 2
        Me.btnGraph.Text = "Graphing and Scoring System"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 528)
        Me.Controls.Add(Me.btnGraph)
        Me.Controls.Add(Me.btnToCSV)
        Me.Controls.Add(Me.dataPlayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PlayerStatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayerStatsBindingSource As BindingSource
    Friend WithEvents PlayerStatsDataSet As PlayerStatsDataSet
    Friend WithEvents dataPlayer As DataGridView
    Friend WithEvents btnToCSV As Button
    Friend WithEvents btnGraph As Button
End Class

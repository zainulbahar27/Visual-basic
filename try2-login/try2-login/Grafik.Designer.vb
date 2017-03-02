<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafik
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Grafik_laporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Grafik_laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grafik_laporan
        '
        ChartArea1.Name = "ChartArea1"
        Me.Grafik_laporan.ChartAreas.Add(ChartArea1)
        Me.Grafik_laporan.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Grafik_laporan.Legends.Add(Legend1)
        Me.Grafik_laporan.Location = New System.Drawing.Point(0, 0)
        Me.Grafik_laporan.Name = "Grafik_laporan"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Grafik_laporan.Series.Add(Series1)
        Me.Grafik_laporan.Size = New System.Drawing.Size(811, 399)
        Me.Grafik_laporan.TabIndex = 0
        Me.Grafik_laporan.Text = "Chart1"
        '
        'Grafik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 399)
        Me.Controls.Add(Me.Grafik_laporan)
        Me.Name = "Grafik"
        Me.Text = "Grafik"
        CType(Me.Grafik_laporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grafik_laporan As System.Windows.Forms.DataVisualization.Charting.Chart
End Class

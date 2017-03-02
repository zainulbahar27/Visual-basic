Imports System.Windows.Forms.DataVisualization.Charting

Public Class Grafik
    Private Sub Grafik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grafik_laporan.Series.Clear()
        Grafik_laporan.Titles.Add("Laporan " & Mid(ldgv.Columns(2).HeaderText, 15))
        'Create a new series and add data points to it.
        Dim s As New Series
        Dim s1 As New Series
        Dim s3 As New Series
        Dim s9 As New Series
        s.Name = "Jumlah Pemesanan"
        s1.Name = "Smoothing alpha = 0,1"
        s3.Name = "Smoothing alpha = 0,3"
        s9.Name = "Smoothing alpha = 0,9"
        'Change to a line graph.
        s.ChartType = SeriesChartType.Line
        s1.ChartType = SeriesChartType.Line
        s3.ChartType = SeriesChartType.Line
        s9.ChartType = SeriesChartType.Line
        Dim skrg = False
        For i = 0 To ldgv.RowCount - 1
            s.Points.AddXY(i + 1, ldgv.Rows(i).Cells(2).Value)
            s1.Points.AddXY(i + 1, ldgv.Rows(i).Cells(3).Value)
            s3.Points.AddXY(i + 1, ldgv.Rows(i).Cells(4).Value)
            s9.Points.AddXY(i + 1, ldgv.Rows(i).Cells(5).Value)
        Next
        'Add the series to the Chart1 control.
        Grafik_laporan.Series.Add(s)
        Grafik_laporan.Series.Add(s1)
        Grafik_laporan.Series.Add(s3)
        Grafik_laporan.Series.Add(s9)
    End Sub
End Class
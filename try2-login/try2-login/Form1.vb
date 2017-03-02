Imports System.Drawing.Printing
Public Class Form1
    Dim statusLapangan1(18) As Label
    Dim statusLapangan2(18) As Label
    Dim lstLinesToPrint As New List(Of String)
    Dim tahunAktif = DateTime.Now.Year
    Dim timeOpen = 6
    Dim timeClose = 24


    Public Shared Function NotNull(Of T)(ByVal Value As T, Optional ByVal DefaultValue As T = Nothing) As T
        If Value Is Nothing OrElse IsDBNull(Value) Then
            Return DefaultValue
        Else
            Return Value
        End If
    End Function
    'Tab home
    'Ubah Passowrd
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        pass.Show()
        Me.Close()

    End Sub
    'logout
    Private Sub ex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ex.Click

        login.Show()
        Me.Close()

    End Sub

    'Tab Mamber
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        'TODO: This line of code loads data into the 'RRIdbDataSet.Data' table. You can move, or remove it, as needed.
        Me.DataTableAdapter.Fill(Me.RRIdbDataSet.Data)
        'TODO: This line of code loads data into the 'RRIdbDataSet.Mamber' table. You can move, or remove it, as needed.
        Me.MamberTableAdapter1.Fill(Me.RRIdbDataSet.Mamber)
        'TODO: This line of code loads data into the 'RRIdbDataSet.Pemesanan' table. You can move, or remove it, as needed.
        Me.PemesananTableAdapter1.Fill(Me.RRIdbDataSet.Pemesanan)
        'TODO: This line of code loads data into the 'LogdbDataSet.Harga' table. You can move, or remove it, as needed.
        Me.HargaTableAdapter1.Fill(Me.RRIdbDataSet.Harga)
        'TODO: This line of code loads data into the 'LogdbDataSet.Mamber' table. You can move, or remove it, as needed.
        Me.MamberTableAdapter1.Fill(Me.RRIdbDataSet.Mamber)
        Me.asli()
        Me.aslip()
        Dim color() As String = [Enum].GetNames(GetType(KnownColor))
        initializeLaporan()
        JamMulai.DataSource = TimeSource()
        JamSelesai.DataSource = TimeSource()
        Me.initializeStatusLapangan()
        loadjadwal(1)
        loadjadwal(2)
        idMember.Enabled = False
        boxLapangan.DataSource = {1, 2}
        If dgv_pemesanan.RowCount > 0 Then
            dgv_pemesanan.CurrentCell = dgv_pemesanan.Rows(dgv_pemesanan.RowCount - 1).Cells(0)
        End If
        Me.Text = "RRI Soccer Center Information System"
    End Sub

    Private Function TimeSource() As List(Of Integer)
        Dim times As New List(Of Integer)
        Dim timeOpen = 6
        Dim timeClose = 24
        For i = timeOpen To timeClose - 1
            times.Add(i)
        Next
        Return times
    End Function

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error GoTo ErrSave
        MamberBindingSource1.EndEdit()
        MamberTableAdapter1.Update(RRIdbDataSet.Mamber)
        MamberTableAdapter1.Fill(RRIdbDataSet.Mamber)
        MessageBox.Show("Data telah tersimpan")

ErrExit:
        Exit Sub
ErrSave:
        MsgBox("Error number" & Err.Number & vbNewLine & "Eror Description" & Err.Description, MsgBoxStyle.Critical, "reset eror !")
        Resume ErrExit
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MamberBindingSource1.AddNew()
        MessageBox.Show("Silahkan Isikan data member yang akan mendaftar dan tekan simpan jika sudah selesai")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error GoTo Errmov
        MamberBindingSource1.MovePrevious()
ErrExit:
        Exit Sub
Errmov:
        MsgBox("Error number" & Err.Number & vbNewLine & "Eror Description" & Err.Description, MsgBoxStyle.Critical, "reset eror !")
        Resume ErrExit
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim msg As String = " Anda Yakin ingin menghapus ?"
        Dim title As String = "Verifikasi penghapusan"
        Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim icon As MessageBoxIcon = MessageBoxIcon.Question
        Dim result As DialogResult = MessageBox.Show(msg, title, button, icon, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            MamberBindingSource1.RemoveCurrent()
            MessageBox.Show("Data member terhapus")
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error GoTo Errmov
        MamberBindingSource1.MoveNext()
ErrExit:
        Exit Sub
Errmov:
        MsgBox("Error number" & Err.Number & vbNewLine & "Eror Description" & Err.Description, MsgBoxStyle.Critical, "reset eror !")
        Resume ErrExit

    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error GoTo srcherr
        If TextBox8.Text = "" Then
            TextBox8.BackColor = Color.White
            MamberBindingSource1.Filter = Nothing
            Me.asli()
            Exit Sub

        Else
            Dim datacari As String = TextBox8.Text
            MamberBindingSource1.Filter = "(Convert(ID_mamber, 'System.String') LIKE '" & TextBox8.Text & "')" & _
            "OR (Nama LIKE '" & TextBox8.Text & "')"

            If MamberBindingSource1.Count <> 0 Then
                TextBox8.BackColor = Color.SpringGreen
                With dgv_member
                    .DataSource = MamberBindingSource1
                    .RowsDefaultCellStyle.BackColor = Drawing.Color.SpringGreen
                    .AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.LightGreen
                End With
            Else
                TextBox8.BackColor = Color.Red
                MsgBox("-->>>" & datacari & " Tidak ada data yang di cari", MsgBoxStyle.Information, "Informasion")
                MamberBindingSource1.Filter = Nothing
                Me.asli()
            End If
        End If
errexit:
        Exit Sub
srcherr:
        MsgBox("eror number" & Err.Number & vbNewLine & "Eror Description" & Err.Description, MsgBoxStyle.Critical, "reset eror !")
        Resume errexit


    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub asli()
        If dgv_member.DataSource Is Nothing Then
            Exit Sub
        End If
        With dgv_member
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = MamberBindingSource1
            .RowsDefaultCellStyle.BackColor = Drawing.Color.Yellow
            .AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.LightYellow
        End With
    End Sub

    'lain lain
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        idMember.Text = "yes"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        idMember.Text = "no"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        jam.Text = TimeOfDay
        jam2.Text = TimeOfDay
    End Sub

    Private Function checkTersedia(ByVal noLapangan As Integer, ByVal jam As Integer, ByVal tglSewa As DateTime) As Boolean
        Dim data = PemesananTableAdapter1.GetData()
        Dim pesanData As New BindingSource
        pesanData.DataSource = data
        pesanData.Filter = "ID_Lapangan = " & Str(noLapangan) & " and Tanggal_Sewa >= #" &
            tglSewa.Date.ToString("MM/dd/yyyy") & " 00:00:00# and Tanggal_Sewa <= #" &
            tglSewa.Date.ToString("MM/dd/yyyy") & " 23:59:59#"
        If pesanData.Count <> 0 Then
            For i = 0 To pesanData.Count - 1
                For j = pesanData.Current("Jam_Mulai") To pesanData.Current("Jam_Selesai") - 1
                    If jam = j Then
                        Return False
                    End If
                Next
                pesanData.MoveNext()
            Next
        End If
        pesanData.RemoveFilter()
        Return True
    End Function

    'Tab lapangan

    Private Sub initializeStatusLapangan()
        initializeStatusLapangan1()
        initializeStatusLapangan2()
    End Sub

    Private Sub initializeStatusLapangan1()
        For i = 0 To statusLapangan1.GetLength(0) - 1
            statusLapangan1(i) = New Label
        Next
        statusLapangan1(0) = LStatus1
        statusLapangan1(1) = LStatus2
        statusLapangan1(2) = LStatus3
        statusLapangan1(3) = LStatus4
        statusLapangan1(4) = LStatus5
        statusLapangan1(5) = LStatus6
        statusLapangan1(6) = LStatus7
        statusLapangan1(7) = LStatus8
        statusLapangan1(8) = LStatus9
        statusLapangan1(9) = LStatus10
        statusLapangan1(10) = LStatus11
        statusLapangan1(11) = LStatus12
        statusLapangan1(12) = LStatus13
        statusLapangan1(13) = LStatus14
        statusLapangan1(14) = LStatus15
        statusLapangan1(15) = LStatus16
        statusLapangan1(16) = LStatus17
        statusLapangan1(17) = LStatus18
        For i = 0 To statusLapangan1.GetLength(0) - 1
            statusLapangan1(i).Text = "Kosong"
            statusLapangan1(i).ForeColor = Color.Green
        Next
    End Sub

    Private Sub initializeStatusLapangan2()
        For i = 0 To statusLapangan2.GetLength(0) - 1
            statusLapangan2(i) = New Label
        Next
        statusLapangan2(0) = Status1
        statusLapangan2(1) = Status2
        statusLapangan2(2) = Status3
        statusLapangan2(3) = Status4
        statusLapangan2(4) = Status5
        statusLapangan2(5) = Status6
        statusLapangan2(6) = Status7
        statusLapangan2(7) = Status8
        statusLapangan2(8) = Status9
        statusLapangan2(9) = Status10
        statusLapangan2(10) = Status11
        statusLapangan2(11) = Status12
        statusLapangan2(12) = Status13
        statusLapangan2(13) = Status14
        statusLapangan2(14) = Status15
        statusLapangan2(15) = Status16
        statusLapangan2(16) = Status17
        statusLapangan2(17) = Status18
        For i = 0 To statusLapangan2.GetLength(0) - 1
            statusLapangan2(i).Text = "Kosong"
            statusLapangan2(i).ForeColor = Color.Green
        Next
    End Sub

    Private Sub loadjadwal(ByVal noLapangan As Integer)
        Dim data = PemesananTableAdapter1.GetData()
        Dim pesanData As New BindingSource
        pesanData.DataSource = data
        Dim index = -1
        Dim last As Integer
        Dim statusLapangan() As Label
        Dim dtp_lapangan As DateTimePicker
        If noLapangan = 1 Then
            statusLapangan = statusLapangan1
            dtp_lapangan = dtp_lapangan1
        Else
            statusLapangan = statusLapangan2
            dtp_lapangan = dtp_lapangan2
        End If
        pesanData.Filter = "ID_Lapangan = " & Str(noLapangan) & " and Tanggal_Sewa >= #" &
            dtp_lapangan.Value.Date.ToString("MM/dd/yyyy") & " 00:00:00# and Tanggal_Sewa <= #" &
            dtp_lapangan.Value.Date.ToString("MM/dd/yyyy") & " 23:59:59#"
        If pesanData.Count <> 0 Then
            For i = 6 To statusLapangan.GetLength(0) + 5
                index = -1
                index = pesanData.Find("Jam_Mulai", i)
                If index >= 0 Then
                    pesanData.Position = index
                    last = pesanData.Current("Jam_Selesai")
                    If pesanData.Current("Status") <> "BATAL" Then
                        For j = i To last - 1
                            statusLapangan(j - 6).Text = "Sudah Dipesan"
                            statusLapangan(j - 6).ForeColor = Color.Red
                        Next
                        i = last - 1
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub loadJadwal1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_lapangan1.ValueChanged
        initializeStatusLapangan1()
        loadjadwal(1)
    End Sub

    Private Sub loadJadwal2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_lapangan2.ValueChanged
        initializeStatusLapangan2()
        loadjadwal(2)
    End Sub

    Private Function getSqlDate(ByVal dateVal As DateTime)
        Dim Year = Str(dateVal.Year)
        Dim Month = If(dateVal.Month < 10, "0" & Str(dateVal.Month), Str(dateVal.Month))
        Dim Day = If(dateVal.Day < 10, "0" & Str(dateVal.Day), Str(dateVal.Day))
        Return "#" + Day + "-" + Month + "-" + Year + "#"
    End Function

    'Tab Pemesanan
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles idMember.Leave
        Try
            If Not IsDBNull(dgv_member) Then
                If Not (idMember.Text = "") Then
                    For i = 0 To dgv_member.RowCount - 1
                        If idMember.Text = dgv_member.Rows(i).Cells(0).Value Then
                            Nama_pemesan.Text = dgv_member.Rows(i).Cells(1).Value
                            No_HP.Text = dgv_member.Rows(i).Cells(2).Value
                            Nama_pemesan.Enabled = False
                            No_HP.Enabled = False
                            Exit For
                        End If
                    Next
                Else
                    Nama_pemesan.Enabled = True
                    No_HP.Enabled = True
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tambah.Click
        PemesananBindingSource1.AddNew()
        Nama_pemesan.Enabled = True
        No_HP.Enabled = True
    End Sub

    Private Sub Button13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try
            Dim muka = Convert.ToInt32(UangMuka.Text)
            Dim harga = hitungHarga()
            If harga - muka > 0 Then
                Status_bayar.Text = "BELUM LUNAS"
            Else
                Status_bayar.Text = "LUNAS"
            End If
            PemesananBindingSource1.EndEdit()
            PemesananTableAdapter1.Update(RRIdbDataSet.Pemesanan)
            PemesananTableAdapter1.Fill(RRIdbDataSet.Pemesanan)
            MessageBox.Show("Data telah tersimpan")
            dgv_pemesanan.CurrentCell = dgv_pemesanan.Rows(dgv_pemesanan.RowCount - 2).Cells(0)
        Catch ex As FormatException
            MsgBox("Ada isian yang masih kosong", MsgBoxStyle.Critical, "Pemesanan Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Pemesanan Error")
        End Try
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PemesananBindingSource1.MovePrevious()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PemesananBindingSource1.MoveNext()
    End Sub

    Private Function hitungHarga() As Integer
        Dim hargaTable As RRIdbDataSet.HargaDataTable
        hargaTable = HargaTableAdapter1.GetData()
        Dim Mulai = JamMulai.SelectedValue
        Dim Selesai = JamSelesai.SelectedValue
        Dim Harga As New Decimal()
        For i = Mulai To Selesai - 1
            If checkTersedia(boxLapangan.SelectedValue, i, TglSewa.Value) Then
                If i >= hargaTable.Rows(1).Item(1) Then
                    If idMember.Text = Nothing Then
                        Harga += hargaTable.Rows(1).Item(2)
                    Else
                        Harga += 3 * hargaTable.Rows(1).Item(2) / 4
                    End If

                Else
                    Harga += hargaTable.Rows(0).Item(2)
                End If
            Else
                Throw New Exception("Jam tersebut tidak tersedia")
            End If
        Next
        Tagihan.Text = Str(Harga)
        Return Harga
    End Function

    Private Function hitungHarga(sender As System.Object, e As System.EventArgs) As Boolean Handles Hitung.Click
        Dim harga = hitungHarga()
        MsgBox(Tagihan.Text, , "Harga Sewa")
        Return harga
    End Function

    Private Sub Pelunasan_Click(sender As System.Object, e As System.EventArgs) Handles Pelunasan.Click
        Try
            Dim Sisa = Convert.ToInt32(Tagihan.Text) - Convert.ToInt32(UangMuka.Text)
            If Status_bayar.Text = "BELUM LUNAS" Then
                Dim pressed = MsgBox("Konfirmasi Pelunasan" & vbNewLine & "Sisa pembayaran = Rp." + Str(Sisa), 1, "Konfirmasi Pelunasan")
                If pressed = vbOK Then
                    Status_bayar.Text = "LUNAS"
                    PemesananBindingSource1.EndEdit()
                    PemesananTableAdapter1.Update(RRIdbDataSet.Pemesanan)
                End If
            End If
        Catch
            MsgBox("Mohon Refresh terlebih dahulu", MsgBoxStyle.Critical, "Pelunanasan Error!")
        End Try
    End Sub

    Private Sub Batal_Click(sender As System.Object, e As System.EventArgs) Handles Batal.Click
        Try
            If Status_bayar.Text = "BELUM LUNAS" Then
                Dim pressed = MsgBox("Konfirmasi Pembatalan" & vbNewLine & "DP tidak dapat dikembalikan", 1, "Konfirmasi Pembatalan")
                If pressed = vbOK Then
                    Status_bayar.Text = "BATAL"
                    Tagihan.Text = UangMuka.Text
                    PemesananBindingSource1.EndEdit()
                    PemesananTableAdapter1.Update(RRIdbDataSet.Pemesanan)
                End If
            End If
        Catch ex As Exception
            MsgBox("Mohon Refresh terlebih dahulu", MsgBoxStyle.Critical, "Pembatalan Error!")
        End Try
    End Sub

    Private Sub Refresh_Click(sender As System.Object, e As System.EventArgs) Handles RefreshPesanan.Click
        dgv_pemesanan.DataSource = PemesananTableAdapter1.GetData()
        dgv_pemesanan.CurrentCell = dgv_pemesanan.Rows(dgv_pemesanan.RowCount - 1).Cells(0)
    End Sub

    'Tab Laporan

    Private Sub initializeLaporan()
        Dim tahunawal As New Date(tahunAktif, 1, 1)
        Dim tahunakhir As New Date(tahunAktif, 12, 31)
        Dim jamawal = 6
        Dim jamakhir = 15
        Dim harga = "Jml Pemesanan Rp.50000/jam"
        Tahun.Text = Str(tahunAktif)
        If Radio_sore.Checked Then
            jamawal = 15
            jamakhir = 24
            harga = "Jml Pemesanan Rp.100000/jam"
        End If
        Me.LaporanTableAdapter.FillBy(Me.RRIdbDataSet.Laporan, tahunawal, tahunakhir, jamawal, jamakhir)
        If qdgv.RowCount <> 0 Then
            qdgv.Columns(2).HeaderText = harga
            HitungSmoothing()
        End If
    End Sub

    Private Sub Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prev_btn.Click
        tahunAktif = tahunAktif - 1
        initializeLaporan()
    End Sub

    Private Sub Next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Next_btn.Click
        tahunAktif = tahunAktif + 1
        initializeLaporan()
    End Sub

    Private Sub Radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_pagi.CheckedChanged, Radio_sore.CheckedChanged
        initializeLaporan()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tampil_grafik.Click
        Try
            Grafik.Show()
        Catch ex As Exception
            MsgBox("Mohon klik Smoothing Terlebih Dahulu")
        End Try
    End Sub

    Private Sub HitungSmoothing()
        Dim Average As New Double()
        'Single Exponential Smoothing
        Dim total(3, 2) As ULong
        For i = 0 To qdgv.RowCount - 1
            If Not IsNothing(qdgv.Rows(i).Cells(2).Value) Then
                If i = 0 OrElse IsDBNull(qdgv.Rows(i - 1).Cells(2).Value) Then
                    For j = 3 To 5
                        qdgv.Rows(i).Cells(j).Value = qdgv.Rows(i).Cells(2).Value
                    Next
                Else
                    If Not IsDBNull(qdgv.Rows(i - 1).Cells(2).Value) Then
                        qdgv.Rows(i).Cells(3).Value = 0.1 * NotNull(qdgv.Rows(i - 1).Cells(2).Value) + 0.9 * NotNull(qdgv.Rows(i - 1).Cells(3).Value)
                        qdgv.Rows(i).Cells(4).Value = 0.5 * NotNull(qdgv.Rows(i - 1).Cells(2).Value) + 0.5 * NotNull(qdgv.Rows(i - 1).Cells(4).Value)
                        qdgv.Rows(i).Cells(5).Value = 0.9 * NotNull(qdgv.Rows(i - 1).Cells(2).Value) + 0.1 * NotNull(qdgv.Rows(i - 1).Cells(5).Value)
                    End If
                    If Not IsDBNull(qdgv.Rows(i - 1).Cells(2).Value) Then
                        qdgv.Rows(i - 1).Cells(6).Value = NotNull(qdgv.Rows(i - 1).Cells(3).Value) - NotNull(qdgv.Rows(i - 1).Cells(2).Value)
                        qdgv.Rows(i - 1).Cells(7).Value = NotNull(qdgv.Rows(i - 1).Cells(4).Value) - NotNull(qdgv.Rows(i - 1).Cells(2).Value)
                        qdgv.Rows(i - 1).Cells(8).Value = NotNull(qdgv.Rows(i - 1).Cells(5).Value) - NotNull(qdgv.Rows(i - 1).Cells(2).Value)
                        qdgv.Rows(i - 1).Cells(9).Value = NotNull(qdgv.Rows(i - 1).Cells(6).Value) * NotNull(qdgv.Rows(i - 1).Cells(6).Value)
                        qdgv.Rows(i - 1).Cells(10).Value = NotNull(qdgv.Rows(i - 1).Cells(7).Value) * NotNull(qdgv.Rows(i - 1).Cells(7).Value)
                        qdgv.Rows(i - 1).Cells(11).Value = NotNull(qdgv.Rows(i - 1).Cells(8).Value) * NotNull(qdgv.Rows(i - 1).Cells(8).Value)
                        total(0, 0) += qdgv.Rows(i - 1).Cells(9).Value
                        total(1, 0) += qdgv.Rows(i - 1).Cells(10).Value
                        total(2, 0) += qdgv.Rows(i - 1).Cells(11).Value
                        total(0, 1) += 1
                        total(1, 1) += 1
                        total(2, 1) += 1
                    End If
                End If
            End If
        Next
        Dim table As New DataTable
        table.Columns.Add("Kolom", GetType(String))
        table.Columns.Add("Kuadrat Selisih 0.1", GetType(ULong))
        table.Columns.Add("Kuadrat Selisih 0.5", GetType(ULong))
        table.Columns.Add("Kuadrat Selisih 0.9", GetType(ULong))
        table.Rows.Add("Jumlah", 0, 0, 0)
        table.Rows.Add("Pengujian", 0, 0, 0)
        table.Rows.Add("MSES", 0, 0, 0)
        For i = 1 To 3
            table.Rows(0).Item(i) = total(i - 1, 0)
        Next
        For i = 1 To 3
            table.Rows(1).Item(i) = total(i - 1, 1)
        Next
        For i = 1 To 3
            table.Rows(2).Item(i) = table.Rows(0).Item(i) / table.Rows(1).Item(i)
        Next
        dgv_ringkasan.DataSource = table
        ldgv = qdgv
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Smoothing.Click
        HitungSmoothing()
    End Sub

    Private Sub Button17_Click_1(sender As System.Object, e As System.EventArgs) Handles RefreshDB.Click
        LaporanTableAdapter.Fill(Me.RRIdbDataSet.Laporan)
    End Sub

    Private Sub enableMember_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles enableMember.CheckedChanged
        If enableMember.Checked Then
            idMember.Enabled = True
        Else
            idMember.Enabled = False
        End If
    End Sub

    Private Sub PrintPreviewDialog_Load(sender As System.Object, e As System.EventArgs) Handles PrintPreviewDialog.Load

    End Sub

    Private Sub PrintDoc_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles PrintDoc.BeginPrint

        '-- Get our lines to print first
        Dim fntText As Font = txtFile.Font
        Dim txtWidth As Integer = PrintDoc.DefaultPageSettings.PaperSize.Width - PrintDoc.DefaultPageSettings.Margins.Left - PrintDoc.DefaultPageSettings.Margins.Right
        Dim stringSize As New SizeF
        Dim g = Me.CreateGraphics

        '-- Make sure we are starting with a new list
        lstLinesToPrint.Clear()

        '-- Loop thru the lines in the text box and break them down to fit in the printable area.
        For intCounter = 0 To txtFile.Lines.Count - 1
            '-- Get the width of the string
            stringSize = g.MeasureString(txtFile.Lines(intCounter), fntText)

            If stringSize.Width < txtWidth Then
                '-- This line will print nothing needs to be done
                lstLinesToPrint.Add(txtFile.Lines(intCounter))
            Else
                '-- This line is too long break it up
                Dim strWords() As String = txtFile.Lines(intCounter).Split(" ")
                Dim strMeasure As String = ""
                Dim intMaxWords As Integer = 0
                Dim intStartPoint As Integer = 0
                Dim sfBuffer As SizeF = g.MeasureString("MMMMMM", fntText)

                '-- Now see how many words we can put on this line.
                For count = 0 To strWords.Length - 1

                    strMeasure += strWords(count) + " "
                    stringSize = g.MeasureString(strMeasure, fntText)
                    '-- Keep adding words till they excedd the limit.
                    If stringSize.Width > txtWidth - sfBuffer.Width Then
                        '-- Now the line is one word to long so remove it. 
                        intMaxWords = count - 1
                        strMeasure = ""
                        For i = intStartPoint To intMaxWords
                            strMeasure += strWords(i) + " "
                        Next
                        '-- Do add here
                        lstLinesToPrint.Add(strMeasure)
                        strMeasure = ""
                        intStartPoint = intMaxWords + 1
                    End If

                    '-- Now  add the remain part of the line to the list
                    If count = strWords.Length - 1 Then
                        strMeasure = ""
                        For i = intMaxWords + 1 To strWords.Count - 1
                            strMeasure += strWords(i) + " "
                        Next
                        '-- Do add here
                        lstLinesToPrint.Add(strMeasure)
                        strMeasure = ""
                    End If

                Next
            End If

        Next

    End Sub


    

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        If NamaTextBox.Text <> "" Then
            BindingNavigator1.Enabled = True
        End If
        txtFile.Text = "-------------- RRI Soccer Center -------------" & vbNewLine + _
                        "##############################################" & vbNewLine & vbNewLine + _
                        "|  ID            : " & ID_PemesananTextBox.Text & vbNewLine + _
                        "|  Nama          : " & NamaTextBox.Text & vbNewLine + _
                        "|  ID Member     : " & ID_MamberTextBox.Text & vbNewLine +
                        "|  Lapangan      : " & ID_LapanganTextBox.Text & vbNewLine + _
                        "|  Jam mulai     : " & Jam_MulaiTextBox.Text & vbNewLine + _
                        "|  Jam selesai   : " & Jam_SelesaiTextBox.Text & vbNewLine + _
                        "|  tanggal pesan : " & Tanggal_PesanDateTimePicker.Text & vbNewLine + _
                        "|  tanggal sewa  : " & Tanggal_SewaDateTimePicker.Text & vbNewLine + _
                        "|  uang muka     : " & DPTextBox.Text & vbNewLine + _
                        "|  Tagihan       : " & TagihanTextBox.Text & vbNewLine + _
                        "|  No Hp         : " & No_HPTextBox.Text & vbNewLine +
                        "|  status        : " & StatusTextBox.Text & vbNewLine + _
                        "|  ___________________________________________"
        '-- Set the PrintDialog Printer settings to the Print Document Settings

        PrintDialog.PrinterSettings = PrintDoc.PrinterSettings

        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '-- Now set the Print Document to what the dialog setting that were selected
            PrintDoc.PrinterSettings = PrintDialog.PrinterSettings

            '-- We can have a Page Settings dialog or we can hard code it for this example lets hard code it.
            Dim PageSetUp As New PageSettings
            '-- The default coordinate system of the page is 1/100 of an inch.
            With PageSetUp
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
                .Landscape = False
            End With
            PrintDoc.DefaultPageSettings = PageSetUp
            PrintPreviewDialog.Document = PrintDoc
            PrintDoc.Print()
        End If

        '-- Because it's a video we will print the preview window if we are printing for real we only have to call 
        '-- PrintDoc.Print method




    End Sub
    Private Sub PrintDoc_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Static intStart As Integer

        Dim fntText As Font = txtFile.Font

        Dim txtHeight As Integer
        '-- Just short hand variables
        Dim LeftMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Left
        Dim TopMargin As Integer = PrintDoc.DefaultPageSettings.Margins.Top
        '-- Get the printable area
        txtHeight = PrintDoc.DefaultPageSettings.PaperSize.Height - PrintDoc.DefaultPageSettings.Margins.Top - PrintDoc.DefaultPageSettings.Margins.Bottom

        '-- Calculate the number of lines per page .25 is just a buffer spacing need to remove the hard coding later and fix it to the font.
        Dim LinesPerPage As Integer = CInt(Math.Round(txtHeight / (fntText.Height + 0.25)))

        Dim intLineNumber As Integer = 0

        '-- Draw a border around the printable area.
        e.Graphics.DrawRectangle(Pens.Red, e.MarginBounds)

        '-- Loop thru the lines in the list and print them out
        For intCounter = intStart To lstLinesToPrint.Count - 1
            e.Graphics.DrawString(lstLinesToPrint(intCounter), fntText, Brushes.Black, LeftMargin, (fntText.Height * intLineNumber) + TopMargin)
            intLineNumber += 1

            If intLineNumber > LinesPerPage - 1 Then
                '-- Start where we left off.
                intStart = intCounter
                e.HasMorePages = True
                Exit For
            End If
        Next


    End Sub

    Private Sub preview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles preview.Click
        If NamaTextBox.Text <> "" Then
            BindingNavigator1.Enabled = True
        End If
        txtFile.Text = "-------------- RRI Soccer Center -------------" & vbNewLine + _
                        "##############################################" & vbNewLine & vbNewLine + _
                        "|  ID            : " & ID_PemesananTextBox.Text & vbNewLine + _
                        "|  Nama          : " & NamaTextBox.Text & vbNewLine + _
                        "|  ID Member     : " & ID_MamberTextBox.Text & vbNewLine +
                        "|  Lapangan      : " & ID_LapanganTextBox.Text & vbNewLine + _
                        "|  Jam mulai     : " & Jam_MulaiTextBox.Text & vbNewLine + _
                        "|  Jam selesai   : " & Jam_SelesaiTextBox.Text & vbNewLine + _
                        "|  tanggal pesan : " & Tanggal_PesanDateTimePicker.Text & vbNewLine + _
                        "|  tanggal sewa  : " & Tanggal_SewaDateTimePicker.Text & vbNewLine + _
                        "|  uang muka     : " & DPTextBox.Text & vbNewLine + _
                        "|  Tagihan       : " & TagihanTextBox.Text & vbNewLine + _
                        "|  No Hp         : " & No_HPTextBox.Text & vbNewLine +
                        "|  status        : " & StatusTextBox.Text & vbNewLine + _
                        "|  ___________________________________________"

        PrintPreviewDialog.Document = PrintDoc
        PrintPreviewDialog.ShowDialog()
    End Sub
    Private Sub aslip()
        If dgv_pemesanan.DataSource Is Nothing Then
            Exit Sub
        End If
        With dgv_pemesanan
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = PemesananBindingSource1
            .RowsDefaultCellStyle.BackColor = Drawing.Color.Yellow
            .AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.LightYellow
        End With
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        On Error GoTo srcherr
        If TextBox5.Text = "" Then
            TextBox5.BackColor = Color.White
            PemesananBindingSource1.Filter = Nothing
            Me.aslip()
            Exit Sub

        Else
            Dim datacari As String = TextBox5.Text
            PemesananBindingSource1.Filter = "(Convert(ID_Pemesanan, 'System.String') LIKE '" & TextBox5.Text & "')" & _
            "OR (Nama LIKE '" & TextBox5.Text & "')"

            If PemesananBindingSource1.Count <> 0 Then
                TextBox5.BackColor = Color.SpringGreen
                With dgv_pemesanan
                    .DataSource = PemesananBindingSource1
                    .RowsDefaultCellStyle.BackColor = Drawing.Color.SpringGreen
                    .AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.LightGreen
                End With
            Else
                TextBox5.BackColor = Color.Red
                MsgBox("-->>>" & datacari & " Tidak ada data yang di cari", MsgBoxStyle.Information, "Informasion")
                PemesananBindingSource1.Filter = Nothing
                Me.aslip()
            End If
        End If
errexit:
        Exit Sub
srcherr:
        MsgBox("eror number" & Err.Number & vbNewLine & "Eror Description" & Err.Description, MsgBoxStyle.Critical, "reset eror !")
        Resume errexit
    End Sub


    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.TabControl1.SelectedTab = TabPage5
    End Sub

End Class
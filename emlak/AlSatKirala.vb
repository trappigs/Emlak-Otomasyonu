Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AlSatKirala
    Private Sub AlSatKirala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select CONCAT(adi, ' ', soyadi) as TamAd, kisi_tc from kisiler where kisi_tipi=N'Emlakçı'", "TamAd", "kisi_tc", "kisiler", emlakciComboBox)
        veriDoldur("select CONCAT(adi, ' ', soyadi) as TamAd, kisi_tc from kisiler where kisi_tipi=N'Müşteri'", "TamAd", "kisi_tc", "kisiler", aliciComboBox)
        veriDoldur("select CONCAT(adi, ' ', soyadi) as TamAd, kisi_tc from kisiler where kisi_tipi=N'Müşteri'", "TamAd", "kisi_tc", "kisiler", saticiComboBox)


    End Sub


    Dim connectionString As String = "Data Source=BU2-C-000WY\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"
    Dim connection As New SqlConnection(connectionString)

    Sub veriDoldur(query As String, adSutun As String, idSutun As String, tabloAdi As String, ByVal comboBox As ComboBox)
        ' ComboBox'ı doldurmak için kullanılacak SQL sorgusu

        ' Veritabanı bağlantısı oluştur
        Using connection As New SqlConnection(connectionString)
            ' Veri adaptörü oluştur
            Using adapter As New SqlDataAdapter(query, connection)
                ' DataSet oluştur
                Dim dataSet As New DataSet()

                ' Verileri doldur
                adapter.Fill(dataSet, tabloAdi)

                ' combobox'ı doldur
                comboBox.DisplayMember = adSutun ' Görüntülenecek değer
                comboBox.ValueMember = idSutun  ' Arkaplanda saklanacak değer
                comboBox.DataSource = dataSet.Tables(tabloAdi)
            End Using
        End Using

    End Sub


    Sub MySub(tablo_adi As String, emlak_tipi_id As String, alici_tc As String, satici_tc As String, emlak_id As String)
        Dim ss2 As String = "update adres set kisi_tc = " + alici_tc + " where " + alici_tc + " = " + satici_tc + "and " + emlak_tipi_id + " = " + emlak_id
        Dim ss As String = "update arsa set emlak_sahibi_tc = alici_tc where tc = satici_tc and arsa_id = selectedrow.arsa_id"




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'alıcıyla satıcı aynı olamaz!

        ' satis işlemi
        ' satis işlemi için alıcı ve satıcı farklı olmalı
        ' yapacağım şey şu: seçilmiş satırın id sini alıp, emlak sahibi tc lerini değiştirmek
        ' emlak sahibi tc leri değiştikten sonra, adres tablosundaki emlak sahibi tc leri değiştirmek


        If DataGridView1.Rows.Count > 0 And DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            If islem = "satis" Then
                If Not aliciComboBox.Text = saticiComboBox.Text Then
                    If isyeriRadioButton.Checked Then
                        sqlAlSatKira.Satis(aliciComboBox, saticiComboBox, emlakciComboBox, "isyeri", satis_ucreti.Text, selectedRow.Cells(0).ToString())
                    ElseIf arsaRadioButton.Checked Then
                        sqlAlSatKira.Satis(aliciComboBox, saticiComboBox, emlakciComboBox, "arsa", satis_ucreti.Text, selectedRow.Cells(0).ToString())
                    ElseIf konutRadioButton.Checked Then
                        sqlAlSatKira.Satis(aliciComboBox, saticiComboBox, emlakciComboBox, "konut", satis_ucreti.Text, selectedRow.Cells(0).ToString())
                    End If
                Else
                    MessageBox.Show("Alıcıyla satıcı aynı olamaz!")
                End If
            ElseIf islem = "kira" Then
                If Not aliciComboBox.Text = saticiComboBox.Text Then
                    If isyeriRadioButton.Checked Then
                        sqlAlSatKira.Kiralama(aliciComboBox, saticiComboBox, emlakciComboBox, "isyeri", kira_ucreti.Text, depozito_ucreti.Text, selectedRow.Cells(0).ToString())
                    ElseIf arsaRadioButton.Checked Then
                        sqlAlSatKira.Kiralama(aliciComboBox, saticiComboBox, emlakciComboBox, "arsa", kira_ucreti.Text, depozito_ucreti.Text, selectedRow.Cells(0).ToString())
                    ElseIf konutRadioButton.Checked Then
                        sqlAlSatKira.Kiralama(aliciComboBox, saticiComboBox, emlakciComboBox, "konut", kira_ucreti.Text, depozito_ucreti.Text, selectedRow.Cells(0).ToString())
                    End If
                Else
                    MessageBox.Show("Kiracıyla kiracı aynı olamaz!")
                End If
            Else
                MessageBox.Show("İşlem seçmediniz!")
            End If

        Else
            MessageBox.Show("Tabloda kayıt yok!")
        End If
    End Sub

    Dim islem As String

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'satış
        islem = "satis"
        If RadioButton2.Checked Then
            kira_ucreti.Enabled = False
            satis_ucreti.Enabled = True
            depozito_ucreti.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        'kiralama
        islem = "kira"
        If RadioButton3.Checked Then
            kira_ucreti.Enabled = True
            satis_ucreti.Enabled = False
            depozito_ucreti.Enabled = True
        End If
    End Sub


    Function KisiSorgula(tablo_adi As String, emlak_tipi_id As String) As DataTable
        Dim queryAlSat As String = "select * from " + tablo_adi + ", adres where adres.kisi_tc = " + tablo_adi + ".emlak_sahibi_tc and " + tablo_adi + "." + emlak_tipi_id + " = adres." + emlak_tipi_id

        Dim dtKisi As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Try
                Using commandKisi As New SqlCommand(queryAlSat, connection)
                    Using reader As SqlDataReader = commandKisi.ExecuteReader()
                        ' DataGridView'e sonuçları aktarın

                        dtKisi.Load(reader)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

        MessageBox.Show(queryAlSat)
        If dtKisi.Rows.Count > 0 Then
            Return dtKisi
        Else
            MessageBox.Show("Kayıt bulunamadı.")
            Return Nothing
        End If

    End Function

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles isyeriRadioButton.CheckedChanged
        DataGridView1.DataSource = Nothing
        If isyeriRadioButton.Checked Then
            DataGridView1.DataSource = KisiSorgula("isyeri", "isyeri_id")
            If DataGridView1.Columns(0).HeaderText = "arsa_id" Or DataGridView1.Columns(0).HeaderText = "konut_id" Then
                DataGridView1.Columns(0).Visible = False
            End If
            If DataGridView1.Columns(1).HeaderText = "arsa_id" Or DataGridView1.Columns(1).HeaderText = "konut_id" Then
                DataGridView1.Columns(1).Visible = False
            End If
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles arsaRadioButton.CheckedChanged
        DataGridView1.DataSource = Nothing
        If arsaRadioButton.Checked Then
            DataGridView1.DataSource = KisiSorgula("arsa", "arsa_id")
            If DataGridView1.Columns(0).HeaderText = "isyeri_id" Or DataGridView1.Columns(0).HeaderText = "konut_id" Then
                DataGridView1.Columns(0).Visible = False
            End If
            If DataGridView1.Columns(1).HeaderText = "isyeri_id" Or DataGridView1.Columns(1).HeaderText = "konut_id" Then
                DataGridView1.Columns(1).Visible = False
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles konutRadioButton.CheckedChanged
        If konutRadioButton.Checked Then
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = KisiSorgula("konutlar", "konut_id")
            If DataGridView1.Columns(0).HeaderText = "isyeri_id" Or DataGridView1.Columns(0).HeaderText = "arsa_id" Then
                DataGridView1.Columns(0).Visible = False
            End If
            If DataGridView1.Columns(1).HeaderText = "isyeri_id" Or DataGridView1.Columns(1).HeaderText = "arsa_id" Then
                DataGridView1.Columns(1).Visible = False
            End If
        End If
    End Sub
End Class
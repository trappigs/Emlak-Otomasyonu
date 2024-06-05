Imports System.Data.SqlClient

Public Class sqlAuth

    Public Shared Sub veriDoldur(query As String, adSutun As String, idSutun As String, tabloAdi As String, ByVal comboBox As ComboBox)
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

    Shared connectionString As String = "Data Source=DESKTOP-J5GMTR7\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"
    Shared connection As New SqlConnection(connectionString)
    Public Shared kisiTc As String
    Public Shared kayitBasari As Boolean = False

    Public Shared Sub KayitOlma(kayitComponents As List(Of Control), adresKayitComponents As List(Of Control))
        Dim queryKisiString As String = "INSERT INTO kisiler (kisi_tc, adi, soyadi, telefon, email, dogum_tarihi, cinsiyet, kisi_tipi, sifre) VALUES (@tc, @adi, @soyadi, @telefon, @email, @dogum_tarihi, @cinsiyet, @kisi_tipi, @sifre)"
        Dim queryAdresString As String = "INSERT INTO adres (il_adi, ilce_adi, mahalle_adi, sokak_adi, bina_no, daire_no, acik_adres, kisi_tc) VALUES (@il, @ilce, @mahalle, @sokak, @bina, @daire, @acikAdres, @kisiTc)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try
                Using commandKisi As New SqlCommand(queryKisiString, connection, transaction)

                    commandKisi.Parameters.AddWithValue("@tc", kayitComponents(0).Text)
                    commandKisi.Parameters.AddWithValue("@adi", kayitComponents(1).Text)
                    commandKisi.Parameters.AddWithValue("@soyadi", kayitComponents(2).Text)
                    commandKisi.Parameters.AddWithValue("@telefon", kayitComponents(3).Text)
                    commandKisi.Parameters.AddWithValue("@email", kayitComponents(4).Text)
                    commandKisi.Parameters.AddWithValue("@dogum_tarihi", DirectCast(kayitComponents(5), DateTimePicker).Value)
                    MessageBox.Show(kayitComponents(6).Text + " : " + kayitComponents(6).Name)
                    commandKisi.Parameters.AddWithValue("@cinsiyet", kayitComponents(6).Text)
                    commandKisi.Parameters.AddWithValue("@kisi_tipi", kayitComponents(7).Text)
                    commandKisi.Parameters.AddWithValue("@sifre", kayitComponents(8).Text)

                    commandKisi.ExecuteNonQuery()
                End Using

                Using commandAdres As New SqlCommand(queryAdresString, connection, transaction)


                    commandAdres.Parameters.AddWithValue("@il", adresKayitComponents(0).Text)
                    commandAdres.Parameters.AddWithValue("@ilce", adresKayitComponents(1).Text)
                    commandAdres.Parameters.AddWithValue("@mahalle", adresKayitComponents(2).Text)
                    commandAdres.Parameters.AddWithValue("@sokak", adresKayitComponents(3).Text)
                    commandAdres.Parameters.AddWithValue("@bina", adresKayitComponents(4).Text)
                    commandAdres.Parameters.AddWithValue("@daire", adresKayitComponents(5).Text)
                    commandAdres.Parameters.AddWithValue("@acikAdres", adresKayitComponents(6).Text)
                    commandAdres.Parameters.AddWithValue("@kisiTc", adresKayitComponents(7).Text)

                    commandAdres.ExecuteNonQuery()
                    kayitBasari = True
                End Using

                transaction.Commit()
            Catch ex As Exception
                MessageBox.Show("Veri eklenirken bir hata oluştu: " & ex.Message)
                transaction.Rollback()
            End Try
        End Using
    End Sub



    Public Shared Function GirisYapma(tc As String, sifre As String, kisi_tipi As String) As Integer
        Dim queryAlSat As String = "select kisi_tc, sifre from kisiler where kisi_tc = @kisiTc and sifre = @sifre and kisi_tipi LIKE N'" + kisi_tipi + "'"
        'If kisi_tipi = "musteri" Then
        '    queryAlSat += " and kisi_tipi LIKE N'Müşteri'"
        'Else
        '    queryAlSat += " and kisi_tipi LIKE N'Emlakçı'"
        'End If
        Dim dtKisi As New DataTable()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Try
                Using commandKisi As New SqlCommand(queryAlSat, connection)
                    commandKisi.Parameters.AddWithValue("@kisiTc", tc)
                    commandKisi.Parameters.AddWithValue("@sifre", sifre)
                    Using reader As SqlDataReader = commandKisi.ExecuteReader()
                        ' DataGridView'e sonuçları aktarın
                        dtKisi.Load(reader)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return False
            End Try
        End Using

        MessageBox.Show(queryAlSat)
        If dtKisi.Rows.Count > 0 Then
            kisiTc = tc
            Return True
        Else
            MessageBox.Show("TC veya şifre bilgisi yanlış.")
            Return False
        End If
    End Function



    Public Shared Function dateForSQL(tarih As DateTimePicker) As String
        Dim year As String = tarih.Value.Year
        Dim month As String = tarih.Value.Month
        Dim day As String = tarih.Value.Day

        Dim dateTime As String = year + "-" + month + "-" + day
        Return dateTime
    End Function




End Class

Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class KullaniciArsaListesi
    Private Sub KullaniciArsaListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", il_adi)


        veriDoldur("select Distinct CONCAT(adi, ' ', soyadi) as TamAd, kisi_tc from kisiler, isyeri where kisiler.kisi_tc = isyeri.emlak_sahibi_tc", "TamAd", "kisi_tc", "kisiler", emlak_sahibi_tc)
        veriDoldur("select imar_cesidi, imar_cesidi_id from imar_durumlari", "imar_cesidi", "imar_cesidi_id", "imar_durumlari", imar_cesidi)
        veriDoldur("select kaks_degeri, kaks_id from kaks_bilgi", "kaks_degeri", "kaks_id", "kaks_bilgi", kaks_degeri)
        veriDoldur("select gabari_degeri, gabari_id from gabari_bilgi", "gabari_degeri", "gabari_id", "gabari_bilgi", gabari_degeri)
        veriDoldur("select tapu_durum_id, tapu_aciklama from tapu_durumu", "tapu_aciklama", "tapu_durum_id", "tapu_durumu", tapu_durumu)

        veriDoldur("select Distinct CONCAT(adi, ' ', soyadi) as TamAd, kisi_tc from kisiler, arsa where kisiler.kisi_tc = arsa.emlak_sahibi_tc", "TamAd", "kisi_tc", "kisiler", emlak_sahibi_tc)


        il_adi.Text = ""
        ilce_adi.Text = ""
        mahalle_adi.Text = ""

        imar_cesidi.Text = ""
        kaks_degeri.Text = ""
        gabari_degeri.Text = ""
        tapu_durumu.Text = ""
        emlak_sahibi_tc.Text = ""
    End Sub

    Dim connectionString As String = "Data Source=DESKTOP-J5GMTR7\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"
    Dim connection As New SqlConnection(connectionString)

    Sub veriDoldur(query As String, adSutun As String, idSutun As String, tabloAdi As String, ByVal comboBox As ComboBox)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Dim componentsForArsa() As Control
            Dim componentsForArsa As List(Of Control) = New List(Of Control) From {imar_cesidi, ada_no, parsel_no, kaks_degeri, gabari_degeri, tapu_durumu}

            'ada_no, parsel_no, kaks_degeri, gabari_degeri, tapu_durumu)

            Dim componentsForAdres() As Control = {il_adi, ilce_adi, mahalle_adi, sokak_adi}


            If alan.Text.Length > 0 And AlanBuyuk.Text = "" Then
                componentsForArsa.Add(alan)
            ElseIf AlanBuyuk.Text.Length > 0 And alan.Text = "" Then
                componentsForArsa.Add(AlanBuyuk)
            ElseIf AlanBuyuk.Text.Length > 0 And alan.Text.Length > 0 Then
                componentsForArsa.Add(alan)
                componentsForArsa.Add(AlanBuyuk)
            End If

            If kiraUcretiKucuk.Text.Length > 0 And kiraUcretiBuyuk.Text = "" Then
                componentsForArsa.Add(kiraUcretiKucuk)
            ElseIf kiraUcretiBuyuk.Text.Length > 0 And kiraUcretiKucuk.Text = "" Then
                componentsForArsa.Add(kiraUcretiBuyuk)
            ElseIf kiraUcretiBuyuk.Text.Length > 0 And kiraUcretiKucuk.Text.Length > 0 Then
                componentsForArsa.Add(kiraUcretiKucuk)
                componentsForArsa.Add(kiraUcretiBuyuk)
            End If


            If satisUcretiKucuk.Text.Length > 0 And satisUcretiBuyuk.Text = "" Then
                componentsForArsa.Add(satisUcretiKucuk)
            ElseIf satisUcretiBuyuk.Text.Length > 0 And satisUcretiKucuk.Text = "" Then
                componentsForArsa.Add(satisUcretiBuyuk)
            ElseIf satisUcretiBuyuk.Text.Length > 0 And satisUcretiKucuk.Text.Length > 0 Then
                componentsForArsa.Add(satisUcretiKucuk)
                componentsForArsa.Add(satisUcretiBuyuk)
            End If

            If emlak_sahibi_tc.SelectedValue IsNot Nothing Then
                DataGridView1.DataSource = isyeriSorgula(Me, componentsForArsa, componentsForAdres, emlak_sahibi_tc.SelectedValue.ToString())
            Else
                DataGridView1.DataSource = isyeriSorgula(Me, componentsForArsa, componentsForAdres, "")
            End If

            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.Columns(DataGridView1.Columns.Count - 1).Visible = False
                DataGridView1.Columns(DataGridView1.Columns.Count - 2).Visible = False
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Throw
        End Try
    End Sub

    Function isyeriSorgula(form As Form, componentsForArsa As List(Of Control), componentsForAdres() As Control, kisi_tc As String) As DataTable
        Try
            Dim queryBirlesikString As String = "select kisiler.adi as 'Adı', kisiler.soyadi as 'Soyadı', emlak_sahibi_tc as 'Emlak Sahibi TC', imar_cesidi as 'İmar Çeşidi', ada_no as 'Ada No', parsel_no as 'Parsel No', kaks_degeri as 'Kaks Değeri', gabari_degeri as 'Gabari Değeri', tapu_durumu as 'Tapu Durumu', arsa.aciklama as 'Açıklama', alan as 'Alan', kira_ucret as 'Kira Ücreti', satis_ucret as 'Satış Ücreti', adres.il_adi as İl, adres.ilce_adi as İlçe, adres.mahalle_adi as Mahalle, adres.sokak_adi as 'Sokak Adı', adres.acik_adres as 'Açık Adres', arsa.arsa_id as 'arsa.arsa_id', adres.arsa_id as 'adres.arsa_id' from arsa, adres, kisiler where arsa.emlak_sahibi_tc = adres.kisi_tc and arsa.arsa_id = adres.arsa_id and kisiler.kisi_tc = adres.kisi_tc and kisiler.kisi_tc = emlak_sahibi_tc "
            If kisi_tc IsNot "" Then
                queryBirlesikString += "AND arsa.emlak_sahibi_tc = '" + kisi_tc.ToString() + "' "
            End If

            For Each ctrl As Control In componentsForArsa
                If TypeOf ctrl Is TextBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, TextBox).Text) Then
                    Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                    ' alan > 50
                    ' alan < 50
                    ' kontrol: soldaki kutu sağdakinden mutlaka küçük olmalı
                    ' kontrol: alan kutularına sadece sayı girilebilmeli
                    If txtBox.Name = "alan" Then
                        queryBirlesikString &= "AND arsa." & txtBox.Name & " >= " & txtBox.Text & " "
                    ElseIf txtBox.Name = "AlanBuyuk" Then
                        queryBirlesikString &= "AND arsa." & "alan " & " <= " & txtBox.Text & " "
                    ElseIf txtBox.Name = "kiraUcretiKucuk" Then
                        queryBirlesikString &= "AND arsa." & "kira_ucret " & " >= " & txtBox.Text & " "
                    ElseIf txtBox.Name = "kiraUcretiBuyuk" Then
                        queryBirlesikString &= "AND arsa." & "kira_ucret " & " <= " & txtBox.Text & " "
                    ElseIf txtBox.Name = "satisUcretiKucuk" Then
                        queryBirlesikString &= "AND arsa." & "satis_ucret " & " >= " & txtBox.Text & " "
                    ElseIf txtBox.Name = "satisUcretiBuyuk" Then
                        queryBirlesikString &= "AND arsa." & "satis_ucret " & " <= " & txtBox.Text & " "
                    ElseIf txtBox.Name = "kaks_degeri" Then
                        queryBirlesikString &= "AND arsa." & txtBox.Name & " = " & txtBox.Text.Replace(",", ".") & " "
                    ElseIf txtBox.Name = "gabari_degeri" Then
                        queryBirlesikString &= "AND arsa." & txtBox.Name & " = " & txtBox.Text.Replace(",", ".") & " "
                    Else
                        queryBirlesikString &= "AND arsa." & txtBox.Name & " LIKE N'%" & txtBox.Text & "%' "
                    End If

                End If

                If TypeOf ctrl Is ComboBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, ComboBox).Text) Then
                    Dim cmbBox As ComboBox = DirectCast(ctrl, ComboBox)

                    If cmbBox.Name = "kaks_degeri" Then
                        queryBirlesikString &= "AND arsa." & cmbBox.Name & " = " & cmbBox.Text.Replace(",", ".") & " "
                    ElseIf cmbBox.Name = "gabari_degeri" Then
                        queryBirlesikString &= "AND arsa." & cmbBox.Name & " = " & cmbBox.Text.Replace(",", ".") & " "
                    Else
                        queryBirlesikString &= "AND arsa." & cmbBox.Name & " = N'" & cmbBox.Text & "' "
                    End If

                End If
            Next


            For Each ctrl As Control In componentsForAdres
                If TypeOf ctrl Is TextBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, TextBox).Text) Then
                    Dim txtBox As TextBox = DirectCast(ctrl, TextBox)

                    queryBirlesikString &= "AND adres." & txtBox.Name & " LIKE N'" & txtBox.Text & "' "
                End If

                If TypeOf ctrl Is ComboBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, ComboBox).Text) Then
                    Dim cmbBox As ComboBox = DirectCast(ctrl, ComboBox)
                    queryBirlesikString &= "AND adres." & cmbBox.Name & " LIKE N'" & cmbBox.Text & "' "
                End If
            Next

            Dim dtIsyeriVeAdres As New DataTable()

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Try
                    Using commandKisi As New SqlCommand(queryBirlesikString, connection)
                        Using reader As SqlDataReader = commandKisi.ExecuteReader()
                            ' DataGridView'e sonuçları aktarın
                            dtIsyeriVeAdres.Load(reader)
                        End Using
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using

            If dtIsyeriVeAdres.Rows.Count > 0 Then
                Return dtIsyeriVeAdres
            Else
                MessageBox.Show(queryBirlesikString)
                MessageBox.Show("Kayıt bulunamadı.")
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Throw
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VeriGuncelle()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try
                For Each queryKisi As String In queryIsyeriDizisi
                    Using commandKisiGuncelle As New SqlCommand(queryKisi, connection, transaction)
                        commandKisiGuncelle.ExecuteNonQuery()
                    End Using
                Next

                For Each queryAdres As String In queryAdresDizisi
                    Using commandKisiAdresGuncelle As New SqlCommand(queryAdres, connection, transaction)
                        commandKisiAdresGuncelle.ExecuteNonQuery()
                    End Using
                Next

                transaction.Commit()
                MessageBox.Show("Bilgiler başarıyla güncellendi.")
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Dim queryIsyeriDizisi As New List(Of String)()
    Dim queryAdresDizisi As New List(Of String)()

    Sub VeriGuncelle()
        Dim queryIsyeriString As String
        Dim queryAdresString As String
        Dim sqlIsyeriKolonlari As New Dictionary(Of String, String)()
        Dim sqlAdresKolonlari As New Dictionary(Of String, String)()

        sqlIsyeriKolonlari.Add("İmar Çeşidi", "imar_cesidi")
        sqlIsyeriKolonlari.Add("Ada No", "ada_no")
        sqlIsyeriKolonlari.Add("Parsel No", "parsel_no")
        sqlIsyeriKolonlari.Add("Kaks Değeri", "kaks_degeri")
        sqlIsyeriKolonlari.Add("Gabari Değeri", "gabari_degeri")
        sqlIsyeriKolonlari.Add("Tapu Durumu", "tapu_durumu")
        sqlIsyeriKolonlari.Add("Açıklama", "aciklama")
        sqlIsyeriKolonlari.Add("Alan", "alan")
        sqlIsyeriKolonlari.Add("Kira Ücreti", "kira_ucret")
        sqlIsyeriKolonlari.Add("Satış Ücreti", "satis_ucret")

        ' Adres tablosu için kolon adları ve gösterilecek adlarını eşleştiren sözlük
        sqlAdresKolonlari.Add("İl", "il_adi")
        sqlAdresKolonlari.Add("İlçe", "ilce_adi")
        sqlAdresKolonlari.Add("Mahalle", "mahalle_adi")
        sqlAdresKolonlari.Add("Sokak Adı", "sokak_adi")
        sqlAdresKolonlari.Add("Bina Numarası", "bina_no")


        For Each itemRow As DataGridViewRow In DataGridView1.Rows
            queryIsyeriString = "UPDATE arsa SET "
            queryAdresString = "UPDATE adres SET "
            For Each itemColumn As DataGridViewColumn In DataGridView1.Columns
                Dim columnName As String = itemColumn.DataPropertyName

                ' İşyeri tablosundaki sütunlar için kontrol et
                If sqlIsyeriKolonlari.ContainsKey(columnName) And columnName IsNot "Yapım Yılı" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    Dim type As String = ""
                    Dim columnDataType = itemColumn.ValueType

                    If columnDataType Is GetType(Integer) Then
                        type = "int"
                    ElseIf columnDataType Is GetType(Decimal) Then
                        type = "int"
                    ElseIf columnDataType Is GetType(String) Then
                        type = "str"
                    End If

                    If columnName = "Yapım Yılı" Then
                        'Dim columnValue As Object = itemRow.Cells(columnName).Value
                        ' Yıl formatını uygun hale getir ve işyeri tablosu için sorgu stringine ekle
                        Dim dtarihi As String = columnValue.ToString().Substring(0, columnValue.ToString().IndexOf(" ")).ToString()
                        Dim parcalar() As String = dtarihi.Split(" "c)
                        Dim tarihParcalar() As String = parcalar(0).Split("."c)
                        Dim gun As String = tarihParcalar(0)
                        Dim ay As String = tarihParcalar(1)
                        Dim yil As String = tarihParcalar(2)
                        Dim sqlTarih As String = yil & "-" & ay & "-" & gun
                        queryIsyeriString += " yapim_yili = '" & sqlTarih & "', "
                    Else
                        If type = "int" Then
                            queryIsyeriString += sqlIsyeriKolonlari(columnName) & " = " & columnValue.ToString().Replace(",", ".") & ", "
                        ElseIf type = "str" Then
                            queryIsyeriString += sqlIsyeriKolonlari(columnName) & " = '" & columnValue.ToString() & "', "
                        End If
                    End If

                    ' İşyeri tablosu için sorgu stringine ekle
                    ' Yapım Yılı sütunu için özel durum kontrolü
                ElseIf columnName = "Yapım Yılı" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    ' Yıl formatını uygun hale getir ve işyeri tablosu için sorgu stringine ekle
                    Dim dtarihi As String = columnValue.ToString().Substring(0, columnValue.ToString().IndexOf(" ")).ToString()
                    Dim parcalar() As String = dtarihi.Split(" "c)
                    Dim tarihParcalar() As String = parcalar(0).Split("."c)
                    Dim gun As String = tarihParcalar(0)
                    Dim ay As String = tarihParcalar(1)
                    Dim yil As String = tarihParcalar(2)
                    Dim sqlTarih As String = yil & "-" & ay & "-" & gun
                    queryIsyeriString += " yapim_yili = '" & sqlTarih & "',"
                    ' Adres tablosundaki sütunlar için kontrol et
                ElseIf sqlAdresKolonlari.ContainsKey(columnName) Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    ' Adres tablosu için sorgu stringine ekle
                    queryAdresString += sqlAdresKolonlari(columnName) & " = '" & columnValue.ToString() & "',"
                End If


                If columnName = "arsa.arsa_id" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryIsyeriString += " WHERE arsa_id = " + columnValue.ToString()
                End If

                If columnName = "adres.arsa_id" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " WHERE isyeri_id = " + columnValue.ToString()
                End If
            Next

            Dim tc As String
            tc = itemRow.Cells("Emlak Sahibi TC").Value.ToString()

            If itemRow.DataGridView.Columns(8).DataPropertyName = "Emlak Sahibi TC" Then
                queryIsyeriString += " and emlak_sahibi_tc = '" + tc + "'"
                queryAdresString += " and kisi_tc = '" + tc + "'"
            End If



            Dim arananDesen As String = " WHERE"
            Dim desendenOncekiVirgulIndex As Integer = queryIsyeriString.LastIndexOf(","c, queryIsyeriString.IndexOf(arananDesen))
            queryIsyeriString = queryIsyeriString.Remove(desendenOncekiVirgulIndex, 1)


            desendenOncekiVirgulIndex = queryAdresString.LastIndexOf(","c, queryAdresString.IndexOf(arananDesen))
            queryAdresString = queryAdresString.Remove(desendenOncekiVirgulIndex, 1)


            queryIsyeriDizisi.Add(queryIsyeriString)
            queryAdresDizisi.Add(queryAdresString)
        Next

    End Sub

    Private Sub il_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles il_adi.SelectedIndexChanged
        veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + il_adi.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilce_adi)
    End Sub

    Private Sub ilce_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilce_adi.SelectedIndexChanged
        veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilce_adi.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalle_adi)
    End Sub

    Private Sub tapu_durumu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tapu_durumu.SelectedIndexChanged

    End Sub
End Class
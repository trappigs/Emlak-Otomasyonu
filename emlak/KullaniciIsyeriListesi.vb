Imports System.Data.SqlClient

Public Class KullaniciIsyeriListesi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'bu sorguyu kullanacağım
        Dim sorgu As String = "select * from isyeri where emlak_sahibi_tc = tcCombobox"
        Dim componentsForIsyeri As List(Of Control) = New List(Of Control) From {isyeri_tur, bolum_sayisi, aidat_ucret, isitma}
        Dim componentsForAdres() As Control = {il_adi, ilce_adi, mahalle_adi, sokak_adi}

        If alan.Text.Length > 0 And AlanBuyuk.Text = "" Then
            componentsForIsyeri.Add(alan)
        ElseIf AlanBuyuk.Text.Length > 0 And alan.Text = "" Then
            componentsForIsyeri.Add(AlanBuyuk)
        ElseIf AlanBuyuk.Text.Length > 0 And alan.Text.Length > 0 Then
            componentsForIsyeri.Add(alan)
            componentsForIsyeri.Add(AlanBuyuk)
        End If

        If kiraUcretiKucuk.Text.Length > 0 And kiraUcretiBuyuk.Text = "" Then
            componentsForIsyeri.Add(kiraUcretiKucuk)
        ElseIf kiraUcretiBuyuk.Text.Length > 0 And kiraUcretiKucuk.Text = "" Then
            componentsForIsyeri.Add(kiraUcretiBuyuk)
        ElseIf kiraUcretiBuyuk.Text.Length > 0 And kiraUcretiKucuk.Text.Length > 0 Then
            componentsForIsyeri.Add(kiraUcretiKucuk)
            componentsForIsyeri.Add(kiraUcretiBuyuk)
        End If


        If satisUcretiKucuk.Text.Length > 0 And satisUcretiBuyuk.Text = "" Then
            componentsForIsyeri.Add(satisUcretiKucuk)
        ElseIf satisUcretiBuyuk.Text.Length > 0 And satisUcretiKucuk.Text = "" Then
            componentsForIsyeri.Add(satisUcretiBuyuk)
        ElseIf satisUcretiBuyuk.Text.Length > 0 And satisUcretiKucuk.Text.Length > 0 Then
            componentsForIsyeri.Add(satisUcretiKucuk)
            componentsForIsyeri.Add(satisUcretiBuyuk)
        End If



        'If DataGridView1.Rows.Count > 0 Then
        '    DataGridView1.Columns(0).Visible = False
        '    DataGridView1.Columns(1).Visible = False
        'End If


        DataGridView1.DataSource = isyeriSorgula(Me, componentsForIsyeri, componentsForAdres, emlak_sahibi_tc.SelectedValue.ToString())
    End Sub

    Dim queryIsyeriDizisi As New List(Of String)()
    Dim queryAdresDizisi As New List(Of String)()

    Sub VeriGuncelle()
        Dim queryIsyeriString As String
        Dim queryAdresString As String
        Dim sqlIsyeriKolonlari As New Dictionary(Of String, String)()
        Dim sqlAdresKolonlari As New Dictionary(Of String, String)()

        sqlIsyeriKolonlari.Add("İşyeri Türü", "isyeri_tur")
        sqlIsyeriKolonlari.Add("Bölüm Sayısı", "bolum_sayisi")
        sqlIsyeriKolonlari.Add("Aidat Ücreti", "aidat_ucret")
        sqlIsyeriKolonlari.Add("Isıtma", "isitma")
        sqlIsyeriKolonlari.Add("Yapım Yılı", "yapim_yili")
        sqlIsyeriKolonlari.Add("Alan(m2)", "alan")
        sqlIsyeriKolonlari.Add("Açıklama", "aciklama")


        ' Adres tablosu için kolon adları ve gösterilecek adlarını eşleştiren sözlük
        sqlAdresKolonlari.Add("İl", "il_adi")
        sqlAdresKolonlari.Add("İlçe", "ilce_adi")
        sqlAdresKolonlari.Add("Mahalle", "mahalle_adi")
        sqlAdresKolonlari.Add("Sokak Adı", "sokak_adi")
        sqlAdresKolonlari.Add("Bina Numarası", "bina_no")
        sqlAdresKolonlari.Add("Daire Numarası", "daire_no")
        sqlAdresKolonlari.Add("Açık Adres", "acik_adres")


        For Each itemRow As DataGridViewRow In DataGridView1.Rows
            queryIsyeriString = "UPDATE isyeri SET "
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
                            queryIsyeriString += sqlIsyeriKolonlari(columnName) & " = " & columnValue.ToString() & ", "
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


                If columnName = "isyeri.isyeri_id" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryIsyeriString += " WHERE isyeri_id = " + columnValue.ToString()
                End If

                If columnName = "adres.isyeri_id" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " WHERE isyeri_id = " + columnValue.ToString()
                End If
            Next

            Dim tc As String
            tc = itemRow.Cells("Emlak Sahibi TC").Value.ToString()

            If itemRow.DataGridView.Columns(7).DataPropertyName = "Emlak Sahibi TC" Then
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

    Private Sub KullaniciIsyeriListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", il_adi)
        veriDoldur("select tur_aciklamasi, isyeri_tur_id from isyeri_turleri", "tur_aciklamasi", "isyeri_tur_id", "isyeri_turleri", isyeri_tur)
        veriDoldur("select Distinct CONCAT(adi, ' ', soyadi) as TamAd, kisi_tc from kisiler, isyeri where kisiler.kisi_tc = isyeri.emlak_sahibi_tc", "TamAd", "kisi_tc", "kisiler", emlak_sahibi_tc)

        isyeri_tur.Text = ""
        il_adi.Text = ""
        ilce_adi.Text = ""
        mahalle_adi.Text = ""
        emlak_sahibi_tc.Text = ""
    End Sub

    Dim connectionString As String = "Data Source=DESKTOP-J5GMTR7\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"
    Dim connection As New SqlConnection(connectionString)

    Function isyeriSorgula(form As Form, componentsForArsa As List(Of Control), componentsForAdres() As Control, kisi_tc As String) As DataTable
        Dim queryBirlesikString As String = "select kisiler.adi as 'Adı', kisiler.soyadi as 'Soyadı', isyeri.kira_ucret as 'Kira Ücreti', isyeri.satis_ucret as 'Satış Fiyatı', isyeri.isyeri_tur AS 'İşyeri Türü', isyeri.bolum_sayisi AS 'Bölüm Sayısı', isyeri.aidat_ucret AS 'Aidat Ücreti', isyeri.isitma AS 'Isıtma', isyeri.yapim_yili AS 'Yapım Yılı', isyeri.alan AS 'Alan(m2)', isyeri.aciklama as 'Açıklama', emlak_sahibi_tc as 'Emlak Sahibi TC', adres.il_adi as İl, adres.ilce_adi as İlçe, adres.mahalle_adi as Mahalle, adres.sokak_adi as 'Sokak Adı', adres.bina_no as 'Bina Numarası', adres.daire_no as 'Daire Numarası', adres.acik_adres as 'Açık Adres', isyeri.isyeri_id AS 'isyeri.isyeri_id', adres.isyeri_id as 'adres.isyeri_id' from isyeri, adres, kisiler where isyeri.emlak_sahibi_tc = adres.kisi_tc and isyeri.isyeri_id = adres.isyeri_id and kisiler.kisi_tc = adres.kisi_tc and kisiler.kisi_tc = isyeri.emlak_sahibi_tc  "
        queryBirlesikString += "AND isyeri.emlak_sahibi_tc = '" + kisi_tc.ToString() + "' "
        For Each ctrl As Control In componentsForArsa
            If TypeOf ctrl Is TextBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, TextBox).Text) Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)
                Dim txtBoxName As String = txtBox.Name

                Select Case txtBoxName
                    Case "alan"
                        queryBirlesikString &= "AND isyeri." & txtBox.Name & " >= " & txtBox.Text & " "
                    Case "AlanBuyuk"
                        queryBirlesikString &= "AND isyeri." & "alan " & " <= " & txtBox.Text & " "
                    Case "kiraUcretiKucuk"
                        queryBirlesikString &= "AND isyeri." & "kira_ucret " & " >= " & txtBox.Text & " "
                    Case "kiraUcretiBuyuk"
                        queryBirlesikString &= "AND isyeri." & "kira_ucret " & " <= " & txtBox.Text & " "
                    Case "satisUcretiKucuk"
                        queryBirlesikString &= "AND isyeri." & "satis_ucret " & " >= " & txtBox.Text & " "
                    Case "satisUcretiBuyuk"
                        queryBirlesikString &= "AND isyeri." & "satis_ucret " & " <= " & txtBox.Text & " "
                    Case "kaks_degeri"
                        queryBirlesikString &= "AND isyeri." & txtBox.Name & " = " & txtBox.Text.Replace(",", ".") & " "
                    Case "gabari_degeri"
                        queryBirlesikString &= "AND isyeri." & txtBox.Name & " = " & txtBox.Text.Replace(",", ".") & " "
                    Case Else
                        queryBirlesikString &= "AND isyeri." & txtBox.Name & " LIKE N'%" & txtBox.Text & "%' "
                End Select
            End If

            If TypeOf ctrl Is ComboBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, ComboBox).Text) Then
                Dim cmbBox As ComboBox = DirectCast(ctrl, ComboBox)
                queryBirlesikString &= "AND isyeri." & cmbBox.Name & " = N'" & cmbBox.Text & "' "
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
            MessageBox.Show("Kayıt bulunamadı.")
            Return Nothing
        End If
    End Function

    Private Sub il_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles il_adi.SelectedIndexChanged
        veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + il_adi.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilce_adi)
    End Sub

    Private Sub ilce_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilce_adi.SelectedIndexChanged
        veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilce_adi.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalle_adi)
    End Sub

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

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class

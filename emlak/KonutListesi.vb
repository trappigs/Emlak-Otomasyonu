Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class KonutListesi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'bu sorguyu kullanacağım
        Dim componentsForKonut As List(Of Control) = New List(Of Control) From {oda_sayisi, bulundugu_kat, bina_kat_sayisi, isitma, balkon_sayisi, banyo_sayisi, aidat_ucreti, alan, otopark, cephe, esya_evet, esya_hayir, asansor_evet, asansor_hayir}
        Dim componentsForAdres() As Control = {il_adi, ilce_adi, mahalle_adi, sokak_adi, mahalle_adi, bina_no, daire_no}


        If alan.Text.Length > 0 And AlanBuyuk.Text = "" Then
            componentsForKonut.Add(alan)
        ElseIf AlanBuyuk.Text.Length > 0 And alan.Text = "" Then
            componentsForKonut.Add(AlanBuyuk)
        ElseIf AlanBuyuk.Text.Length > 0 And alan.Text.Length > 0 Then
            componentsForKonut.Add(alan)
            componentsForKonut.Add(AlanBuyuk)
        End If

        If kiraUcretiKucuk.Text.Length > 0 And kiraUcretiBuyuk.Text = "" Then
            componentsForKonut.Add(kiraUcretiKucuk)
        ElseIf kiraUcretiBuyuk.Text.Length > 0 And kiraUcretiKucuk.Text = "" Then
            componentsForKonut.Add(kiraUcretiBuyuk)
        ElseIf kiraUcretiBuyuk.Text.Length > 0 And kiraUcretiKucuk.Text.Length > 0 Then
            componentsForKonut.Add(kiraUcretiKucuk)
            componentsForKonut.Add(kiraUcretiBuyuk)
        End If


        If satisUcretiKucuk.Text.Length > 0 And satisUcretiBuyuk.Text = "" Then
            componentsForKonut.Add(satisUcretiKucuk)
        ElseIf satisUcretiBuyuk.Text.Length > 0 And satisUcretiKucuk.Text = "" Then
            componentsForKonut.Add(satisUcretiBuyuk)
        ElseIf satisUcretiBuyuk.Text.Length > 0 And satisUcretiKucuk.Text.Length > 0 Then
            componentsForKonut.Add(satisUcretiKucuk)
            componentsForKonut.Add(satisUcretiBuyuk)
        End If



        If emlak_sahibi_tc.SelectedIndex > 0 Then
            DataGridView1.DataSource = isyeriSorgula(Me, componentsForKonut, componentsForAdres, emlak_sahibi_tc.SelectedValue.ToString())
        Else
            DataGridView1.DataSource = isyeriSorgula(Me, componentsForKonut, componentsForAdres, "")
        End If

        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = False
        End If


    End Sub




    Dim connectionString As String = "Data Source=BU2-C-000WY\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"
    Dim connection As New SqlConnection(connectionString)

    Function isyeriSorgula(form As Form, componentsForArsa As List(Of Control), componentsForAdres() As Control, kisi_tc As String) As DataTable
        Dim queryBirlesikString As String = "select kisiler.adi as 'Adı', kisiler.soyadi as 'Soyadı', satis_ucret as 'Satış Ücreti', kira_ucret as 'Kira Ücreti', bina_yapim_yili AS 'Bina Yapım Yılı', oda_sayisi as 'Oda Sayısı', bulundugu_kat as 'Bulunduğu Kat', bina_kat_sayisi as 'Bina Kat Sayısı', isitma as 'Isıtma', banyo_sayisi as 'Banyo Sayısı', balkon_sayisi as 'Balkon Sayısı', asansor_var_mi as 'Asansör', otopark as 'Otopark', esyali_mi as 'Eşyalı', aidat_ucret as 'Aidat Ücret', konutlar.aciklama as 'Açıklama', alan as 'Alan', emlak_sahibi_tc as 'Emlak Sahibi TC', cephe as 'Cephe', adres.il_adi as İl, adres.ilce_adi as İlçe, adres.mahalle_adi as Mahalle, adres.sokak_adi as 'Sokak Adı', adres.bina_no as 'Bina Numarası', adres.daire_no as 'Daire Numarası', adres.acik_adres as 'Açık Adres', konutlar.konut_id AS 'konutlar.konut_id', adres.konut_id AS 'adres.konut_id' from konutlar, adres, kisiler WHERE konutlar.emlak_sahibi_tc = adres.kisi_tc and konutlar.konut_id = adres.konut_id and kisiler.kisi_tc = konutlar.emlak_sahibi_tc and kisiler.kisi_tc = adres.kisi_tc "
        If Not kisi_tc = "" Then
            queryBirlesikString += "AND konutlar.emlak_sahibi_tc = '" + kisi_tc + "' "
        End If

        For Each ctrl As Control In componentsForArsa
            If TypeOf ctrl Is TextBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, TextBox).Text) Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)

                If txtBox.Name = "alan" Then
                    queryBirlesikString &= "AND konutlar." & txtBox.Name & " >= " & txtBox.Text & " "
                ElseIf txtBox.Name = "AlanBuyuk" Then
                    queryBirlesikString &= "AND konutlar." & "alan " & " <= " & txtBox.Text & " "
                ElseIf txtBox.Name = "kiraUcretiKucuk" Then
                    queryBirlesikString &= "AND konutlar." & "kira_ucret " & " >= " & txtBox.Text & " "
                ElseIf txtBox.Name = "kiraUcretiBuyuk" Then
                    queryBirlesikString &= "AND konutlar." & "kira_ucret " & " <= " & txtBox.Text & " "
                ElseIf txtBox.Name = "satisUcretiKucuk" Then
                    queryBirlesikString &= "AND konutlar." & "satis_ucret " & " >= " & txtBox.Text & " "
                ElseIf txtBox.Name = "satisUcretiBuyuk" Then
                    queryBirlesikString &= "AND konutlar." & "satis_ucret " & " <= " & txtBox.Text & " "
                Else
                    queryBirlesikString &= "AND konutlar." & txtBox.Name & " LIKE N'%" & txtBox.Text & "%' "
                End If
            End If

            If TypeOf ctrl Is ComboBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, ComboBox).Text) Then
                Dim cmbBox As ComboBox = DirectCast(ctrl, ComboBox)
                queryBirlesikString &= "AND konutlar." & cmbBox.Name & " LIKE N'" & cmbBox.Text & "' "
            End If


            If TypeOf ctrl Is RadioButton AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, RadioButton).Text) Then
                Dim radio As RadioButton = DirectCast(ctrl, RadioButton)
                If radio.Name = "esya_evet" And radio.Checked Then
                    queryBirlesikString &= "AND konutlar.esyali_mi LIKE N'evet'"
                ElseIf radio.Name = "esya_hayir" And radio.Checked Then
                    queryBirlesikString &= "AND konutlar.esyali_mi LIKE N'hayır'"
                ElseIf radio.Name = "asansor_evet" And radio.Checked Then
                    queryBirlesikString &= "AND konutlar.asansor_var_mi LIKE N'evet'"
                ElseIf radio.Name = "asansor_hayir" And radio.Checked Then
                    queryBirlesikString &= "AND konutlar.asansor_var_mi LIKE N'hayır'"
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


    End Function

    Private Sub KonutListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select Distinct CONCAT(adi, ' ', soyadi) as TamAd, kisi_tc from kisiler, konutlar where kisiler.kisi_tc = konutlar.emlak_sahibi_tc", "TamAd", "kisi_tc", "kisiler", emlak_sahibi_tc)


        veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", il_adi)


        veriDoldur("select cephe_adi, cephe_id from cephe", "cephe_adi", "cephe_id", "cephe", cephe)

        cephe.Text = ""
        emlak_sahibi_tc.Text = ""
        il_adi.Text = ""
        ilce_adi.Text = ""
        mahalle_adi.Text = ""

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

        sqlIsyeriKolonlari.Add("Bina Yapım Yılı", "bina_yapim_yili")
        sqlIsyeriKolonlari.Add("Oda Sayısı", "oda_sayisi")
        sqlIsyeriKolonlari.Add("Bulunduğu Kat", "bulundugu_kat")
        sqlIsyeriKolonlari.Add("Bina Kat Sayısı", "bina_kat_sayisi")
        sqlIsyeriKolonlari.Add("Isıtma", "isitma")
        sqlIsyeriKolonlari.Add("Banyo Sayısı", "banyo_sayisi")
        sqlIsyeriKolonlari.Add("Balkon Sayısı", "balkon_sayisi")
        sqlIsyeriKolonlari.Add("Asansör var mı?", "asansor_var_mi")
        sqlIsyeriKolonlari.Add("Otopark", "otopark")
        sqlIsyeriKolonlari.Add("Eşyalı mı?", "esyali_mi")
        sqlIsyeriKolonlari.Add("Aidat Ücret", "aidat_ucret")
        sqlIsyeriKolonlari.Add("Açıklama", "aciklama")
        sqlIsyeriKolonlari.Add("Alan", "alan")
        sqlIsyeriKolonlari.Add("Cephe", "cephe")

        ' Adres tablosu için kolon adları ve gösterilecek adlarını eşleştiren sözlük
        sqlAdresKolonlari.Add("İl", "il_adi")
        sqlAdresKolonlari.Add("İlçe", "ilce_adi")
        sqlAdresKolonlari.Add("Mahalle", "mahalle_adi")
        sqlAdresKolonlari.Add("Sokak Adı", "sokak_adi")
        sqlAdresKolonlari.Add("Bina Numarası", "bina_no")
        sqlAdresKolonlari.Add("Daire Numarası", "daire_no")
        sqlAdresKolonlari.Add("Açık Adres", "acik_adres")


        For Each itemRow As DataGridViewRow In DataGridView1.Rows
            queryIsyeriString = "UPDATE konutlar SET "
            queryAdresString = "UPDATE adres SET "
            For Each itemColumn As DataGridViewColumn In DataGridView1.Columns
                Dim columnName As String = itemColumn.DataPropertyName
                'MessageBox.Show(columnName)
                ' İşyeri tablosundaki sütunlar için kontrol et
                If sqlIsyeriKolonlari.ContainsKey(columnName) And columnName IsNot "Bina Yapım Yılı" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    Dim type As String = ""
                    Dim columnDataType = itemColumn.ValueType

                    If columnDataType Is GetType(String) Then
                        type = "str"
                    ElseIf columnDataType Is GetType(Decimal) Then
                        type = "dec"
                    Else
                        type = "int"
                    End If


                    If columnName = "Bina Yapım Yılı" Then
                        'Dim columnValue As Object = itemRow.Cells(columnName).Value
                        ' Yıl formatını uygun hale getir ve işyeri tablosu için sorgu stringine ekle
                        Dim dtarihi As String = columnValue.ToString().Substring(0, columnValue.ToString().IndexOf(" ")).ToString()
                        Dim parcalar() As String = dtarihi.Split(" "c)
                        Dim tarihParcalar() As String = parcalar(0).Split("."c)
                        Dim gun As String = tarihParcalar(0)
                        Dim ay As String = tarihParcalar(1)
                        Dim yil As String = tarihParcalar(2)
                        Dim sqlTarih As String = yil & "-" & ay & "-" & gun
                        queryIsyeriString += " bina_yapim_yili = '" & sqlTarih & "', "
                    Else
                        If type = "int" Then
                            queryIsyeriString += sqlIsyeriKolonlari(columnName) & " = " & columnValue.ToString() & ", "
                        ElseIf type = "str" Then
                            queryIsyeriString += sqlIsyeriKolonlari(columnName) & " = '" & columnValue.ToString() & "', "
                        ElseIf type = "dec" Then
                            queryIsyeriString += sqlIsyeriKolonlari(columnName) & " = " & columnValue.ToString().Replace(",", ".") & ", "
                        End If

                    End If

                    ' İşyeri tablosu için sorgu stringine ekle
                    ' Yapım Yılı sütunu için özel durum kontrolü
                ElseIf columnName = "Bina Yapım Yılı" Then
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


                If columnName = "konutlar.konut_id" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryIsyeriString += " WHERE konut_id = " + columnValue.ToString()
                End If

                If columnName = "adres.konut_id" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " WHERE konut_id= " + columnValue.ToString()
                End If
            Next

            Dim tc As String
            tc = itemRow.Cells("Emlak Sahibi TC").Value.ToString()
            MessageBox.Show("tc: " + tc)

            If itemRow.DataGridView.Columns(13).DataPropertyName = "Emlak Sahibi TC" Then
                queryIsyeriString += " and emlak_sahibi_tc = '" + tc + "'"
                queryAdresString += " and kisi_tc = '" + tc + "'"
            End If


            Dim arananDesen As String = " WHERE"
            Dim desendenOncekiVirgulIndex As Integer = queryIsyeriString.LastIndexOf(","c, queryIsyeriString.IndexOf(arananDesen))
            queryIsyeriString = queryIsyeriString.Remove(desendenOncekiVirgulIndex, 1)


            desendenOncekiVirgulIndex = queryAdresString.LastIndexOf(","c, queryAdresString.IndexOf(arananDesen))
            queryAdresString = queryAdresString.Remove(desendenOncekiVirgulIndex, 1)


            MessageBox.Show(queryIsyeriString)
            MessageBox.Show(queryAdresString)
            queryIsyeriDizisi.Add(queryIsyeriString)
            queryAdresDizisi.Add(queryAdresString)
        Next

    End Sub

    Private Sub oda_sayisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles oda_sayisi.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bulundugu_kat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bulundugu_kat.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bina_kat_sayisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bina_kat_sayisi.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub isitma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles isitma.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

        If sender.TextLength >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub banyo_sayisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles banyo_sayisi.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub balkon_sayisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles balkon_sayisi.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 4 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub aidat_ucreti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles aidat_ucreti.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If
    End Sub

    Private Sub alan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If
    End Sub

    Private Sub otopark_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otopark.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

        If sender.TextLength >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub il_adi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles il_adi.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

    End Sub

    Private Sub mahalle_adi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mahalle_adi.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

    End Sub

    Private Sub ilce_adi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ilce_adi.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If
    End Sub

    Private Sub daire_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles daire_no.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 5 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub il_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles il_adi.SelectedIndexChanged
        veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + il_adi.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilce_adi)

    End Sub

    Private Sub mahalle_adi_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ilce_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilce_adi.SelectedIndexChanged
        veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilce_adi.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalle_adi)
    End Sub
End Class
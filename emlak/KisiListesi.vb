Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class KisiListesi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim componentsForArsa() As Control
        If erkek.Checked Then
            componentsForArsa = {kisi_tc, adi, soyadi, telefon, email, erkek}
        ElseIf kadın.Checked Then
            componentsForArsa = {kisi_tc, adi, soyadi, telefon, email, kadın}
        Else
            componentsForArsa = {kisi_tc, adi, soyadi, telefon, email}
        End If

        Dim componentsForAdres() As Control = {il_adi, ilce_adi, mahalle_adi, sokak_adi, bina_no, daire_no}

        If kisi_tipi.Text IsNot "" Then
            DataGridView1.DataSource = KisiSorgula(Me, componentsForArsa, componentsForAdres, kisi_tipi.Text)
            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.Columns(0).Visible = False
            End If
        Else
            MessageBox.Show("Lütfen kişi tipi seçiniz.")
        End If




    End Sub


    Function KisiSorgula(form As Form, componentsForArsa() As Control, componentsForAdres() As Control, kisi_tipi As String) As DataTable
        Dim queryBirlesikString As String = "select kisiler.kisi_tc AS TC, kisiler.adi AS Adı, kisiler.soyadi as Soyadı, kisiler.telefon as Telefon, kisiler.email as 'E-Posta', kisiler.dogum_tarihi as 'Doğum Tarihi', kisiler.aciklama as Açıklama, kisiler.cinsiyet as Cinsiyet, adres.il_adi as İl, adres.ilce_adi as İlçe, adres.mahalle_adi as Mahalle, adres.sokak_adi as 'Sokak Adı', adres.bina_no as 'Bina Numarası', adres.daire_no as 'Daire Numarası', adres.acik_adres as 'Açık Adres' from kisiler, adres where adres.kisi_tc = kisiler.kisi_tc "


        For Each ctrl As Control In componentsForArsa
            If TypeOf ctrl Is TextBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, TextBox).Text) Then
                Dim txtBox As TextBox = DirectCast(ctrl, TextBox)

                queryBirlesikString &= "AND kisiler." & txtBox.Name & " LIKE N'%" & txtBox.Text & "%' "

            End If

            If TypeOf ctrl Is ComboBox AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, ComboBox).Text) Then
                Dim cmbBox As ComboBox = DirectCast(ctrl, ComboBox)
                queryBirlesikString &= "AND kisiler." & cmbBox.Name & " = N'" & cmbBox.Text & "' "
            End If

            If TypeOf ctrl Is RadioButton AndAlso Not String.IsNullOrEmpty(DirectCast(ctrl, RadioButton).Text) Then
                Dim radio As RadioButton = DirectCast(ctrl, RadioButton)
                queryBirlesikString &= "AND kisiler.cinsiyet = N'" & radio.Text & "' "
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


        If kisi_tipi = "Müşteri" Then
            queryBirlesikString += " and kisi_tipi = N'Müşteri'"
        Else
            queryBirlesikString += " and kisi_tipi = N'Emlakçı'"
        End If

        queryBirlesikString += " and arsa_id IS NULL AND konut_id IS NULL AND isyeri_id IS NULL;"

        MessageBox.Show(queryBirlesikString)

        Dim dtKisi As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Try
                Using commandKisi As New SqlCommand(queryBirlesikString, connection)
                    Using reader As SqlDataReader = commandKisi.ExecuteReader()
                        ' DataGridView'e sonuçları aktarın

                        dtKisi.Load(reader)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

        If dtKisi.Rows.Count > 0 Then
            Return dtKisi
        Else
            MessageBox.Show("Kayıt bulunamadı.")
            Return Nothing
        End If

    End Function




    Dim connectionString As String = "Data Source=DESKTOP-J5GMTR7\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"
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

    Private Sub KisiListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", il_adi)
        il_adi.Text = ""
        ilce_adi.Text = ""
        mahalle_adi.Text = ""
    End Sub

    Private Sub il_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles il_adi.SelectedIndexChanged
        veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + il_adi.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilce_adi)
    End Sub

    Private Sub ilce_adi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilce_adi.SelectedIndexChanged
        veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilce_adi.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalle_adi)
    End Sub

    Dim queryKisiDizisi As New List(Of String)()
    Dim queryAdresDizisi As New List(Of String)()



    Sub VeriGuncelle()
        Dim queryKisiString As String = "UPDATE kisiler SET"
        Dim queryAdresString As String = "UPDATE adres SET"

        For Each itemRow As DataGridViewRow In DataGridView1.Rows
            queryKisiString = "UPDATE kisiler SET"
            queryAdresString = "UPDATE adres SET"
            For Each itemColumn As DataGridViewColumn In DataGridView1.Columns
                Dim columnName As String = itemColumn.DataPropertyName


                If columnName.ToString() = "Adı" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryKisiString += " adi = '" + columnValue.ToString() + "',"
                End If

                If columnName.ToString() = "Soyadı" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryKisiString += " soyadi = '" + columnValue.ToString() + "',"
                End If

                If columnName.ToString() = "Telefon" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryKisiString += " telefon = '" + columnValue.ToString() + "',"
                End If

                If columnName.ToString() = "E-Posta" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryKisiString += " email = '" + columnValue.ToString() + "',"
                End If

                If columnName.ToString() = "Doğum Tarihi" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    Dim dtarihi As String = columnValue.ToString().Substring(0, columnValue.ToString().IndexOf(" ")).ToString()

                    Dim parcalar() As String = dtarihi.Split(" "c) ' Boşluk karakterine göre ayır

                    Dim tarihParcalar() As String = parcalar(0).Split("."c) ' Tarih kısmını noktaya göre ayır
                    Dim gun As String = tarihParcalar(0)
                    Dim ay As String = tarihParcalar(1)
                    Dim yil As String = tarihParcalar(2)

                    Dim sqlTarih As String = yil & "-" & ay & "-" & gun

                    queryKisiString += " dogum_tarihi = '" + sqlTarih + "',"
                End If

                If columnName.ToString() = "Açıklama" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryKisiString += " aciklama = '" + columnValue.ToString() + "',"
                End If

                If columnName.ToString() = "Cinsiyet" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryKisiString += " cinsiyet = '" + columnValue.ToString() + "'"
                End If

                If columnName.ToString() = "İl" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " il_adi = '" + columnValue.ToString() + "',"
                End If

                If columnName.ToString() = "İlçe" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " ilce_adi = '" + columnValue.ToString() + "',"
                End If

                If columnName.ToString() = "Mahalle" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " mahalle_adi = '" + columnValue.ToString() + "',"
                End If
                If columnName.ToString() = "Sokak Adı" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " sokak_adi = '" + columnValue.ToString() + "',"
                End If
                If columnName.ToString() = "Bina Numarası" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " bina_no = " + columnValue.ToString() + ","
                End If
                If columnName.ToString() = "Daire Numarası" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " daire_no = " + columnValue.ToString() + ","
                End If
                If columnName.ToString() = "Açık Adres" Then
                    Dim columnValue As Object = itemRow.Cells(columnName).Value
                    queryAdresString += " acik_adres = '" + columnValue.ToString() + "'"
                End If
            Next

            Dim tc As String = itemRow.Cells("TC").Value.ToString()
            If itemRow.DataGridView.Columns(0).DataPropertyName = "TC" Then
                queryKisiString += " WHERE kisi_tc = " + tc
                queryAdresString += " WHERE kisi_tc = " + tc
            End If

            queryKisiDizisi.Add(queryKisiString)
            queryAdresDizisi.Add(queryAdresString)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        VeriGuncelle()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try
                For Each queryKisi As String In queryKisiDizisi
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
                MessageBox.Show(ex.Message)
            End Try
        End Using

    End Sub

    Private Sub kisi_tc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kisi_tc.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub telefon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telefon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub adi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles adi.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

        If sender.TextLength >= 250 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub soyadi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles soyadi.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

        If sender.TextLength >= 250 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub daire_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles daire_no.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 6 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
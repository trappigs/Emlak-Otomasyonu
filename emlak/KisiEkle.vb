Imports System.Data.SqlClient
Imports System.Net
Imports System.Windows.Forms

Public Class KisiEkle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim emlakciComponents() As Control = {tcTextBox, adTextBox, soyadTextBox, telTextBox, emailTextBox, DateTimePicker1, acikAdresTextBox, RadioButton1, RadioButton2, kisiTipiComboBox}
        Dim adresComponents() As Control = {ilComboBox, ilceComboBox, mahalleComboBox, sokakTextBox, binaNoTextBox, daireNoTextBox, acikAdresTextBox, tcTextBox}

        Dim myList As New List(Of String)

        For Each ctrl As Control In emlakciComponents.Concat(adresComponents)
            If TypeOf ctrl Is ComboBox AndAlso String.IsNullOrEmpty(DirectCast(ctrl, ComboBox).Text) Then
                If Not myList.Contains(ctrl.Name) Then
                    myList.Add(ctrl.Name)
                End If
            End If

            If TypeOf ctrl Is TextBox AndAlso String.IsNullOrEmpty(DirectCast(ctrl, TextBox).Text) Then
                If Not myList.Contains(ctrl.Name) Then
                    myList.Add(ctrl.Name)
                End If
            End If
        Next



        TelefonNumarasiDogrula(telTextBox.Text)
        EpostaDogrula(emailTextBox.Text)

        If Not (RadioButton1.Checked Or RadioButton2.Checked) Then
            MessageBox.Show("Lütfen cinsiyet seçiniz.")
        End If


        Dim uyariMesaji As String = "Şu componentler doldurulmalıdır: " & vbNewLine
        For Each item As String In myList
            uyariMesaji += "-" + item & vbNewLine
        Next

        If myList.Count = 0 Then
            If VeritabaninaEkle(Me, emlakciComponents, adresComponents) Then
                MessageBox.Show("Veri başarıyla eklendi.")
            End If
        Else
            MessageBox.Show(uyariMesaji)
        End If


    End Sub



    Shared Function GetTextBoxValue(textBox As TextBox) As String
        Return If(textBox IsNot Nothing, textBox.Text, "")
    End Function

    Shared Function GetIntValue(textBox As TextBox) As Integer
        Dim intValue As Integer
        Integer.TryParse(textBox.Text, intValue)
        Return intValue
    End Function

    Shared Function GetRadioButtonValue(radioButton1 As RadioButton, radioButton2 As RadioButton) As String
        Return If(radioButton1.Checked, radioButton1.Text, radioButton2.Text)
    End Function

    Shared Function GetDateTimePickerValue(dateTimePicker As DateTimePicker) As Date
        Return If(dateTimePicker IsNot Nothing, dateTimePicker.Value, Date.MinValue)
    End Function

    Shared Function GetComboBoxValue(comboBox As ComboBox) As String
        Return If(comboBox IsNot Nothing AndAlso comboBox.SelectedItem IsNot Nothing, comboBox.Text, "")
    End Function


    Dim connectionString As String = "Data Source=BU2-C-000WY\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"


    Private Function VeritabaninaEkle(form As Form, componentsForKisi() As Control, componentsForAdres() As Control) As Boolean
        Dim queryKisiString As String = "INSERT INTO kisiler (kisi_tc, adi, soyadi, telefon, email, dogum_tarihi, aciklama, cinsiyet, kisi_tipi) VALUES (@tc, @adi, @soyadi, @telefon, @email, @dogum_tarihi, @aciklama, @cinsiyet, @kisi_tipi)"
        Dim queryAdresString As String = "INSERT INTO adres (il_adi, ilce_adi, mahalle_adi, sokak_adi, bina_no, daire_no, acik_adres, kisi_tc) VALUES (@il, @ilce, @mahalle, @sokak, @bina, @daire, @acikAdres, @kisiTc)"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try
                Using commandKisi As New SqlCommand(queryKisiString, connection, transaction)

                    commandKisi.Parameters.AddWithValue("@tc", GetTextBoxValue(componentsForKisi(0)))
                    commandKisi.Parameters.AddWithValue("@adi", GetTextBoxValue(componentsForKisi(1)))
                    commandKisi.Parameters.AddWithValue("@soyadi", GetTextBoxValue(componentsForKisi(2)))
                    commandKisi.Parameters.AddWithValue("@telefon", GetTextBoxValue(componentsForKisi(3)))
                    commandKisi.Parameters.AddWithValue("@email", GetTextBoxValue(componentsForKisi(4)))
                    commandKisi.Parameters.AddWithValue("@dogum_tarihi", GetDateTimePickerValue(componentsForKisi(5)))
                    commandKisi.Parameters.AddWithValue("@aciklama", GetTextBoxValue(componentsForKisi(6)))
                    commandKisi.Parameters.AddWithValue("@cinsiyet", GetRadioButtonValue(componentsForKisi(7), componentsForKisi(8)))
                    commandKisi.Parameters.AddWithValue("@kisi_tipi", GetComboBoxValue(componentsForKisi(9)))

                    commandKisi.ExecuteNonQuery()
                End Using

                Using commandAdres As New SqlCommand(queryAdresString, connection, transaction)


                    commandAdres.Parameters.AddWithValue("@il", GetComboBoxValue(componentsForAdres(0)))
                    commandAdres.Parameters.AddWithValue("@ilce", GetComboBoxValue(componentsForAdres(1)))
                    commandAdres.Parameters.AddWithValue("@mahalle", GetComboBoxValue(componentsForAdres(2)))
                    commandAdres.Parameters.AddWithValue("@sokak", GetTextBoxValue(componentsForAdres(3)))
                    commandAdres.Parameters.AddWithValue("@bina", GetTextBoxValue(componentsForAdres(4)))
                    commandAdres.Parameters.AddWithValue("@daire", GetTextBoxValue(componentsForAdres(5)))
                    commandAdres.Parameters.AddWithValue("@acikAdres", GetTextBoxValue(componentsForAdres(6)))
                    commandAdres.Parameters.AddWithValue("@kisiTc", GetTextBoxValue(componentsForAdres(7)))

                    commandAdres.ExecuteNonQuery()
                End Using

                transaction.Commit()

                Return True
            Catch ex As Exception
                MessageBox.Show("Veri eklenirken bir hata oluştu: " & ex.Message)
                Return False
            End Try
        End Using
    End Function


    Private Sub EmlakciEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", ilComboBox)
    End Sub

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

    Private Sub ilComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilComboBox.SelectedIndexChanged
        veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + ilComboBox.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilceComboBox)
    End Sub


    Private Sub ilceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilceComboBox.SelectedIndexChanged
        veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilceComboBox.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalleComboBox)

    End Sub

    Private Sub telTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If telTextBox.TextLength >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub adTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles adTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

        If adTextBox.TextLength >= 250 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub soyadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles soyadTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

        If soyadTextBox.TextLength >= 250 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub tcTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Function TelefonNumarasiDogrula(telefonNumarasi As String) As Boolean
        ' Türkiye'deki alan kodları için geçerli alan kodlarını kontrol et
        Dim gecerliAlanKodlari As String() = {"050", "051", "052", "053", "054", "055", "056", "057", "058", "059", "0212", "0232", "0222", "0266", "0216", "0312", "0314", "0316", "0318", "0322", "0324", "0332", "0342", "0352", "0362", "0372", "0382", "0412", "0422", "0462", "0472", "0482", "0492", "0532", "0542", "0552", "0562", "0570", "0216", "0224", "0228", "0242", "0248", "0252", "0256", "0262", "0264", "0282", "0286", "0288", "0292", "0296"}
        Dim alanKodu As String
        If telefonNumarasi.Length > 2 Then
            alanKodu = telefonNumarasi.Substring(0, 3)
            If Not gecerliAlanKodlari.Contains(alanKodu) Then
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.")
                Return False
            End If
        Else
            MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.")
            Return False
        End If

        ' Geçerli bir telefon numarası
        Return True
    End Function

    Private Function EpostaDogrula(eposta As String) As Boolean
        Try
            Dim mailAddress As New System.Net.Mail.MailAddress(eposta)
            Return True
        Catch ex As Exception
            MessageBox.Show("Email bilgisi doğru girilmedi")
            Return False
        End Try
    End Function

    Private Sub binaNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles binaNoTextBox.KeyPress
        If sender.TextLength >= 100 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub daireNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles daireNoTextBox.KeyPress
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
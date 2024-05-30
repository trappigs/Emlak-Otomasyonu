Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class KonutEkle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim konutComponents() As Control = {yapim_YiliDateTimePicker, odaSayisiTextBox, bulunduguKatTextBox, binaKatSayisiTextBox, isitmaTextBox, banyoSayisiTextBox, balkonTextBox, asansorEvetRadioButton, asansorHayirRadioButton, otoparkTextBox, esyaEvetRadioButton, esyaHayirRadioButton, aidatTextBox, aciklamaTextBox, alanTextBox, tcComboBox}
        Dim adresComponents() As Control = {ilComboBox, ilceComboBox, mahalleComboBox, sokakTextBox, binaNoTextBox, daireNoTextBox, acikAdresTextBox}
        If KonutEkle(Me, konutComponents, adresComponents) Then
            MessageBox.Show("Veri başarıyla eklendi.")
        End If
    End Sub

    Dim lastAddressId As Integer
    Function KonutEkle(form As Form, componentsForKonut() As Control, componentsForAdres() As Control) As Boolean
        Dim queryKonutString As String = "INSERT INTO konutlar (bina_yapim_yili, oda_sayisi, bulundugu_kat, bina_kat_sayisi, isitma, banyo_sayisi, balkon_sayisi, asansor_var_mi, otopark, esyali_mi, aidat_ucret, aciklama, alan, emlak_sahibi_tc, cephe, aktiflik) VALUES (@bina_yapim_yili, @oda_sayisi, @bulundugu_kat, @bina_kat_sayisi, @isitma, @banyo_sayisi, @balkon_sayisi, @asansor_var_mi, @otopark, @esyali_mi, @aidat_ucret, @aciklama, @alan, @emlak_sahibi_tc, @cephe, 1);" & "SELECT SCOPE_IDENTITY()"
        Dim queryAdresString As String = "INSERT INTO adres (il_adi, ilce_adi, mahalle_adi, sokak_adi, bina_no, daire_no, acik_adres, kisi_tc, konut_id) VALUES (@il, @ilce, @mahalle, @sokak, @bina, @daire, @acikAdres, @kisi_tc, @konut_id)"


        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try

                Using commendKonut As New SqlCommand(queryKonutString, connection, transaction)

                    commendKonut.Parameters.AddWithValue("@bina_yapim_yili", KisiEkle.GetDateTimePickerValue(componentsForKonut(0)))
                    commendKonut.Parameters.AddWithValue("@oda_sayisi", KisiEkle.GetTextBoxValue(componentsForKonut(1)))
                    commendKonut.Parameters.AddWithValue("@bulundugu_kat", KisiEkle.GetTextBoxValue(componentsForKonut(2)))
                    commendKonut.Parameters.AddWithValue("@bina_kat_sayisi", KisiEkle.GetTextBoxValue(componentsForKonut(3)))
                    commendKonut.Parameters.AddWithValue("@isitma", KisiEkle.GetTextBoxValue(componentsForKonut(4)))
                    commendKonut.Parameters.AddWithValue("@banyo_sayisi", KisiEkle.GetTextBoxValue(componentsForKonut(5)))
                    commendKonut.Parameters.AddWithValue("@balkon_sayisi", KisiEkle.GetTextBoxValue(componentsForKonut(6)))
                    commendKonut.Parameters.AddWithValue("@asansor_var_mi", KisiEkle.GetRadioButtonValue(componentsForKonut(7), componentsForKonut(8)))
                    commendKonut.Parameters.AddWithValue("@otopark", KisiEkle.GetTextBoxValue(componentsForKonut(9)))
                    commendKonut.Parameters.AddWithValue("@esyali_mi", KisiEkle.GetRadioButtonValue(componentsForKonut(10), componentsForKonut(11)))
                    commendKonut.Parameters.AddWithValue("@aidat_ucret", KisiEkle.GetTextBoxValue(componentsForKonut(12)))
                    commendKonut.Parameters.AddWithValue("@aciklama", KisiEkle.GetTextBoxValue(componentsForKonut(13)))
                    commendKonut.Parameters.AddWithValue("@alan", KisiEkle.GetTextBoxValue(componentsForKonut(14)))
                    commendKonut.Parameters.AddWithValue("@emlak_sahibi_tc", tcComboBox.SelectedValue.ToString())
                    commendKonut.Parameters.AddWithValue("@cephe", cepheComboBox.Text)

                    lastAddressId = Convert.ToInt32(commendKonut.ExecuteScalar())
                End Using


                Using commandAdres As New SqlCommand(queryAdresString, connection, transaction)

                    commandAdres.Parameters.AddWithValue("@il", KisiEkle.GetComboBoxValue(componentsForAdres(0)))
                    commandAdres.Parameters.AddWithValue("@ilce", KisiEkle.GetComboBoxValue(componentsForAdres(1)))
                    commandAdres.Parameters.AddWithValue("@mahalle", KisiEkle.GetComboBoxValue(componentsForAdres(2)))
                    commandAdres.Parameters.AddWithValue("@sokak", KisiEkle.GetTextBoxValue(componentsForAdres(3)))
                    commandAdres.Parameters.AddWithValue("@bina", KisiEkle.GetTextBoxValue(componentsForAdres(4)))
                    commandAdres.Parameters.AddWithValue("@daire", KisiEkle.GetTextBoxValue(componentsForAdres(5)))
                    commandAdres.Parameters.AddWithValue("@acikAdres", KisiEkle.GetTextBoxValue(componentsForAdres(6)))
                    commandAdres.Parameters.AddWithValue("@kisi_tc", tcComboBox.SelectedValue.ToString())
                    commandAdres.Parameters.AddWithValue("@konut_id", lastAddressId)

                    commandAdres.ExecuteNonQuery()
                End Using

                transaction.Commit()

                Return True
            Catch ex As Exception
                MessageBox.Show("Veritabanına veri eklenirken bir hata oluştu: " & ex.Message)
            End Try

        End Using

        Return False
    End Function


    Dim connectionString As String = "Data Source=BU2-C-000WY\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"
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

    Private Sub KonutEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", ilComboBox)

        veriDoldur("select cephe_adi, cephe_id from cephe", "cephe_adi", "cephe_id", "cephe", cepheComboBox)

        veriDoldur("select adi, kisi_tc from kisiler where kisi_tipi=N'müşteri'", "adi", "kisi_tc", "kisiler", tcComboBox)
    End Sub

    Private Sub ilComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilComboBox.SelectedIndexChanged
        veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + ilComboBox.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilceComboBox)
    End Sub

    Private Sub ilceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilceComboBox.SelectedIndexChanged
        veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilceComboBox.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalleComboBox)
    End Sub




    Private imagePaths As New List(Of String)()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Multiselect = True
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Seçilen dosya yollarını listeye ekleyin
                For Each file In openFileDialog.FileNames
                    imagePaths.Add(file)
                Next


            End If
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If imagePaths.Count > 0 Then
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Dim fotoSayisiSorgu As String = "select count(*) from fotograflar where isyeri_id = " & lastAddressId

                Dim fotoSayisi As Integer

                Try
                    Using countCheckCommand As New SqlCommand(fotoSayisiSorgu, connection, transaction)
                        fotoSayisi = Convert.ToInt32(countCheckCommand.ExecuteScalar())
                    End Using


                    If (fotoSayisi + imagePaths.Count) <= 10 Then
                        ' Her resim için ayrı bir kayıt oluşturun
                        For Each path In imagePaths

                            ' Resmi veritabanına eklemek için bir SQL komutunu oluşturun ve çalıştırın
                            Dim imageQuery As String = "INSERT INTO fotograflar (isyeri_id, dosya_yolu) VALUES (@emlak_id, @dosya_yolu)"
                            Using imageCommand As New SqlCommand(imageQuery, connection, transaction)
                                imageCommand.Parameters.AddWithValue("@emlak_id", lastAddressId)
                                imageCommand.Parameters.AddWithValue("@dosya_yolu", path)
                                imageCommand.ExecuteNonQuery()
                            End Using
                        Next

                        transaction.Commit()
                        MessageBox.Show("Resimler başarıyla kaydedildi.")
                    Else
                        transaction.Rollback()
                        MessageBox.Show("Bir emlak için en fazla 10 resim eklenebilir.")
                    End If
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Veritabanına resimler kaydedilirken bir hata oluştu: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Lütfen en az bir resim seçin.")
        End If
    End Sub

    Private Sub otoparkTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles otoparkTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            ErrorProvider1.SetError(otoparkTextBox, "Sayı yazamazsınız")
        Else
            ' Değilse, işlemi izin ver ve hata mesaj balonunu kaldır
            e.Handled = False
            ErrorProvider1.SetError(otoparkTextBox, "")
        End If
    End Sub

    Private Sub odaSayisiTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles odaSayisiTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub bulunduguKatTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bulunduguKatTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub binaKatSayisiTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles binaKatSayisiTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub banyoSayisiTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles banyoSayisiTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub balkonTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles balkonTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub aidatTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles aidatTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If
    End Sub

    Private Sub alanTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alanTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If
    End Sub

    Private Sub isitmaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles isitmaTextBox.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Diğer tuş vuruşlarını engelle
            e.Handled = True
        End If

        If sender.TextLength >= 50 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub daireNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles daireNoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 5 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class ArsaEkle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arsaComponents() As Control = {imarComboBox, adaNoTextBox, parselNoTextBox, kaksComboBox, gabariComboBox, tapuComboBox, aciklamaTextBox, alanTextBox}
        Dim adresComponents() As Control = {ilComboBox, ilceComboBox, mahalleComboBox, sokakTextBox, binaNoTextBox, daireNoTextBox, acikAdresTextBox}
        If ArsaEkle(Me, arsaComponents, adresComponents) Then
            MessageBox.Show("Veri başarıyla eklendi.")
        End If
    End Sub



    Dim connectionString As String = "Data Source=BU2-C-000WY\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"
    Dim lastAddressId As Integer

    Function ArsaEkle(form As Form, componentsForArsa() As Control, componentsForAdres() As Control) As Boolean
        Dim queryArsaString As String = "INSERT INTO arsa (imar_cesidi, ada_no, parsel_no, kaks_degeri, gabari_degeri, tapu_durumu, aciklama, alan, emlak_aktiflik_bilgisi, emlak_sahibi_tc) VALUES (@imar, @adaNo, @parselNo, @kaks, @gabari, @tapu, @aciklama, @alan, 1, @tc);" & "SELECT SCOPE_IDENTITY()"
        Dim queryAdresString As String = "INSERT INTO adres (il_adi, ilce_adi, mahalle_adi, sokak_adi, bina_no, daire_no, acik_adres, kisi_tc, arsa_id) VALUES (@il, @ilce, @mahalle, @sokak, @bina, @daire, @acikAdres, @tc_kimlik, @arsa_id)"


        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try

                Using commandArsa As New SqlCommand(queryArsaString, connection, transaction)

                    commandArsa.Parameters.AddWithValue("@imar", KisiEkle.GetComboBoxValue(componentsForArsa(0)))
                    commandArsa.Parameters.AddWithValue("@adaNo", Convert.ToInt32(KisiEkle.GetTextBoxValue(componentsForArsa(1))))
                    commandArsa.Parameters.AddWithValue("@parselNo", Convert.ToInt32(KisiEkle.GetTextBoxValue(componentsForArsa(2))))
                    commandArsa.Parameters.AddWithValue("@kaks", Convert.ToDouble(KisiEkle.GetComboBoxValue(componentsForArsa(3))))
                    commandArsa.Parameters.AddWithValue("@gabari", Convert.ToDouble(KisiEkle.GetComboBoxValue(componentsForArsa(4))))
                    commandArsa.Parameters.AddWithValue("@tapu", KisiEkle.GetComboBoxValue(componentsForArsa(5)))
                    commandArsa.Parameters.AddWithValue("@aciklama", KisiEkle.GetTextBoxValue(componentsForArsa(6)))
                    commandArsa.Parameters.AddWithValue("@alan", KisiEkle.GetTextBoxValue(componentsForArsa(7)))
                    commandArsa.Parameters.AddWithValue("@tc", tcComboBox.SelectedValue.ToString())


                    lastAddressId = Convert.ToInt32(commandArsa.ExecuteScalar())
                End Using


                Using commandAdres As New SqlCommand(queryAdresString, connection, transaction)

                    commandAdres.Parameters.AddWithValue("@il", KisiEkle.GetComboBoxValue(componentsForAdres(0)))
                    commandAdres.Parameters.AddWithValue("@ilce", KisiEkle.GetComboBoxValue(componentsForAdres(1)))
                    commandAdres.Parameters.AddWithValue("@mahalle", KisiEkle.GetComboBoxValue(componentsForAdres(2)))
                    commandAdres.Parameters.AddWithValue("@sokak", KisiEkle.GetTextBoxValue(componentsForAdres(3)))
                    commandAdres.Parameters.AddWithValue("@bina", KisiEkle.GetTextBoxValue(componentsForAdres(4)))
                    commandAdres.Parameters.AddWithValue("@daire", KisiEkle.GetTextBoxValue(componentsForAdres(5)))
                    commandAdres.Parameters.AddWithValue("@acikAdres", KisiEkle.GetTextBoxValue(componentsForAdres(6)))
                    commandAdres.Parameters.AddWithValue("@tc_kimlik", tcComboBox.SelectedValue.ToString())
                    commandAdres.Parameters.AddWithValue("@arsa_id", lastAddressId)

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

    Private Sub ArsaEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", ilComboBox)
        veriDoldur("select imar_cesidi, imar_cesidi_id from imar_durumlari", "imar_cesidi", "imar_cesidi_id", "imar_durumlari", imarComboBox)
        veriDoldur("select kaks_degeri, kaks_id from kaks_bilgi", "kaks_degeri", "kaks_id", "kaks_bilgi", kaksComboBox)
        veriDoldur("select gabari_degeri, gabari_id from gabari_bilgi", "gabari_degeri", "gabari_id", "gabari_bilgi", gabariComboBox)
        veriDoldur("select tapu_durum_id, tapu_aciklama from tapu_durumu", "tapu_aciklama", "tapu_durum_id", "tapu_durumu", tapuComboBox)
        veriDoldur("select adi, kisi_tc from kisiler where kisi_tipi=N'müşteri'", "adi", "kisi_tc", "kisiler", tcComboBox)
    End Sub

    Private Sub ilComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilComboBox.SelectedIndexChanged
        veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + ilComboBox.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilceComboBox)
    End Sub

    Private Sub ilceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilceComboBox.SelectedIndexChanged
        veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilceComboBox.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalleComboBox)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

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

                Dim fotoSayisiSorgu As String = "select count(*) from fotograflar where arsa_id = " & lastAddressId

                Dim fotoSayisi As Integer

                Try
                    Using countCheckCommand As New SqlCommand(fotoSayisiSorgu, connection, transaction)
                        fotoSayisi = Convert.ToInt32(countCheckCommand.ExecuteScalar())
                    End Using


                    If (fotoSayisi + imagePaths.Count) <= 10 Then
                        ' Her resim için ayrı bir kayıt oluşturun
                        For Each path In imagePaths

                            ' Resmi veritabanına eklemek için bir SQL komutunu oluşturun ve çalıştırın
                            Dim imageQuery As String = "INSERT INTO fotograflar (arsa_id, dosya_yolu) VALUES (@emlak_id, @dosya_yolu)"
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

    Private Sub adaNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles adaNoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 7 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub parselNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles parselNoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 7 AndAlso Not Char.IsControl(e.KeyChar) Then
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

    Private Sub daireNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles daireNoTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Girilen karakter bir sayı değilse ve kontrol karakteri de değilse
            ' Tuş vuruşunu reddetmek için Handle özelliğini true olarak ayarla
            e.Handled = True
        End If

        If sender.TextLength >= 3 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
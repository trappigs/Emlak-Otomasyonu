Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class sqlAlSatKira
    Public Shared connectionString As String = "Data Source=DESKTOP-J5GMTR7\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"

    Public Shared Sub Kiralama(alanTc As ComboBox, satanTc As ComboBox, emlakciTc As ComboBox, emlakTuru As String, kiraUcreti As String, depozitoUcreti As String, id As String)
        Dim sorgu As String = "INSERT INTO alim_satim_kiralama (alan_musteri_tc, satan_musteri_tc, emlakci_tc, yapilan_islem, kira_ucreti, depozito_ucreti, "

        If emlakTuru = "arsa" Then
            sorgu += "arsa_id, islem_tarihi) VALUES (@alanMusteri, @satanMusteri, @emlakci, @yapilanIslem, @kiraUcreti, @depozitoUcreti, @id, '" & DateTime.Today & "')"
        ElseIf emlakTuru = "konut" Then
            sorgu += "konut_id, islem_tarihi) VALUES (@alanMusteri, @satanMusteri, @emlakci, @yapilanIslem, @kiraUcreti, @depozitoUcreti, @id, '" & DateTime.Today & "')"
        ElseIf emlakTuru = "isyeri" Then
            sorgu += "isyeri_id, islem_tarihi) VALUES (@alanMusteri, @satanMusteri, @emlakci, @yapilanIslem, @kiraUcreti, @depozitoUcreti, @id, '" & DateTime.Today & "')"
        End If

        Using connection As New SqlConnection(connectionString)
            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try
                connection.Open()

                Using command As New SqlCommand(sorgu, connection, transaction)
                    ' Parametreleri ekle
                    command.Parameters.AddWithValue("@alanMusteri", alanTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@satanMusteri", satanTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@emlakci", emlakciTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@yapilanIslem", "Kiralama")
                    command.Parameters.AddWithValue("@kiraUcreti", kiraUcreti)
                    command.Parameters.AddWithValue("@depozitoUcreti", depozitoUcreti)
                    command.Parameters.AddWithValue("@id", id)
                    ' Komutu çalıştır
                    command.ExecuteNonQuery()
                End Using
                transaction.Commit()
                MessageBox.Show("Veri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Veri eklenirken bir hata oluştu ve işlem geri alındı: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Function Kontrol() As Integer
        Dim sorgu As String = "select arsa_id, isyeri_id konut_id from alim_satim_kiralama"

        Dim arsaList As New List(Of Integer)()
        Dim konutList As New List(Of Integer)()
        Dim isyeriList As New List(Of Integer)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Try
                Using commandKisi As New SqlCommand(sorgu, connection)
                    Using reader As SqlDataReader = commandKisi.ExecuteReader()
                        ' DataGridView'e sonuçları aktarın
                        While reader.Read()
                            If Not reader.IsDBNull(reader.GetOrdinal("arsa_id")) Then
                                arsaList.Add(reader.GetInt32(reader.GetOrdinal("arsa_id")))
                            End If

                            If Not reader.IsDBNull(reader.GetOrdinal("konut_id")) Then
                                konutList.Add(reader.GetInt32(reader.GetOrdinal("konut_id")))
                            End If

                            If Not reader.IsDBNull(reader.GetOrdinal("isyeri_id")) Then
                                isyeriList.Add(reader.GetInt32(reader.GetOrdinal("isyeri_id")))
                            End If
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
        Return 0
    End Function


    Public Shared Sub aktiflikGuncelleme(id As String, tabloAdi As String)
        Dim query As String = ""

        If tabloAdi = "arsa" Then
            query = "UPDATE arsa SET aktiflik = 0 WHERE arsa_id = @id"
        ElseIf tabloAdi = "konut" Then
            query = "UPDATE konutlar SET aktiflik = 0 WHERE konut_id = @id"
        ElseIf tabloAdi = "isyeri" Then
            query = "UPDATE isyeri SET aktiflik = 0 WHERE isyeri_id = @id"
        End If

        Using connection As New SqlConnection(connectionString)
            Dim transaction As SqlTransaction = Nothing

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                Using command As New SqlCommand(query, connection, transaction)
                    ' Parametreleri ekle
                    command.Parameters.AddWithValue("@id", id)
                    ' Güncelleme sorgusunu çalıştır
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    MessageBox.Show(query)
                    If rowsAffected > 0 Then
                        ' İşlemi commit et
                        transaction.Commit()
                    Else
                        MessageBox.Show("Güncellenecek kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                ' Hata durumunda işlemi geri al
                If transaction IsNot Nothing Then
                    transaction.Rollback()
                End If

                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu ve işlem geri alındı: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Public Shared Function Satis(alanTc As ComboBox, satanTc As ComboBox, emlakciTc As ComboBox, emlakTuru As String, satisUcreti As Double, kiraUcreti As Double, depozitoUcreti As Double, id As String) As Boolean
        Dim sorgu As String = "INSERT INTO alim_satim_kiralama (alan_musteri_tc, satan_musteri_tc, emlakci_tc, "
        Dim islem As String
        If kiraUcreti = 0 And depozitoUcreti = 0 Then
            islem = "satis"
        Else
            islem = "kiralik"
        End If
        ') VALUES (@alanMusteri, @satanMusteri, @emlakci, @yapilanIslem, @satisUcreti, @id, '" & DateTime.Today & "')"

        If emlakTuru = "arsa" Then
            sorgu += "arsa_id, islem_tarihi"
        ElseIf emlakTuru = "konut" Then
            sorgu += "konut_id, islem_tarihi"
        ElseIf emlakTuru = "isyeri" Then
            sorgu += "isyeri_id, islem_tarihi"
        End If
        Dim bugun As String = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString()

        If islem = "kiralik" Then
            sorgu += ", yapilan_islem, kira_ucreti, depozito_ucreti) VALUES (@alanMusteri, @satanMusteri, @emlakci, @id, '" & bugun & "', @yapilanIslem, @kiraUcreti, @depozitoUcreti)"
        ElseIf islem = "satis" Then
            sorgu += ", yapilan_islem, satis_ucreti) VALUES (@alanMusteri, @satanMusteri, @emlakci, @id, '" & bugun & "', @yapilanIslem, @satisUcreti)"
        End If

        Using connection As New SqlConnection(connectionString)
            Dim transaction As SqlTransaction = Nothing

            Try
                connection.Open()
                transaction = connection.BeginTransaction()

                Using command As New SqlCommand(sorgu, connection, transaction)
                    ' Parametreleri ekle
                    command.Parameters.AddWithValue("@alanMusteri", alanTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@satanMusteri", satanTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@emlakci", emlakciTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@id", id)


                    If islem = "satis" Then
                        command.Parameters.AddWithValue("@yapilanIslem", "satis")
                        command.Parameters.AddWithValue("@satisUcreti", satisUcreti)
                    Else
                        command.Parameters.AddWithValue("@yapilanIslem", "kiralik")
                        command.Parameters.AddWithValue("@kiraUcreti", kiraUcreti)
                        command.Parameters.AddWithValue("@depozitoUcreti", depozitoUcreti)
                    End If

                    ' Komutu çalıştır
                    command.ExecuteNonQuery()
                End Using

                ' İşlemi commit et
                transaction.Commit()
                aktiflikGuncelleme(id, emlakTuru)
                MessageBox.Show("Veri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Catch ex As Exception
                ' Hata durumunda işlemi geri al
                If transaction IsNot Nothing Then
                    transaction.Rollback()
                End If

                MessageBox.Show("Veri eklenirken bir hata oluştu ve işlem geri alındı: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                ' Bağlantıyı kapat
                If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Function


End Class

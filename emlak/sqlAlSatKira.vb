Imports System.Data.SqlClient

Public Class sqlAlSatKira
    Public Shared connectionString As String = "Data Source=BU2-C-000WY\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True"

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

    Public Shared Sub Satis(alanTc As ComboBox, satanTc As ComboBox, emlakciTc As ComboBox, emlakTuru As String, satisUcreti As String, id As String)
        Dim sorgu As String = "INSERT INTO alim_satim_kiralama (alan_musteri_tc, satan_musteri_tc, emlakci_tc, ) VALUES ()"

        If emlakTuru = "arsa" Then
            sorgu += "arsa_id, islem_tarihi) VALUES (@alanMusteri, @satanMusteri, @emlakci, @yapilanIslem, @satisUcreti, @id, '" & DateTime.Today & "')"
        ElseIf emlakTuru = "konut" Then
            sorgu += "konut_id, islem_tarihi) VALUES (@alanMusteri, @satanMusteri, @emlakci, @yapilanIslem, @satisUcreti, @id, '" & DateTime.Today & "')"
        ElseIf emlakTuru = "isyeri" Then
            sorgu += "isyeri_id, islem_tarihi) VALUES (@alanMusteri, @satanMusteri, @emlakci, @yapilanIslem, @satisUcreti, @id, '" & DateTime.Today & "')"
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(sorgu, connection)
                    ' Parametreleri ekle
                    command.Parameters.AddWithValue("@alanMusteri", alanTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@satanMusteri", satanTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@emlakci", emlakciTc.SelectedValue.ToString())
                    command.Parameters.AddWithValue("@yapilanIslem", "Satis")
                    command.Parameters.AddWithValue("@satisUcreti", satisUcreti)
                    command.Parameters.AddWithValue("@id", id)
                    ' Komutu çalıştır
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Veri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Veri eklenirken bir hata oluştu ve işlem geri alındı: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


    End Sub


End Class

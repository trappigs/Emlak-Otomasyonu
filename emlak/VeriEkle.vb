Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VeriEkle
    'Sub EmlakciEkle(Text As Int16)
    '    Dim ad As String = txtAd.Text
    '    Dim soyad As String = txtSoyad.Text
    '    Dim yas As Integer

    '    If Integer.TryParse(txtYas.Text, yas) Then
    '        Dim queryString As String = "INSERT INTO TableName (Ad, Soyad, Yas) VALUES (@Ad, @Soyad, @Yas)"

    '        Using connection As New SqlConnection(connectionString)
    '            Using command As New SqlCommand(queryString, connection)
    '                command.Parameters.AddWithValue("@Ad", ad)
    '                command.Parameters.AddWithValue("@Soyad", soyad)
    '                command.Parameters.AddWithValue("@Yas", yas)

    '                Try
    '                    connection.Open()
    '                    command.ExecuteNonQuery()
    '                    MessageBox.Show("Veri başarıyla eklendi.")
    '                Catch ex As Exception
    '                    MessageBox.Show("Veri eklenirken bir hata oluştu: " & ex.Message)
    '                End Try
    '            End Using
    '        End Using
    '    Else
    '        MessageBox.Show("Yaş alanına sayısal bir değer giriniz.")
    '    End If


    'End Sub
End Class

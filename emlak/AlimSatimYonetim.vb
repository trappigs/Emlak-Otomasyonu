Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography

Public Class AlimSatimYonetim
    Private Sub AlimSatimYonetim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = doldurDGV()
    End Sub

    Dim connectionString As String = "Data Source=DESKTOP-J5GMTR7\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"
    Dim connection As New SqlConnection(connectionString)

    Dim isyeriList As New List(Of Integer)()

    Sub Guncelle()
        Dim query As String = "update alim_satim_kiralama set alan_musteri_tc = @alanTc, satan_musteri_tc = @satanTc, emlakci_tc = @emlakciTc, konut_id = @konutId, isyeri_id = @isyeriId, arsa_id = @arsaId, depozito_ucreti = @depozitoUcreti, kira_ucreti = @kiraUcreti, islem_tarihi = @islemTarihi, yapilan_islem = @yapilanIslem, satis_ucreti = @satisUcreti WHERE islem_id = @IslemId"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Try
                For Each row As List(Of String) In matrix
                    Dim sayac As Integer = 0

                    Using alSatGuncelle As New SqlCommand(query, connection, transaction)
                        Try
                            alSatGuncelle.Parameters.Add("@IslemId", SqlDbType.BigInt).Value = Convert.ToUInt64(row(0))
                        Catch ex As Exception
                            MessageBox.Show("Error converting @IslemId: " & ex.Message)
                        End Try

                        Try
                            alSatGuncelle.Parameters.Add("@alanTc", SqlDbType.VarChar, 11).Value = row(1)
                        Catch ex As Exception
                            MessageBox.Show("Error converting @alanTc: " & ex.Message)
                        End Try

                        Try
                            alSatGuncelle.Parameters.Add("@satanTc", SqlDbType.VarChar, 11).Value = row(2)
                        Catch ex As Exception
                            MessageBox.Show("Error converting @satanTc: " & ex.Message)
                        End Try

                        Try
                            alSatGuncelle.Parameters.Add("@emlakciTc", SqlDbType.VarChar, 11).Value = row(3)
                        Catch ex As Exception
                            MessageBox.Show("Error converting @emlakciTc: " & ex.Message)
                        End Try

                        Try
                            If row(4).ToString() IsNot "" Then
                                alSatGuncelle.Parameters.Add("@konutId", SqlDbType.BigInt).Value = Convert.ToUInt64(row(4))
                                sayac += 1
                            Else
                                alSatGuncelle.Parameters.Add("@konutId", SqlDbType.BigInt).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @konutId: " & ex.Message)
                        End Try

                        Try
                            If row(5).ToString() IsNot "" Then
                                alSatGuncelle.Parameters.Add("@isyeriId", SqlDbType.BigInt).Value = Convert.ToUInt64(row(5))
                                sayac += 1
                            Else
                                alSatGuncelle.Parameters.Add("@isyeriId", SqlDbType.BigInt).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @isyeriId: " & ex.Message)
                        End Try

                        Try
                            If row(6).ToString() IsNot "" Then
                                alSatGuncelle.Parameters.Add("@arsaId", SqlDbType.BigInt).Value = Convert.ToUInt64(row(6))
                                sayac += 1
                            Else
                                alSatGuncelle.Parameters.Add("@arsaId", SqlDbType.BigInt).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @arsaId: " & ex.Message)
                        End Try

                        If sayac > 1 Then
                            MessageBox.Show("Aynı anda sadece bir mülkle ilgili işlem yapılabilir!")
                            transaction.Rollback()
                            Exit Sub
                        End If
                        Dim kira, depozito, satis As Boolean
                        Try
                            If row(7).ToString() IsNot "" Then
                                alSatGuncelle.Parameters.Add("@depozitoUcreti", SqlDbType.Decimal).Value = Convert.ToDecimal(row(7))
                                depozito = True
                            Else
                                depozito = False
                                alSatGuncelle.Parameters.Add("@depozitoUcreti", SqlDbType.Decimal).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @depozitoUcreti: " & ex.Message)
                        End Try

                        Try
                            If row(8).ToString() IsNot "" Then
                                alSatGuncelle.Parameters.Add("@kiraUcreti", SqlDbType.Decimal).Value = Convert.ToDecimal(row(8))
                                sayac += 1
                                kira = True
                            Else
                                kira = False
                                alSatGuncelle.Parameters.Add("@kiraUcreti", SqlDbType.Decimal).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @kiraUcreti: " & ex.Message)
                        End Try

                        Try
                            If row(9).ToString() IsNot "" Then
                                If Convert.ToDateTime(row(9)) > DateTime.Now Then
                                    MessageBox.Show("İşlem tarihi bugünden büyük olamaz. Güncelleme işlemi iptal edildi.")
                                    transaction.Rollback()
                                    Exit Sub
                                End If
                                alSatGuncelle.Parameters.Add("@islemTarihi", SqlDbType.DateTime).Value = Convert.ToDateTime(row(9))
                            Else
                                alSatGuncelle.Parameters.Add("@islemTarihi", SqlDbType.DateTime).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @islemTarihi: " & ex.Message)
                        End Try

                        Try
                            If row(10).ToString() IsNot "" Then
                                alSatGuncelle.Parameters.Add("@yapilanIslem", SqlDbType.NVarChar, 50).Value = row(10)
                            Else
                                alSatGuncelle.Parameters.Add("@yapilanIslem", SqlDbType.NVarChar, 50).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @yapilanIslem: " & ex.Message)
                        End Try

                        Try
                            If row(11).ToString() IsNot "" Then
                                alSatGuncelle.Parameters.Add("@satisUcreti", SqlDbType.Decimal).Value = Convert.ToDecimal(row(11))
                                sayac += 1
                                satis = True
                            Else
                                satis = False
                                alSatGuncelle.Parameters.Add("@satisUcreti", SqlDbType.Decimal).Value = DBNull.Value
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error converting @satisUcreti: " & ex.Message)
                        End Try

                        'MessageBox.Show(kira.ToString() + " - " + depozito.ToString() + " - " + satis.ToString())
                        If kira = True AndAlso depozito = True AndAlso satis = False Then

                        ElseIf kira = False AndAlso depozito = False AndAlso satis = True Then

                        Else
                            MessageBox.Show("Miktar bilgileri yanlış girildi. Güncelleme işlemi iptal edildi.")
                            transaction.Rollback()
                            Exit Sub
                        End If
                        ' Hata ayıklama amacıyla sorguyu göstermek
                        'Dim completeQuery As String = query
                        'For Each param As SqlParameter In alSatGuncelle.Parameters
                        '    completeQuery = completeQuery.Replace(param.ParameterName, "'" & param.Value.ToString() & "'")
                        'Next
                        'MessageBox.Show(completeQuery)

                        alSatGuncelle.ExecuteNonQuery()
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




    Dim matrix As New List(Of List(Of String))

    Function doldurDGV() As DataTable
        Dim queryAlSat As String = "select * from alim_satim_kiralama"

        Dim dtKisi As New DataTable()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Try
                Using commandKisi As New SqlCommand(queryAlSat, connection)
                    Using reader As SqlDataReader = commandKisi.ExecuteReader()
                        ' DataGridView'e sonuçları aktarın
                        dtKisi.Load(reader)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using

        MessageBox.Show(queryAlSat)
        If dtKisi.Rows.Count > 0 Then
            Return dtKisi
        Else
            MessageBox.Show("Kayıt bulunamadı.")
            Return Nothing
        End If
    End Function

    Sub guncelleDGVDoldur()
        matrix = New List(Of List(Of String))
        Dim eklenenler As String = ""
        For Each dgvRow As DataGridViewRow In DataGridView1.Rows
            Dim rowList As New List(Of String)()
            For Each dgvColumn As DataGridViewColumn In DataGridView1.Columns
                Dim columnName As String = dgvColumn.DataPropertyName
                Dim columnValue As Object = dgvRow.Cells(columnName).Value
                If columnValue IsNot Nothing Then
                    rowList.Add(columnValue.ToString())
                    'eklenenler += columnValue.ToString() + " - "
                Else
                    rowList.Add("")
                    'eklenenler += " - "
                End If
            Next
            'MessageBox.Show(eklenenler)
            'eklenenler = ""
            matrix.Add(rowList)
        Next

        'For Each item As List(Of String) In matrix
        '    For Each cellValue As String In item

        '    Next
        'Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        guncelleDGVDoldur()
        Guncelle()
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit

    End Sub
End Class
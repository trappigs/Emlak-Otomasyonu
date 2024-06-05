Imports System.Data.SqlClient
Imports System.Reflection

Public Class MusteriKisiselBilgi
    Private Sub MusteriKisiselBilgi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public ReadOnly Property adi As String
        Get
            Return adDegistirTextBox.Text
        End Get
    End Property

    Public ReadOnly Property soyadi As String
        Get
            Return soyadDegistirTextBox.Text
        End Get
    End Property

    Public ReadOnly Property telefon As String
        Get
            Return telefonDegistirTextBox.Text
        End Get
    End Property

    Public ReadOnly Property email As String
        Get
            Return emailDegistirTextBox.Text
        End Get
    End Property

    Public ReadOnly Property dogum_tarihi As String
        Get
            Return sqlAuth.dateForSQL(dogumDTP)
        End Get
    End Property

    Public ReadOnly Property cinsiyet As String
        Get
            If RadioButton4.Checked Then
                Return "Erkek"
            End If
            If RadioButton3.Checked Then
                Return "Kadın"
            End If
        End Get
    End Property

    Public ReadOnly Property sifre As String
        Get
            Return sifreDegistirTextBox.Text
        End Get
    End Property


    Dim kayitComponents As List(Of Control) = New List(Of Control)
    Dim adresComponents As List(Of Control) = New List(Of Control)
    Dim propertyNames As New List(Of PropertyInfo)()

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim type As Type = GetType(MusteriKisiselBilgi)

        ' Özellikleri alma
        Dim properties As PropertyInfo() = type.GetProperties()

        ' Özellik isimlerini bir listeye ekleme
        For Each prop As PropertyInfo In properties
            propertyNames.Add(prop)
        Next


    End Sub


    Dim connectionString As String = "Data Source=DESKTOP-J5GMTR7\SQLEXPRESS;Initial Catalog=emlakSon;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;"
    Dim connection As New SqlConnection(connectionString)

    Public Sub kisiselBilgiGuncelleme(kayitComps As List(Of Control), adresComps As List(Of Control))
        'Dim query As String = "UPDATE kisiler SET adi = @ad, soyadi = @soyad, telefon = @telefon, email = @email, dogum_tarihi = @dogum_tarihi, cinsiyet = @cinsiyet, sifre = @sifre WHERE kisi_tc = @kisi_tc"
        Dim query As String = ""
        For Each item As PropertyInfo In propertyNames
            If item.GetValue("") = "" Then

            End If
        Next

        For Each item As Control In kayitComps
            If TypeOf item Is TextBox Then
                If Not String.IsNullOrEmpty(DirectCast(item, TextBox).Text) Then
                    kayitComponents.Add(item)
                End If
            End If
        Next



        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Try
                Using command As New SqlCommand(query, connection, transaction)
                    command.Parameters.AddWithValue("@ad", kayitComps(1).Text)
                    command.Parameters.AddWithValue("@soyad", kayitComps(2).Text)
                    command.Parameters.AddWithValue("@telefon", kayitComps(3).Text)
                    command.Parameters.AddWithValue("@email", kayitComps(4).Text)
                    command.Parameters.AddWithValue("@dogum_tarihi", DirectCast(kayitComps(5), DateTimePicker).Value)
                    command.Parameters.AddWithValue("@cinsiyet", kayitComps(6).Text)
                    command.Parameters.AddWithValue("@sifre", kayitComps(8).Text)
                    command.Parameters.AddWithValue("@kisi_tc", kayitComps(0).Text)

                    command.ExecuteNonQuery()
                End Using

                transaction.Commit()
            Catch ex As Exception
                MessageBox.Show("Veri eklenirken bir hata oluştu: " & ex.Message)
                transaction.Rollback()
            End Try
        End Using


    End Sub

    Public Sub kisiselBilgiGetir()

    End Sub

End Class
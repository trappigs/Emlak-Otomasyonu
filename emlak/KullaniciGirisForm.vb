Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class KullaniciGirisForm
    Private Sub KullaniciGirisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim giris As Boolean = sqlAuth.GirisYapma(tcTextBox.Text, sifreTextBox.Text, "Müşteri")
        If giris Then
            Dim musteriGirisEkrani As New MusteriYonetim()
            musteriGirisEkrani.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim girisEkrani As New GirisEkrani()
        girisEkrani.Show()

        Me.Close()
    End Sub


End Class
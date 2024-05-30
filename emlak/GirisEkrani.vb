Public Class GirisEkrani
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ekle As New EmlakciGirisForm()
        ekle.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ekle As New KullaniciGirisForm()
        ekle.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ekle As New KullaniciKayit()
        ekle.Show()
        Me.Hide()
    End Sub
End Class
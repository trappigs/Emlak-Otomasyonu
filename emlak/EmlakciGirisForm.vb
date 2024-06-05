Public Class EmlakciGirisForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim giris As Boolean = sqlAuth.GirisYapma(tcTextBox.Text, sifreTextBox.Text, "Emlakçı")
        If giris Then
            Dim emlakciAnaEkran As New Form1()
            emlakciAnaEkran.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim girisEkrani As New GirisEkrani()
        girisEkrani.Show()

        Me.Close()
    End Sub
End Class
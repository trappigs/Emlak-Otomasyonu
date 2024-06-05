Public Class MusteriYonetim
    Sub FormGetir(frm As Form)
        Panel4.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        Panel4.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub arsaAramaButton_Click(sender As Object, e As EventArgs) Handles arsaAramaButton.Click
        Dim arsaListesi As New ArsaListesi()
        arsaListesi.Button2.Hide()
        FormGetir(arsaListesi)
        'arsaListesi.Button2.Hide()
    End Sub

    Private Sub isyeriAramaButton_Click(sender As Object, e As EventArgs) Handles isyeriAramaButton.Click
        Dim isyeriListesi As New isyeriListesi()
        isyeriListesi.Button2.Hide()
        FormGetir(isyeriListesi)
    End Sub

    Private Sub konutAramaButton_Click(sender As Object, e As EventArgs) Handles konutAramaButton.Click
        Dim konutListesi As New KonutListesi()
        konutListesi.Button2.Hide()
        FormGetir(konutListesi)
    End Sub

    Private Sub arsaEklemeButton_Click(sender As Object, e As EventArgs) Handles arsaEklemeButton.Click
        Dim arsaEkle As New ArsaEkle()
        FormGetir(arsaEkle)
    End Sub

    Private Sub isyeriEklemeButton_Click(sender As Object, e As EventArgs) Handles isyeriEklemeButton.Click
        Dim isyeriEkle As New isyeriEkle()
        FormGetir(isyeriEkle)
    End Sub

    Private Sub konutEklemeButton_Click(sender As Object, e As EventArgs) Handles konutEklemeButton.Click
        Dim konutEkle As New KonutEkle()
        FormGetir(konutEkle)
    End Sub

    Private Sub bilgiDuzenleButton_Click(sender As Object, e As EventArgs) Handles bilgiDuzenleButton.Click

    End Sub
End Class
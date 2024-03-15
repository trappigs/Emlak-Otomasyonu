Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub FormGetir(frm As Form)
        Panel2.Controls.Clear()
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        Panel2.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ekle As New EmlakciEkle()
        FormGetir(ekle)
    End Sub

    Private Sub musteriEkleBtn_Click(sender As Object, e As EventArgs) Handles musteriEkleBtn.Click
        Dim ekle As New MusteriEkle()
        FormGetir(ekle)
    End Sub

    Private Sub arsaEkleBtn_Click(sender As Object, e As EventArgs) Handles arsaEkleBtn.Click
        Dim ekle As New ArsaEkle()
        FormGetir(ekle)
    End Sub

    Private Sub konutEkleBtn_Click(sender As Object, e As EventArgs) Handles konutEkleBtn.Click
        Dim ekle As New KonutEkle()
        FormGetir(ekle)
    End Sub

    Private Sub isyeriEkleBtn_Click(sender As Object, e As EventArgs) Handles isyeriEkleBtn.Click
        Dim ekle As New isyeriEkle()
        FormGetir(ekle)
    End Sub

    Private Sub alSatKiralaBtn_Click(sender As Object, e As EventArgs) Handles alSatKiralaBtn.Click
        Dim ekle As New AlSatKirala()
        FormGetir(ekle)
    End Sub

    Private Sub musteriListesiBtn_Click(sender As Object, e As EventArgs) Handles musteriListesiBtn.Click
        Dim ekle As New MusteriListesi()
        FormGetir(ekle)
    End Sub

    Private Sub emlakciListesiBtn_Click(sender As Object, e As EventArgs) Handles emlakciListesiBtn.Click
        Dim ekle As New EmlakciListesi()
        FormGetir(ekle)
    End Sub

    Private Sub arsaListesiBtn_Click(sender As Object, e As EventArgs) Handles arsaListesiBtn.Click
        Dim ekle As New ArsaListesi()
        FormGetir(ekle)
    End Sub

    Private Sub konutListesiBtn_Click(sender As Object, e As EventArgs) Handles konutListesiBtn.Click
        Dim ekle As New KonutListesi()
        FormGetir(ekle)
    End Sub

    Private Sub isyeriListesiBtn_Click(sender As Object, e As EventArgs) Handles isyeriListesiBtn.Click
        Dim ekle As New isyeriListesi()
        FormGetir(ekle)
    End Sub

    Private Sub genelAramaBtn_Click(sender As Object, e As EventArgs) Handles genelAramaBtn.Click
        ' genel arama formu getirilsin
    End Sub
End Class

Public Class KullaniciKayit

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kayitComps As List(Of Control)
        Dim adresComps As List(Of Control)

        kayitComps = kayitComponentsChecker()
        adresComps = adresComponentsChecker()

        If kayitComps Is Nothing Then
            MessageBox.Show("Lütfen tüm alanları doldurunuz.")
            Exit Sub
        End If

        If adresComps Is Nothing Then
            MessageBox.Show("Lütfen tüm alanları doldurunuz.")
            Exit Sub
        End If

        Dim tt As String = ""
        For Each item As Control In kayitComps
            tt += item.Name + "-"
        Next
        MessageBox.Show(tt)

        Dim specialCharacters As String = "!@#$%^+"

        ' Özel karakterlerin olup olmadığını kontrol etmek için bir değişken
        Dim containsSpecialCharacter As Boolean = False

        ' sifreTextBox.Text içerisindeki her karakteri kontrol ediyoruz
        For Each ch As Char In sifreTextBox.Text
            If specialCharacters.Contains(ch) Then
                containsSpecialCharacter = True
                Exit For ' Bir tane bulduktan sonra döngüden çıkabiliriz
            End If
        Next

        ' Şifre uzunluğu 12 karakterden küçük veya özel karakter içermiyorsa
        If sifreTextBox.Text.Length < 12 OrElse Not containsSpecialCharacter Then
            ' Buraya gerekli işlemleri yazabilirsiniz
            MessageBox.Show("Şifre en az 12 karakter uzunluğunda olmalı ve en az bir özel karakter içermelidir.", "Geçersiz Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If emailTextBox.Text.Length < 12 OrElse Not emailTextBox.Text.Contains("@") Then
            MessageBox.Show("E-posta en az 12 karakter uzunluğunda olmalı ve '@' işaretini içermelidir.", "Geçersiz E-Posta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If telTextBox.Text.Length < 11 OrElse Not telTextBox.Text(0) = "0" OrElse Not telTextBox.Text(1) = "5" Then
            MessageBox.Show("Telefon numarası 11 hane olmalı ve '05' ile başlamalıdır.", "Geçersiz Telefon Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If tcTextBox.Text.Length < 11 Then
            MessageBox.Show("T.C. Kimlik Numarası 11 hane olmalıdır.", "Geçersiz T.C. Kimlik Numarası", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        sqlAuth.KayitOlma(kayitComps, adresComps)
        If sqlAuth.kayitBasari Then
            MessageBox.Show("Kayıt başarılı. Giriş yapabilirsiniz.")
            Dim yeniGirisEkrani As New GirisEkrani()
            yeniGirisEkrani.Show()

            Me.Hide()

        End If
    End Sub


    Dim kayitComponents As List(Of Control) = New List(Of Control)
    Dim adresComponents As List(Of Control) = New List(Of Control)

    Function kayitComponentsChecker() As List(Of Control)
        kayitComponents.Add(tcTextBox)
        kayitComponents.Add(adTextBox)
        kayitComponents.Add(soyadTextBox)
        kayitComponents.Add(telTextBox)
        kayitComponents.Add(emailTextBox)
        kayitComponents.Add(dogumDTP)

        If cinsiyetErkekRadio = True Then
            kayitComponents.Add(RadioButton1)
        ElseIf cinsiyetKadinRadio = True Then
            kayitComponents.Add(RadioButton2)
        Else
            Return Nothing
        End If

        kayitComponents.Add(kisiTipiComboBox)

        kayitComponents.Add(sifreTextBox)

        If componentChecker(kayitComponents) Then
            Return kayitComponents
        Else
            Return Nothing
        End If

        Return kayitComponents
    End Function

    Function componentChecker(components As List(Of Control)) As Boolean
        For Each ctrl As Control In components
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrEmpty(DirectCast(ctrl, TextBox).Text) Then
                    Return False
                End If
            End If

            If TypeOf ctrl Is ComboBox Then
                If String.IsNullOrEmpty(DirectCast(ctrl, ComboBox).Text) Then
                    Return False
                End If
            End If

            If TypeOf ctrl Is DateTimePicker Then
                'MessageBox.Show($"DateTimePicker: {DirectCast(ctrl, DateTimePicker).Value.ToShortDateString()}")
            End If
        Next

        Return True
    End Function


    Function adresComponentsChecker() As List(Of Control)
        adresComponents.Add(ilComboBox)
        adresComponents.Add(ilceComboBox)
        adresComponents.Add(mahalleComboBox)
        adresComponents.Add(sokakTextBox)
        adresComponents.Add(binaNoTextBox)
        adresComponents.Add(daireNoTextBox)
        adresComponents.Add(acikAdresTextBox)
        adresComponents.Add(tcTextBox)

        If componentChecker(adresComponents) Then
            Return adresComponents
        Else
            Return Nothing
        End If

        Return adresComponents
    End Function


    Dim cinsiyetErkekRadio As Boolean
    Dim cinsiyetKadinRadio As Boolean

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            cinsiyetErkekRadio = True
        Else
            cinsiyetErkekRadio = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            cinsiyetKadinRadio = True
        Else
            cinsiyetKadinRadio = False
        End If
    End Sub

    Private Sub ilComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilComboBox.SelectedIndexChanged
        sqlAuth.veriDoldur("select ilce_adi, ilce_id from ilceler where il_id =" + ilComboBox.SelectedValue.ToString(), "ilce_adi", "ilce_id", "ilceler", ilceComboBox)
    End Sub

    Private Sub ilceComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ilceComboBox.SelectedIndexChanged
        sqlAuth.veriDoldur("select mahalle_adi, mahalle_id from mahalle where ilce_id =" + ilceComboBox.SelectedValue.ToString(), "mahalle_adi", "mahalle_id", "mahalle", mahalleComboBox)
    End Sub

    Private Sub KullaniciKayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlAuth.veriDoldur("select il_adi, il_id from iller", "il_adi", "il_id", "iller", ilComboBox)

        kisiTipiComboBox.SelectedIndex = 0


        emailTextBox.MaxLength = 200
        tcTextBox.MaxLength = 11
        telTextBox.MaxLength = 11
        sifreTextBox.MaxLength = 32
        adTextBox.MaxLength = 60
        soyadTextBox.MaxLength = 60

        sokakTextBox.MaxLength = 100
        binaNoTextBox.MaxLength = 10
        daireNoTextBox.MaxLength = 5
        acikAdresTextBox.MaxLength = 200

        Dim today As DateTime = DateTime.Today

        ' 18 yıl önceki tarihi hesapla
        Dim maxSelectableDate As DateTime = today.AddYears(-18)

        ' DateTimePicker için MinDate ve MaxDate ayarları
        dogumDTP.MaxDate = maxSelectableDate
        dogumDTP.MinDate = New DateTime(1900, 1, 1) ' Örneğin, 1900 yılından daha eski tarihlerin seçilmemesi için

        ' Varsayılan olarak seçilecek tarihi ayarla
        dogumDTP.Value = maxSelectableDate
    End Sub

    Private Sub tcTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Karakteri yok sayıyoruz
            e.Handled = True
        End If
    End Sub

    Private Sub adTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles adTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Karakteri yok sayıyoruz
            e.Handled = True
        End If
    End Sub

    Private Sub soyadTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles soyadTextBox.KeyPress
        If Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Karakteri yok sayıyoruz
            e.Handled = True
        End If
    End Sub

    Private Sub telTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Karakteri yok sayıyoruz
            e.Handled = True
        End If
    End Sub

    Private Sub emailTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emailTextBox.KeyPress

    End Sub

    Private Sub sifreTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sifreTextBox.KeyPress

    End Sub

    Private Sub sokakTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sokakTextBox.KeyPress

    End Sub

    Private Sub binaNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles binaNoTextBox.KeyPress

    End Sub

    Private Sub daireNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles daireNoTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Karakteri yok sayıyoruz
            e.Handled = True
        End If
    End Sub

    Private Sub acikAdresTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles acikAdresTextBox.KeyPress

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim girisEkrani As New GirisEkrani()
        girisEkrani.Show()

        Me.Close()
    End Sub
End Class
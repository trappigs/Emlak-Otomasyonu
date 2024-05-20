<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KullaniciArsaListesi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AlanBuyuk = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sokak_adi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.il_adi = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mahalle_adi = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ilce_adi = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.alan = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.emlak_sahibi_tc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tapu_durumu = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gabari_degeri = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kaks_degeri = New System.Windows.Forms.ComboBox()
        Me.parsel_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.imar_cesidi = New System.Windows.Forms.ComboBox()
        Me.ada_no = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlanBuyuk
        '
        Me.AlanBuyuk.Location = New System.Drawing.Point(165, 344)
        Me.AlanBuyuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AlanBuyuk.Name = "AlanBuyuk"
        Me.AlanBuyuk.Size = New System.Drawing.Size(83, 22)
        Me.AlanBuyuk.TabIndex = 272
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 271
        Me.Label7.Text = "Alan(m2)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(323, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(530, 416)
        Me.DataGridView1.TabIndex = 270
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(182, 532)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 50)
        Me.Button2.TabIndex = 269
        Me.Button2.Text = "Güncelle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sokak_adi
        '
        Me.sokak_adi.Location = New System.Drawing.Point(162, 276)
        Me.sokak_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sokak_adi.Name = "sokak_adi"
        Me.sokak_adi.Size = New System.Drawing.Size(83, 22)
        Me.sokak_adi.TabIndex = 268
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 267
        Me.Label12.Text = "İl"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(162, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 266
        Me.Label10.Text = "Sokak Adı"
        '
        'il_adi
        '
        Me.il_adi.FormattingEnabled = True
        Me.il_adi.Location = New System.Drawing.Point(42, 215)
        Me.il_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.il_adi.Name = "il_adi"
        Me.il_adi.Size = New System.Drawing.Size(83, 24)
        Me.il_adi.TabIndex = 265
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 264
        Me.Label9.Text = "Mahalle"
        '
        'mahalle_adi
        '
        Me.mahalle_adi.FormattingEnabled = True
        Me.mahalle_adi.Location = New System.Drawing.Point(42, 277)
        Me.mahalle_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mahalle_adi.Name = "mahalle_adi"
        Me.mahalle_adi.Size = New System.Drawing.Size(83, 24)
        Me.mahalle_adi.TabIndex = 263
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(162, 197)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 16)
        Me.Label15.TabIndex = 262
        Me.Label15.Text = "İlçe"
        '
        'ilce_adi
        '
        Me.ilce_adi.FormattingEnabled = True
        Me.ilce_adi.Location = New System.Drawing.Point(162, 215)
        Me.ilce_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ilce_adi.Name = "ilce_adi"
        Me.ilce_adi.Size = New System.Drawing.Size(83, 24)
        Me.ilce_adi.TabIndex = 261
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 532)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 50)
        Me.Button1.TabIndex = 260
        Me.Button1.Text = "Ara"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'alan
        '
        Me.alan.Location = New System.Drawing.Point(62, 344)
        Me.alan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.alan.Name = "alan"
        Me.alan.Size = New System.Drawing.Size(83, 22)
        Me.alan.TabIndex = 259
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(62, 326)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 16)
        Me.Label24.TabIndex = 258
        Me.Label24.Text = "Alan(m2)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 442)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "Emlak Sahibi TC"
        '
        'emlak_sahibi_tc
        '
        Me.emlak_sahibi_tc.FormattingEnabled = True
        Me.emlak_sahibi_tc.Location = New System.Drawing.Point(74, 461)
        Me.emlak_sahibi_tc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.emlak_sahibi_tc.Name = "emlak_sahibi_tc"
        Me.emlak_sahibi_tc.Size = New System.Drawing.Size(151, 24)
        Me.emlak_sahibi_tc.TabIndex = 256
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 255
        Me.Label5.Text = "Tapu Durumu"
        '
        'tapu_durumu
        '
        Me.tapu_durumu.FormattingEnabled = True
        Me.tapu_durumu.Location = New System.Drawing.Point(184, 146)
        Me.tapu_durumu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tapu_durumu.Name = "tapu_durumu"
        Me.tapu_durumu.Size = New System.Drawing.Size(83, 24)
        Me.tapu_durumu.TabIndex = 254
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "Gabari Değeri"
        '
        'gabari_degeri
        '
        Me.gabari_degeri.FormattingEnabled = True
        Me.gabari_degeri.Location = New System.Drawing.Point(182, 92)
        Me.gabari_degeri.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gabari_degeri.Name = "gabari_degeri"
        Me.gabari_degeri.Size = New System.Drawing.Size(83, 24)
        Me.gabari_degeri.TabIndex = 252
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "Kaks Değeri"
        '
        'kaks_degeri
        '
        Me.kaks_degeri.FormattingEnabled = True
        Me.kaks_degeri.Location = New System.Drawing.Point(184, 40)
        Me.kaks_degeri.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kaks_degeri.Name = "kaks_degeri"
        Me.kaks_degeri.Size = New System.Drawing.Size(83, 24)
        Me.kaks_degeri.TabIndex = 250
        '
        'parsel_no
        '
        Me.parsel_no.Location = New System.Drawing.Point(23, 148)
        Me.parsel_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.parsel_no.Name = "parsel_no"
        Me.parsel_no.Size = New System.Drawing.Size(83, 22)
        Me.parsel_no.TabIndex = 249
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 248
        Me.Label2.Text = "Parsel No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 247
        Me.Label8.Text = "İmar Durumu"
        '
        'imar_cesidi
        '
        Me.imar_cesidi.FormattingEnabled = True
        Me.imar_cesidi.Location = New System.Drawing.Point(23, 40)
        Me.imar_cesidi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imar_cesidi.Name = "imar_cesidi"
        Me.imar_cesidi.Size = New System.Drawing.Size(83, 24)
        Me.imar_cesidi.TabIndex = 246
        '
        'ada_no
        '
        Me.ada_no.Location = New System.Drawing.Point(23, 94)
        Me.ada_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ada_no.Name = "ada_no"
        Me.ada_no.Size = New System.Drawing.Size(83, 22)
        Me.ada_no.TabIndex = 245
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Ada No"
        '
        'KullaniciArsaListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 653)
        Me.Controls.Add(Me.AlanBuyuk)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.sokak_adi)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.il_adi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mahalle_adi)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ilce_adi)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.alan)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.emlak_sahibi_tc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tapu_durumu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gabari_degeri)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kaks_degeri)
        Me.Controls.Add(Me.parsel_no)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.imar_cesidi)
        Me.Controls.Add(Me.ada_no)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KullaniciArsaListesi"
        Me.Text = "KullaniciArsaListesi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlanBuyuk As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents sokak_adi As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents il_adi As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mahalle_adi As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ilce_adi As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents alan As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents emlak_sahibi_tc As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tapu_durumu As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents gabari_degeri As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents kaks_degeri As ComboBox
    Friend WithEvents parsel_no As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents imar_cesidi As ComboBox
    Friend WithEvents ada_no As TextBox
    Friend WithEvents Label1 As Label
End Class

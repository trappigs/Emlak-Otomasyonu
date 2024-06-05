<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class isyeriListesi
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.emlak_sahibi_tc = New System.Windows.Forms.ComboBox()
        Me.aidat_ucret = New System.Windows.Forms.TextBox()
        Me.bolum_sayisi = New System.Windows.Forms.TextBox()
        Me.isitma = New System.Windows.Forms.TextBox()
        Me.isyeri_tur = New System.Windows.Forms.ComboBox()
        Me.sokak_adi = New System.Windows.Forms.TextBox()
        Me.il_adi = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mahalle_adi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ilce_adi = New System.Windows.Forms.ComboBox()
        Me.satisUcretiBuyuk = New System.Windows.Forms.TextBox()
        Me.satisUcretiKucuk = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.kiraUcretiBuyuk = New System.Windows.Forms.TextBox()
        Me.kiraUcretiKucuk = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AlanBuyuk = New System.Windows.Forms.TextBox()
        Me.alan = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(341, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(516, 589)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(95, 486)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ara"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(198, 486)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Güncelle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(25, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "İşyeri Türü"
        '
        'emlak_sahibi_tc
        '
        Me.emlak_sahibi_tc.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.emlak_sahibi_tc.FormattingEnabled = True
        Me.emlak_sahibi_tc.Location = New System.Drawing.Point(112, 224)
        Me.emlak_sahibi_tc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.emlak_sahibi_tc.Name = "emlak_sahibi_tc"
        Me.emlak_sahibi_tc.Size = New System.Drawing.Size(92, 27)
        Me.emlak_sahibi_tc.TabIndex = 9
        '
        'aidat_ucret
        '
        Me.aidat_ucret.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.aidat_ucret.Location = New System.Drawing.Point(112, 130)
        Me.aidat_ucret.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.aidat_ucret.Name = "aidat_ucret"
        Me.aidat_ucret.Size = New System.Drawing.Size(92, 26)
        Me.aidat_ucret.TabIndex = 13
        '
        'bolum_sayisi
        '
        Me.bolum_sayisi.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.bolum_sayisi.Location = New System.Drawing.Point(112, 85)
        Me.bolum_sayisi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bolum_sayisi.Name = "bolum_sayisi"
        Me.bolum_sayisi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.bolum_sayisi.Size = New System.Drawing.Size(92, 26)
        Me.bolum_sayisi.TabIndex = 11
        '
        'isitma
        '
        Me.isitma.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.isitma.Location = New System.Drawing.Point(112, 174)
        Me.isitma.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.isitma.Name = "isitma"
        Me.isitma.Size = New System.Drawing.Size(92, 26)
        Me.isitma.TabIndex = 15
        '
        'isyeri_tur
        '
        Me.isyeri_tur.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.isyeri_tur.FormattingEnabled = True
        Me.isyeri_tur.Location = New System.Drawing.Point(112, 33)
        Me.isyeri_tur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.isyeri_tur.Name = "isyeri_tur"
        Me.isyeri_tur.Size = New System.Drawing.Size(92, 27)
        Me.isyeri_tur.TabIndex = 20
        '
        'sokak_adi
        '
        Me.sokak_adi.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.sokak_adi.Location = New System.Drawing.Point(236, 224)
        Me.sokak_adi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.sokak_adi.Name = "sokak_adi"
        Me.sokak_adi.Size = New System.Drawing.Size(92, 26)
        Me.sokak_adi.TabIndex = 139
        '
        'il_adi
        '
        Me.il_adi.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.il_adi.FormattingEnabled = True
        Me.il_adi.Location = New System.Drawing.Point(236, 33)
        Me.il_adi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.il_adi.Name = "il_adi"
        Me.il_adi.Size = New System.Drawing.Size(92, 27)
        Me.il_adi.TabIndex = 138
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(236, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 19)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "İl"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(236, 203)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 19)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "Sokak Adı"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(236, 137)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Mahalle"
        '
        'mahalle_adi
        '
        Me.mahalle_adi.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.mahalle_adi.FormattingEnabled = True
        Me.mahalle_adi.Location = New System.Drawing.Point(236, 163)
        Me.mahalle_adi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.mahalle_adi.Name = "mahalle_adi"
        Me.mahalle_adi.Size = New System.Drawing.Size(92, 27)
        Me.mahalle_adi.TabIndex = 134
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(236, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 19)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "İlçe"
        '
        'ilce_adi
        '
        Me.ilce_adi.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ilce_adi.FormattingEnabled = True
        Me.ilce_adi.Location = New System.Drawing.Point(236, 95)
        Me.ilce_adi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ilce_adi.Name = "ilce_adi"
        Me.ilce_adi.Size = New System.Drawing.Size(92, 27)
        Me.ilce_adi.TabIndex = 132
        '
        'satisUcretiBuyuk
        '
        Me.satisUcretiBuyuk.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.satisUcretiBuyuk.Location = New System.Drawing.Point(198, 433)
        Me.satisUcretiBuyuk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.satisUcretiBuyuk.Name = "satisUcretiBuyuk"
        Me.satisUcretiBuyuk.Size = New System.Drawing.Size(63, 26)
        Me.satisUcretiBuyuk.TabIndex = 263
        '
        'satisUcretiKucuk
        '
        Me.satisUcretiKucuk.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.satisUcretiKucuk.Location = New System.Drawing.Point(121, 433)
        Me.satisUcretiKucuk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.satisUcretiKucuk.Name = "satisUcretiKucuk"
        Me.satisUcretiKucuk.Size = New System.Drawing.Size(63, 26)
        Me.satisUcretiKucuk.TabIndex = 261
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(148, 410)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 19)
        Me.Label16.TabIndex = 260
        Me.Label16.Text = "Satış Ücreti"
        '
        'kiraUcretiBuyuk
        '
        Me.kiraUcretiBuyuk.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.kiraUcretiBuyuk.Location = New System.Drawing.Point(198, 370)
        Me.kiraUcretiBuyuk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kiraUcretiBuyuk.Name = "kiraUcretiBuyuk"
        Me.kiraUcretiBuyuk.Size = New System.Drawing.Size(63, 26)
        Me.kiraUcretiBuyuk.TabIndex = 259
        '
        'kiraUcretiKucuk
        '
        Me.kiraUcretiKucuk.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.kiraUcretiKucuk.Location = New System.Drawing.Point(121, 370)
        Me.kiraUcretiKucuk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kiraUcretiKucuk.Name = "kiraUcretiKucuk"
        Me.kiraUcretiKucuk.Size = New System.Drawing.Size(63, 26)
        Me.kiraUcretiKucuk.TabIndex = 257
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(153, 348)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 19)
        Me.Label13.TabIndex = 256
        Me.Label13.Text = "Kira Ücreti"
        '
        'AlanBuyuk
        '
        Me.AlanBuyuk.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.AlanBuyuk.Location = New System.Drawing.Point(198, 309)
        Me.AlanBuyuk.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AlanBuyuk.Name = "AlanBuyuk"
        Me.AlanBuyuk.Size = New System.Drawing.Size(63, 26)
        Me.AlanBuyuk.TabIndex = 255
        '
        'alan
        '
        Me.alan.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.alan.Location = New System.Drawing.Point(121, 309)
        Me.alan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.alan.Name = "alan"
        Me.alan.Size = New System.Drawing.Size(63, 26)
        Me.alan.TabIndex = 253
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(156, 284)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 19)
        Me.Label24.TabIndex = 252
        Me.Label24.Text = "Alan(m2)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "İşyeri Türü"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(56, 177)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Isıtma"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(11, 88)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 19)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Bölüm Sayısı"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(20, 132)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 19)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Aidat Ücret"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(11, 232)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 19)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Emlak Sahibi"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(236, 74)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 19)
        Me.Label17.TabIndex = 133
        Me.Label17.Text = "İlçe"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(236, 137)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 19)
        Me.Label18.TabIndex = 135
        Me.Label18.Text = "Mahalle"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(236, 203)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 19)
        Me.Label19.TabIndex = 136
        Me.Label19.Text = "Sokak Adı"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(236, 12)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 19)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "İl"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(156, 284)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 19)
        Me.Label21.TabIndex = 252
        Me.Label21.Text = "Alan(m2)"
        '
        'isyeriListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(857, 589)
        Me.Controls.Add(Me.satisUcretiBuyuk)
        Me.Controls.Add(Me.satisUcretiKucuk)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.kiraUcretiBuyuk)
        Me.Controls.Add(Me.kiraUcretiKucuk)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AlanBuyuk)
        Me.Controls.Add(Me.alan)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.sokak_adi)
        Me.Controls.Add(Me.il_adi)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mahalle_adi)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ilce_adi)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.isyeri_tur)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.isitma)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.aidat_ucret)
        Me.Controls.Add(Me.bolum_sayisi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.emlak_sahibi_tc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "isyeriListesi"
        Me.Text = "isyeriListesi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents emlak_sahibi_tc As ComboBox
    Friend WithEvents aidat_ucret As TextBox
    Friend WithEvents bolum_sayisi As TextBox
    Friend WithEvents isitma As TextBox
    Friend WithEvents isyeri_tur As ComboBox
    Friend WithEvents sokak_adi As TextBox
    Friend WithEvents il_adi As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents mahalle_adi As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ilce_adi As ComboBox
    Friend WithEvents satisUcretiBuyuk As TextBox
    Friend WithEvents satisUcretiKucuk As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents kiraUcretiBuyuk As TextBox
    Friend WithEvents kiraUcretiKucuk As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents AlanBuyuk As TextBox
    Friend WithEvents alan As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
End Class

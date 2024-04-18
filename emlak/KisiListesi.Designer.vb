<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KisiListesi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.daire_no = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bina_no = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mahalle_adi = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ilce_adi = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kadın = New System.Windows.Forms.RadioButton()
        Me.erkek = New System.Windows.Forms.RadioButton()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.telefon = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.soyadi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.adi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kisi_tc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.kisi_tipi = New System.Windows.Forms.ComboBox()
        Me.il_adi = New System.Windows.Forms.ComboBox()
        Me.sokak_adi = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 486)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 55)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Güncelle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(368, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(530, 416)
        Me.DataGridView1.TabIndex = 124
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 486)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 55)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Ara"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'daire_no
        '
        Me.daire_no.Location = New System.Drawing.Point(238, 410)
        Me.daire_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.daire_no.Name = "daire_no"
        Me.daire_no.Size = New System.Drawing.Size(83, 22)
        Me.daire_no.TabIndex = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(238, 392)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "Daire no"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(238, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "İl"
        '
        'bina_no
        '
        Me.bina_no.Location = New System.Drawing.Point(238, 354)
        Me.bina_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bina_no.Name = "bina_no"
        Me.bina_no.Size = New System.Drawing.Size(83, 22)
        Me.bina_no.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(238, 335)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "Bina no"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(238, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Sokak Adı"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(238, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "Mahalle"
        '
        'mahalle_adi
        '
        Me.mahalle_adi.FormattingEnabled = True
        Me.mahalle_adi.Location = New System.Drawing.Point(238, 242)
        Me.mahalle_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mahalle_adi.Name = "mahalle_adi"
        Me.mahalle_adi.Size = New System.Drawing.Size(83, 24)
        Me.mahalle_adi.TabIndex = 111
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(238, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "İlçe"
        '
        'ilce_adi
        '
        Me.ilce_adi.FormattingEnabled = True
        Me.ilce_adi.Location = New System.Drawing.Point(238, 189)
        Me.ilce_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ilce_adi.Name = "ilce_adi"
        Me.ilce_adi.Size = New System.Drawing.Size(83, 24)
        Me.ilce_adi.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Cinsiyet"
        '
        'kadın
        '
        Me.kadın.AutoSize = True
        Me.kadın.Location = New System.Drawing.Point(128, 418)
        Me.kadın.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kadın.Name = "kadın"
        Me.kadın.Size = New System.Drawing.Size(59, 20)
        Me.kadın.TabIndex = 105
        Me.kadın.TabStop = True
        Me.kadın.Text = "Kadın"
        Me.kadın.UseVisualStyleBackColor = True
        '
        'erkek
        '
        Me.erkek.AutoSize = True
        Me.erkek.Location = New System.Drawing.Point(44, 418)
        Me.erkek.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.erkek.Name = "erkek"
        Me.erkek.Size = New System.Drawing.Size(60, 20)
        Me.erkek.TabIndex = 104
        Me.erkek.TabStop = True
        Me.erkek.Text = "Erkek"
        Me.erkek.UseVisualStyleBackColor = True
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(52, 354)
        Me.email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(125, 22)
        Me.email.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Email"
        '
        'telefon
        '
        Me.telefon.Location = New System.Drawing.Point(52, 298)
        Me.telefon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.telefon.Name = "telefon"
        Me.telefon.Size = New System.Drawing.Size(125, 22)
        Me.telefon.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Telefon"
        '
        'soyadi
        '
        Me.soyadi.Location = New System.Drawing.Point(52, 242)
        Me.soyadi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.soyadi.Name = "soyadi"
        Me.soyadi.Size = New System.Drawing.Size(125, 22)
        Me.soyadi.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Soyad"
        '
        'adi
        '
        Me.adi.Location = New System.Drawing.Point(52, 189)
        Me.adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adi.Name = "adi"
        Me.adi.Size = New System.Drawing.Size(125, 22)
        Me.adi.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Ad"
        '
        'kisi_tc
        '
        Me.kisi_tc.Location = New System.Drawing.Point(52, 138)
        Me.kisi_tc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kisi_tc.Name = "kisi_tc"
        Me.kisi_tc.Size = New System.Drawing.Size(125, 22)
        Me.kisi_tc.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "TC"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(145, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "Kişi Tipi"
        '
        'kisi_tipi
        '
        Me.kisi_tipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kisi_tipi.FormattingEnabled = True
        Me.kisi_tipi.Items.AddRange(New Object() {"Müşteri", "Emlakçı"})
        Me.kisi_tipi.Location = New System.Drawing.Point(145, 57)
        Me.kisi_tipi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.kisi_tipi.Name = "kisi_tipi"
        Me.kisi_tipi.Size = New System.Drawing.Size(83, 24)
        Me.kisi_tipi.TabIndex = 128
        '
        'il_adi
        '
        Me.il_adi.FormattingEnabled = True
        Me.il_adi.Location = New System.Drawing.Point(238, 136)
        Me.il_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.il_adi.Name = "il_adi"
        Me.il_adi.Size = New System.Drawing.Size(83, 24)
        Me.il_adi.TabIndex = 130
        '
        'sokak_adi
        '
        Me.sokak_adi.Location = New System.Drawing.Point(238, 298)
        Me.sokak_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sokak_adi.Name = "sokak_adi"
        Me.sokak_adi.Size = New System.Drawing.Size(83, 22)
        Me.sokak_adi.TabIndex = 131
        '
        'KisiListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1388, 704)
        Me.Controls.Add(Me.sokak_adi)
        Me.Controls.Add(Me.il_adi)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.kisi_tipi)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.daire_no)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.bina_no)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mahalle_adi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ilce_adi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.kadın)
        Me.Controls.Add(Me.erkek)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.telefon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.soyadi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.adi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.kisi_tc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KisiListesi"
        Me.Text = "EmlakciListesi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents daire_no As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents bina_no As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents mahalle_adi As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ilce_adi As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents kadın As RadioButton
    Friend WithEvents erkek As RadioButton
    Friend WithEvents email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents telefon As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents soyadi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents adi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents kisi_tc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents kisi_tipi As ComboBox
    Friend WithEvents il_adi As ComboBox
    Friend WithEvents sokak_adi As TextBox
End Class

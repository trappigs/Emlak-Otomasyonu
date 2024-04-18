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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.emlak_sahibi_tc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.aidat_ucret = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bolum_sayisi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.isitma = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.isyeri_tur = New System.Windows.Forms.ComboBox()
        Me.sokak_adi = New System.Windows.Forms.TextBox()
        Me.il_adi = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mahalle_adi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ilce_adi = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(340, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(530, 416)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ara"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(182, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 52)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Güncelle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "İşyeri Türü"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Isıtma"
        '
        'emlak_sahibi_tc
        '
        Me.emlak_sahibi_tc.FormattingEnabled = True
        Me.emlak_sahibi_tc.Location = New System.Drawing.Point(113, 225)
        Me.emlak_sahibi_tc.Name = "emlak_sahibi_tc"
        Me.emlak_sahibi_tc.Size = New System.Drawing.Size(73, 24)
        Me.emlak_sahibi_tc.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Aidat Ücret"
        '
        'aidat_ucret
        '
        Me.aidat_ucret.Location = New System.Drawing.Point(112, 139)
        Me.aidat_ucret.Name = "aidat_ucret"
        Me.aidat_ucret.Size = New System.Drawing.Size(73, 22)
        Me.aidat_ucret.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Bölüm Sayısı"
        '
        'bolum_sayisi
        '
        Me.bolum_sayisi.Location = New System.Drawing.Point(113, 92)
        Me.bolum_sayisi.Name = "bolum_sayisi"
        Me.bolum_sayisi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.bolum_sayisi.Size = New System.Drawing.Size(73, 22)
        Me.bolum_sayisi.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = " "
        '
        'isitma
        '
        Me.isitma.Location = New System.Drawing.Point(112, 182)
        Me.isitma.Name = "isitma"
        Me.isitma.Size = New System.Drawing.Size(73, 22)
        Me.isitma.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Emlak Sahibi"
        '
        'isyeri_tur
        '
        Me.isyeri_tur.FormattingEnabled = True
        Me.isyeri_tur.Location = New System.Drawing.Point(113, 47)
        Me.isyeri_tur.Name = "isyeri_tur"
        Me.isyeri_tur.Size = New System.Drawing.Size(73, 24)
        Me.isyeri_tur.TabIndex = 20
        '
        'sokak_adi
        '
        Me.sokak_adi.Location = New System.Drawing.Point(217, 209)
        Me.sokak_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sokak_adi.Name = "sokak_adi"
        Me.sokak_adi.Size = New System.Drawing.Size(83, 22)
        Me.sokak_adi.TabIndex = 139
        '
        'il_adi
        '
        Me.il_adi.FormattingEnabled = True
        Me.il_adi.Location = New System.Drawing.Point(217, 47)
        Me.il_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.il_adi.Name = "il_adi"
        Me.il_adi.Size = New System.Drawing.Size(83, 24)
        Me.il_adi.TabIndex = 138
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(217, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "İl"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(217, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 136
        Me.Label10.Text = "Sokak Adı"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(217, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 135
        Me.Label9.Text = "Mahalle"
        '
        'mahalle_adi
        '
        Me.mahalle_adi.FormattingEnabled = True
        Me.mahalle_adi.Location = New System.Drawing.Point(217, 153)
        Me.mahalle_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mahalle_adi.Name = "mahalle_adi"
        Me.mahalle_adi.Size = New System.Drawing.Size(83, 24)
        Me.mahalle_adi.TabIndex = 134
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 16)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "İlçe"
        '
        'ilce_adi
        '
        Me.ilce_adi.FormattingEnabled = True
        Me.ilce_adi.Location = New System.Drawing.Point(217, 100)
        Me.ilce_adi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ilce_adi.Name = "ilce_adi"
        Me.ilce_adi.Size = New System.Drawing.Size(83, 24)
        Me.ilce_adi.TabIndex = 132
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(36, 298)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(73, 22)
        Me.TextBox1.TabIndex = 140
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(132, 298)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(73, 22)
        Me.TextBox2.TabIndex = 141
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Alan"
        '
        'isyeriListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1143, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.sokak_adi)
        Me.Controls.Add(Me.il_adi)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mahalle_adi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ilce_adi)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.isyeri_tur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.isitma)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.aidat_ucret)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bolum_sayisi)
        Me.Controls.Add(Me.emlak_sahibi_tc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents emlak_sahibi_tc As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents aidat_ucret As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bolum_sayisi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents isitma As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents isyeri_tur As ComboBox
    Friend WithEvents sokak_adi As TextBox
    Friend WithEvents il_adi As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents mahalle_adi As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ilce_adi As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
End Class

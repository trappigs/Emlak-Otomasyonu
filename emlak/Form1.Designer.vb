<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.musteriEkleBtn = New System.Windows.Forms.Button()
        Me.arsaEkleBtn = New System.Windows.Forms.Button()
        Me.konutEkleBtn = New System.Windows.Forms.Button()
        Me.isyeriEkleBtn = New System.Windows.Forms.Button()
        Me.alSatKiralaBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.musteriListesiBtn = New System.Windows.Forms.Button()
        Me.emlakciListesiBtn = New System.Windows.Forms.Button()
        Me.arsaListesiBtn = New System.Windows.Forms.Button()
        Me.konutListesiBtn = New System.Windows.Forms.Button()
        Me.isyeriListesiBtn = New System.Windows.Forms.Button()
        Me.genelAramaBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Emlakçı Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'musteriEkleBtn
        '
        Me.musteriEkleBtn.Location = New System.Drawing.Point(12, 70)
        Me.musteriEkleBtn.Name = "musteriEkleBtn"
        Me.musteriEkleBtn.Size = New System.Drawing.Size(75, 52)
        Me.musteriEkleBtn.TabIndex = 1
        Me.musteriEkleBtn.Text = "Müşteri Ekle"
        Me.musteriEkleBtn.UseVisualStyleBackColor = True
        '
        'arsaEkleBtn
        '
        Me.arsaEkleBtn.Location = New System.Drawing.Point(12, 128)
        Me.arsaEkleBtn.Name = "arsaEkleBtn"
        Me.arsaEkleBtn.Size = New System.Drawing.Size(75, 52)
        Me.arsaEkleBtn.TabIndex = 2
        Me.arsaEkleBtn.Text = "Arsa Ekle"
        Me.arsaEkleBtn.UseVisualStyleBackColor = True
        '
        'konutEkleBtn
        '
        Me.konutEkleBtn.Location = New System.Drawing.Point(12, 186)
        Me.konutEkleBtn.Name = "konutEkleBtn"
        Me.konutEkleBtn.Size = New System.Drawing.Size(75, 52)
        Me.konutEkleBtn.TabIndex = 3
        Me.konutEkleBtn.Text = "Konut Ekle"
        Me.konutEkleBtn.UseVisualStyleBackColor = True
        '
        'isyeriEkleBtn
        '
        Me.isyeriEkleBtn.Location = New System.Drawing.Point(12, 244)
        Me.isyeriEkleBtn.Name = "isyeriEkleBtn"
        Me.isyeriEkleBtn.Size = New System.Drawing.Size(75, 52)
        Me.isyeriEkleBtn.TabIndex = 4
        Me.isyeriEkleBtn.Text = "İşyeri Ekle"
        Me.isyeriEkleBtn.UseVisualStyleBackColor = True
        '
        'alSatKiralaBtn
        '
        Me.alSatKiralaBtn.Location = New System.Drawing.Point(12, 302)
        Me.alSatKiralaBtn.Name = "alSatKiralaBtn"
        Me.alSatKiralaBtn.Size = New System.Drawing.Size(142, 52)
        Me.alSatKiralaBtn.TabIndex = 5
        Me.alSatKiralaBtn.Text = "Alım-Satım-Kiralama İşlemleri"
        Me.alSatKiralaBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.genelAramaBtn)
        Me.Panel1.Controls.Add(Me.isyeriListesiBtn)
        Me.Panel1.Controls.Add(Me.konutListesiBtn)
        Me.Panel1.Controls.Add(Me.arsaListesiBtn)
        Me.Panel1.Controls.Add(Me.emlakciListesiBtn)
        Me.Panel1.Controls.Add(Me.musteriListesiBtn)
        Me.Panel1.Controls.Add(Me.alSatKiralaBtn)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.isyeriEkleBtn)
        Me.Panel1.Controls.Add(Me.musteriEkleBtn)
        Me.Panel1.Controls.Add(Me.konutEkleBtn)
        Me.Panel1.Controls.Add(Me.arsaEkleBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 716)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(160, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(880, 716)
        Me.Panel2.TabIndex = 8
        '
        'musteriListesiBtn
        '
        Me.musteriListesiBtn.Location = New System.Drawing.Point(12, 360)
        Me.musteriListesiBtn.Name = "musteriListesiBtn"
        Me.musteriListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.musteriListesiBtn.TabIndex = 6
        Me.musteriListesiBtn.Text = "Müşteri Listesi"
        Me.musteriListesiBtn.UseVisualStyleBackColor = True
        '
        'emlakciListesiBtn
        '
        Me.emlakciListesiBtn.Location = New System.Drawing.Point(12, 418)
        Me.emlakciListesiBtn.Name = "emlakciListesiBtn"
        Me.emlakciListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.emlakciListesiBtn.TabIndex = 7
        Me.emlakciListesiBtn.Text = "Emlakçı Listesi"
        Me.emlakciListesiBtn.UseVisualStyleBackColor = True
        '
        'arsaListesiBtn
        '
        Me.arsaListesiBtn.Location = New System.Drawing.Point(12, 476)
        Me.arsaListesiBtn.Name = "arsaListesiBtn"
        Me.arsaListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.arsaListesiBtn.TabIndex = 8
        Me.arsaListesiBtn.Text = "Arsa Listesi"
        Me.arsaListesiBtn.UseVisualStyleBackColor = True
        '
        'konutListesiBtn
        '
        Me.konutListesiBtn.Location = New System.Drawing.Point(12, 534)
        Me.konutListesiBtn.Name = "konutListesiBtn"
        Me.konutListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.konutListesiBtn.TabIndex = 9
        Me.konutListesiBtn.Text = "Konut Listesi"
        Me.konutListesiBtn.UseVisualStyleBackColor = True
        '
        'isyeriListesiBtn
        '
        Me.isyeriListesiBtn.Location = New System.Drawing.Point(12, 592)
        Me.isyeriListesiBtn.Name = "isyeriListesiBtn"
        Me.isyeriListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.isyeriListesiBtn.TabIndex = 10
        Me.isyeriListesiBtn.Text = "İşyeri Listesi"
        Me.isyeriListesiBtn.UseVisualStyleBackColor = True
        '
        'genelAramaBtn
        '
        Me.genelAramaBtn.Location = New System.Drawing.Point(12, 650)
        Me.genelAramaBtn.Name = "genelAramaBtn"
        Me.genelAramaBtn.Size = New System.Drawing.Size(75, 52)
        Me.genelAramaBtn.TabIndex = 11
        Me.genelAramaBtn.Text = "Genel Arama"
        Me.genelAramaBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 716)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents musteriEkleBtn As Button
    Friend WithEvents arsaEkleBtn As Button
    Friend WithEvents konutEkleBtn As Button
    Friend WithEvents isyeriEkleBtn As Button
    Friend WithEvents alSatKiralaBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents musteriListesiBtn As Button
    Friend WithEvents isyeriListesiBtn As Button
    Friend WithEvents konutListesiBtn As Button
    Friend WithEvents arsaListesiBtn As Button
    Friend WithEvents emlakciListesiBtn As Button
    Friend WithEvents genelAramaBtn As Button
End Class

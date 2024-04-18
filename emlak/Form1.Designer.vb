<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.arsaEkleBtn = New System.Windows.Forms.Button()
        Me.konutEkleBtn = New System.Windows.Forms.Button()
        Me.isyeriEkleBtn = New System.Windows.Forms.Button()
        Me.alSatKiralaBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.isyeriListesiBtn = New System.Windows.Forms.Button()
        Me.konutListesiBtn = New System.Windows.Forms.Button()
        Me.arsaListesiBtn = New System.Windows.Forms.Button()
        Me.kisiListesiBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Emlakçı Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'arsaEkleBtn
        '
        Me.arsaEkleBtn.Location = New System.Drawing.Point(164, 11)
        Me.arsaEkleBtn.Name = "arsaEkleBtn"
        Me.arsaEkleBtn.Size = New System.Drawing.Size(75, 52)
        Me.arsaEkleBtn.TabIndex = 2
        Me.arsaEkleBtn.Text = "Arsa Ekle"
        Me.arsaEkleBtn.UseVisualStyleBackColor = True
        '
        'konutEkleBtn
        '
        Me.konutEkleBtn.Location = New System.Drawing.Point(245, 11)
        Me.konutEkleBtn.Name = "konutEkleBtn"
        Me.konutEkleBtn.Size = New System.Drawing.Size(75, 52)
        Me.konutEkleBtn.TabIndex = 3
        Me.konutEkleBtn.Text = "Konut Ekle"
        Me.konutEkleBtn.UseVisualStyleBackColor = True
        '
        'isyeriEkleBtn
        '
        Me.isyeriEkleBtn.Location = New System.Drawing.Point(326, 11)
        Me.isyeriEkleBtn.Name = "isyeriEkleBtn"
        Me.isyeriEkleBtn.Size = New System.Drawing.Size(75, 52)
        Me.isyeriEkleBtn.TabIndex = 4
        Me.isyeriEkleBtn.Text = "İşyeri Ekle"
        Me.isyeriEkleBtn.UseVisualStyleBackColor = True
        '
        'alSatKiralaBtn
        '
        Me.alSatKiralaBtn.Location = New System.Drawing.Point(407, 11)
        Me.alSatKiralaBtn.Name = "alSatKiralaBtn"
        Me.alSatKiralaBtn.Size = New System.Drawing.Size(85, 52)
        Me.alSatKiralaBtn.TabIndex = 5
        Me.alSatKiralaBtn.Text = "Alım-Satım-Kiralama İşlemleri"
        Me.alSatKiralaBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.isyeriListesiBtn)
        Me.Panel1.Controls.Add(Me.konutListesiBtn)
        Me.Panel1.Controls.Add(Me.arsaListesiBtn)
        Me.Panel1.Controls.Add(Me.kisiListesiBtn)
        Me.Panel1.Controls.Add(Me.alSatKiralaBtn)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.isyeriEkleBtn)
        Me.Panel1.Controls.Add(Me.konutEkleBtn)
        Me.Panel1.Controls.Add(Me.arsaEkleBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 74)
        Me.Panel1.TabIndex = 6
        '
        'isyeriListesiBtn
        '
        Me.isyeriListesiBtn.Location = New System.Drawing.Point(741, 11)
        Me.isyeriListesiBtn.Name = "isyeriListesiBtn"
        Me.isyeriListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.isyeriListesiBtn.TabIndex = 10
        Me.isyeriListesiBtn.Text = "İşyeri Listesi"
        Me.isyeriListesiBtn.UseVisualStyleBackColor = True
        '
        'konutListesiBtn
        '
        Me.konutListesiBtn.Location = New System.Drawing.Point(660, 11)
        Me.konutListesiBtn.Name = "konutListesiBtn"
        Me.konutListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.konutListesiBtn.TabIndex = 9
        Me.konutListesiBtn.Text = "Konut Listesi"
        Me.konutListesiBtn.UseVisualStyleBackColor = True
        '
        'arsaListesiBtn
        '
        Me.arsaListesiBtn.Location = New System.Drawing.Point(579, 11)
        Me.arsaListesiBtn.Name = "arsaListesiBtn"
        Me.arsaListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.arsaListesiBtn.TabIndex = 8
        Me.arsaListesiBtn.Text = "Arsa Listesi"
        Me.arsaListesiBtn.UseVisualStyleBackColor = True
        '
        'kisiListesiBtn
        '
        Me.kisiListesiBtn.Location = New System.Drawing.Point(498, 11)
        Me.kisiListesiBtn.Name = "kisiListesiBtn"
        Me.kisiListesiBtn.Size = New System.Drawing.Size(75, 52)
        Me.kisiListesiBtn.TabIndex = 7
        Me.kisiListesiBtn.Text = "Kişi Listesi"
        Me.kisiListesiBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(918, 642)
        Me.Panel2.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 716)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents arsaEkleBtn As Button
    Friend WithEvents konutEkleBtn As Button
    Friend WithEvents isyeriEkleBtn As Button
    Friend WithEvents alSatKiralaBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents isyeriListesiBtn As Button
    Friend WithEvents konutListesiBtn As Button
    Friend WithEvents arsaListesiBtn As Button
    Friend WithEvents kisiListesiBtn As Button
End Class

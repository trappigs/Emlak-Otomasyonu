<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlSatKirala
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.saticiComboBox = New System.Windows.Forms.ComboBox()
        Me.aliciComboBox = New System.Windows.Forms.ComboBox()
        Me.emlakciComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.konutRadioButton = New System.Windows.Forms.RadioButton()
        Me.isyeriRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.arsaRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kira_ucreti = New System.Windows.Forms.TextBox()
        Me.satis_ucreti = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.depozito_ucreti = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(49, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Emlakçı"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Alıcı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(49, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Satıcı"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(117, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 19)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "İşlem"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(40, 66)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(99, 23)
        Me.RadioButton2.TabIndex = 154
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Satın Alma"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.RadioButton3.Location = New System.Drawing.Point(165, 66)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(87, 23)
        Me.RadioButton3.TabIndex = 155
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Kiralama"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'saticiComboBox
        '
        Me.saticiComboBox.FormattingEnabled = True
        Me.saticiComboBox.Location = New System.Drawing.Point(49, 173)
        Me.saticiComboBox.Name = "saticiComboBox"
        Me.saticiComboBox.Size = New System.Drawing.Size(143, 27)
        Me.saticiComboBox.TabIndex = 158
        '
        'aliciComboBox
        '
        Me.aliciComboBox.FormattingEnabled = True
        Me.aliciComboBox.Location = New System.Drawing.Point(49, 242)
        Me.aliciComboBox.Name = "aliciComboBox"
        Me.aliciComboBox.Size = New System.Drawing.Size(143, 27)
        Me.aliciComboBox.TabIndex = 157
        '
        'emlakciComboBox
        '
        Me.emlakciComboBox.FormattingEnabled = True
        Me.emlakciComboBox.Location = New System.Drawing.Point(49, 99)
        Me.emlakciComboBox.Name = "emlakciComboBox"
        Me.emlakciComboBox.Size = New System.Drawing.Size(143, 27)
        Me.emlakciComboBox.TabIndex = 156
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(219, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 49)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "İşlemi Gerçekleştir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(555, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(658, 531)
        Me.DataGridView1.TabIndex = 160
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(255, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 117)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.konutRadioButton)
        Me.GroupBox2.Controls.Add(Me.isyeriRadioButton)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.arsaRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(255, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 118)
        Me.GroupBox2.TabIndex = 162
        Me.GroupBox2.TabStop = False
        '
        'konutRadioButton
        '
        Me.konutRadioButton.AutoSize = True
        Me.konutRadioButton.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.konutRadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.konutRadioButton.Location = New System.Drawing.Point(187, 73)
        Me.konutRadioButton.Name = "konutRadioButton"
        Me.konutRadioButton.Size = New System.Drawing.Size(66, 23)
        Me.konutRadioButton.TabIndex = 155
        Me.konutRadioButton.TabStop = True
        Me.konutRadioButton.Text = "Konut"
        Me.konutRadioButton.UseVisualStyleBackColor = True
        '
        'isyeriRadioButton
        '
        Me.isyeriRadioButton.AutoSize = True
        Me.isyeriRadioButton.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.isyeriRadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.isyeriRadioButton.Location = New System.Drawing.Point(20, 73)
        Me.isyeriRadioButton.Name = "isyeriRadioButton"
        Me.isyeriRadioButton.Size = New System.Drawing.Size(65, 23)
        Me.isyeriRadioButton.TabIndex = 152
        Me.isyeriRadioButton.TabStop = True
        Me.isyeriRadioButton.Text = "İşyeri"
        Me.isyeriRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(100, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Emlak Türü"
        '
        'arsaRadioButton
        '
        Me.arsaRadioButton.AutoSize = True
        Me.arsaRadioButton.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.arsaRadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.arsaRadioButton.Location = New System.Drawing.Point(103, 73)
        Me.arsaRadioButton.Name = "arsaRadioButton"
        Me.arsaRadioButton.Size = New System.Drawing.Size(57, 23)
        Me.arsaRadioButton.TabIndex = 154
        Me.arsaRadioButton.TabStop = True
        Me.arsaRadioButton.Text = "Arsa"
        Me.arsaRadioButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(76, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Kira Bedeli"
        '
        'kira_ucreti
        '
        Me.kira_ucreti.Location = New System.Drawing.Point(79, 374)
        Me.kira_ucreti.Name = "kira_ucreti"
        Me.kira_ucreti.Size = New System.Drawing.Size(100, 26)
        Me.kira_ucreti.TabIndex = 164
        '
        'satis_ucreti
        '
        Me.satis_ucreti.Location = New System.Drawing.Point(219, 374)
        Me.satis_ucreti.Name = "satis_ucreti"
        Me.satis_ucreti.Size = New System.Drawing.Size(100, 26)
        Me.satis_ucreti.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(215, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 19)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Satış Bedeli"
        '
        'depozito_ucreti
        '
        Me.depozito_ucreti.Location = New System.Drawing.Point(364, 374)
        Me.depozito_ucreti.Name = "depozito_ucreti"
        Me.depozito_ucreti.Size = New System.Drawing.Size(100, 26)
        Me.depozito_ucreti.TabIndex = 168
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(361, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Depozito Bedeli"
        '
        'AlSatKirala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1213, 531)
        Me.Controls.Add(Me.depozito_ucreti)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.satis_ucreti)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.kira_ucreti)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.saticiComboBox)
        Me.Controls.Add(Me.aliciComboBox)
        Me.Controls.Add(Me.emlakciComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Nirmala UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Name = "AlSatKirala"
        Me.Text = "AlSatKirala"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents saticiComboBox As ComboBox
    Friend WithEvents aliciComboBox As ComboBox
    Friend WithEvents emlakciComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents konutRadioButton As RadioButton
    Friend WithEvents isyeriRadioButton As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents arsaRadioButton As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents kira_ucreti As TextBox
    Friend WithEvents satis_ucreti As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents depozito_ucreti As TextBox
    Friend WithEvents Label8 As Label
End Class

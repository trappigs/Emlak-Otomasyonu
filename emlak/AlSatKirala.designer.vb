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
        Me.Label3.Location = New System.Drawing.Point(39, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Emlakçı"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Alıcı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Satıcı"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "İşlem"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(34, 61)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 20)
        Me.RadioButton2.TabIndex = 154
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Satın Alma"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(160, 61)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(78, 20)
        Me.RadioButton3.TabIndex = 155
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Kiralama"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'saticiComboBox
        '
        Me.saticiComboBox.FormattingEnabled = True
        Me.saticiComboBox.Location = New System.Drawing.Point(161, 55)
        Me.saticiComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.saticiComboBox.Name = "saticiComboBox"
        Me.saticiComboBox.Size = New System.Drawing.Size(83, 24)
        Me.saticiComboBox.TabIndex = 158
        '
        'aliciComboBox
        '
        Me.aliciComboBox.FormattingEnabled = True
        Me.aliciComboBox.Location = New System.Drawing.Point(291, 55)
        Me.aliciComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.aliciComboBox.Name = "aliciComboBox"
        Me.aliciComboBox.Size = New System.Drawing.Size(83, 24)
        Me.aliciComboBox.TabIndex = 157
        '
        'emlakciComboBox
        '
        Me.emlakciComboBox.FormattingEnabled = True
        Me.emlakciComboBox.Location = New System.Drawing.Point(39, 55)
        Me.emlakciComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.emlakciComboBox.Name = "emlakciComboBox"
        Me.emlakciComboBox.Size = New System.Drawing.Size(83, 24)
        Me.emlakciComboBox.TabIndex = 156
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 55)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "İşlemi Gerçekleştir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(453, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(399, 442)
        Me.DataGridView1.TabIndex = 160
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 113)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.konutRadioButton)
        Me.GroupBox2.Controls.Add(Me.isyeriRadioButton)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.arsaRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 100)
        Me.GroupBox2.TabIndex = 162
        Me.GroupBox2.TabStop = False
        '
        'konutRadioButton
        '
        Me.konutRadioButton.AutoSize = True
        Me.konutRadioButton.Location = New System.Drawing.Point(180, 61)
        Me.konutRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.konutRadioButton.Name = "konutRadioButton"
        Me.konutRadioButton.Size = New System.Drawing.Size(58, 20)
        Me.konutRadioButton.TabIndex = 155
        Me.konutRadioButton.TabStop = True
        Me.konutRadioButton.Text = "Konut"
        Me.konutRadioButton.UseVisualStyleBackColor = True
        '
        'isyeriRadioButton
        '
        Me.isyeriRadioButton.AutoSize = True
        Me.isyeriRadioButton.Location = New System.Drawing.Point(14, 61)
        Me.isyeriRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.isyeriRadioButton.Name = "isyeriRadioButton"
        Me.isyeriRadioButton.Size = New System.Drawing.Size(57, 20)
        Me.isyeriRadioButton.TabIndex = 152
        Me.isyeriRadioButton.TabStop = True
        Me.isyeriRadioButton.Text = "İşyeri"
        Me.isyeriRadioButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Emlak Türü"
        '
        'arsaRadioButton
        '
        Me.arsaRadioButton.AutoSize = True
        Me.arsaRadioButton.Location = New System.Drawing.Point(97, 61)
        Me.arsaRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.arsaRadioButton.Name = "arsaRadioButton"
        Me.arsaRadioButton.Size = New System.Drawing.Size(53, 20)
        Me.arsaRadioButton.TabIndex = 154
        Me.arsaRadioButton.TabStop = True
        Me.arsaRadioButton.Text = "Arsa"
        Me.arsaRadioButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Kira Bedeli"
        '
        'kira_ucreti
        '
        Me.kira_ucreti.Location = New System.Drawing.Point(22, 363)
        Me.kira_ucreti.Name = "kira_ucreti"
        Me.kira_ucreti.Size = New System.Drawing.Size(100, 22)
        Me.kira_ucreti.TabIndex = 164
        '
        'satis_ucreti
        '
        Me.satis_ucreti.Location = New System.Drawing.Point(161, 363)
        Me.satis_ucreti.Name = "satis_ucreti"
        Me.satis_ucreti.Size = New System.Drawing.Size(100, 22)
        Me.satis_ucreti.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Satış Bedeli"
        '
        'depozito_ucreti
        '
        Me.depozito_ucreti.Location = New System.Drawing.Point(307, 363)
        Me.depozito_ucreti.Name = "depozito_ucreti"
        Me.depozito_ucreti.Size = New System.Drawing.Size(100, 22)
        Me.depozito_ucreti.TabIndex = 168
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 167
        Me.Label8.Text = "Depozito Bedeli"
        '
        'AlSatKirala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(918, 514)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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

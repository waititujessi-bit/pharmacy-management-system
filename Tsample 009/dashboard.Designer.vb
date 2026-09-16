<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbldrugID = New System.Windows.Forms.Label()
        Me.Lbldrugtype = New System.Windows.Forms.Label()
        Me.Lbldrugcode = New System.Windows.Forms.Label()
        Me.Lbldrugname = New System.Windows.Forms.Label()
        Me.LblNursename = New System.Windows.Forms.Label()
        Me.Lbldateofexp = New System.Windows.Forms.Label()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.TxtdrugID = New System.Windows.Forms.TextBox()
        Me.Txtdrugtype = New System.Windows.Forms.TextBox()
        Me.Txtdrugcode = New System.Windows.Forms.TextBox()
        Me.ComboBoxdrugname = New System.Windows.Forms.ComboBox()
        Me.ComboBoxnursename = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btnupdate = New System.Windows.Forms.Button()
        Me.Txtdateofexp = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Btnwaterbilling = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(819, 458)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LbldrugID
        '
        Me.LbldrugID.AutoSize = True
        Me.LbldrugID.Location = New System.Drawing.Point(2, 9)
        Me.LbldrugID.Name = "LbldrugID"
        Me.LbldrugID.Size = New System.Drawing.Size(50, 17)
        Me.LbldrugID.TabIndex = 1
        Me.LbldrugID.Text = "drugID"
        '
        'Lbldrugtype
        '
        Me.Lbldrugtype.AutoSize = True
        Me.Lbldrugtype.Location = New System.Drawing.Point(2, 61)
        Me.Lbldrugtype.Name = "Lbldrugtype"
        Me.Lbldrugtype.Size = New System.Drawing.Size(64, 17)
        Me.Lbldrugtype.TabIndex = 2
        Me.Lbldrugtype.Text = "drugtype"
        '
        'Lbldrugcode
        '
        Me.Lbldrugcode.AutoSize = True
        Me.Lbldrugcode.Location = New System.Drawing.Point(2, 115)
        Me.Lbldrugcode.Name = "Lbldrugcode"
        Me.Lbldrugcode.Size = New System.Drawing.Size(68, 17)
        Me.Lbldrugcode.TabIndex = 3
        Me.Lbldrugcode.Text = "drugcode"
        '
        'Lbldrugname
        '
        Me.Lbldrugname.AutoSize = True
        Me.Lbldrugname.Location = New System.Drawing.Point(2, 155)
        Me.Lbldrugname.Name = "Lbldrugname"
        Me.Lbldrugname.Size = New System.Drawing.Size(72, 17)
        Me.Lbldrugname.TabIndex = 4
        Me.Lbldrugname.Text = "drugname"
        '
        'LblNursename
        '
        Me.LblNursename.AutoSize = True
        Me.LblNursename.Location = New System.Drawing.Point(2, 196)
        Me.LblNursename.Name = "LblNursename"
        Me.LblNursename.Size = New System.Drawing.Size(81, 17)
        Me.LblNursename.TabIndex = 5
        Me.LblNursename.Text = "Nursename"
        '
        'Lbldateofexp
        '
        Me.Lbldateofexp.AutoSize = True
        Me.Lbldateofexp.Location = New System.Drawing.Point(2, 259)
        Me.Lbldateofexp.Name = "Lbldateofexp"
        Me.Lbldateofexp.Size = New System.Drawing.Size(70, 17)
        Me.Lbldateofexp.TabIndex = 6
        Me.Lbldateofexp.Text = "dateofexp"
        '
        'Btnadd
        '
        Me.Btnadd.Location = New System.Drawing.Point(12, 421)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(75, 23)
        Me.Btnadd.TabIndex = 7
        Me.Btnadd.Text = "add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Location = New System.Drawing.Point(182, 421)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(75, 23)
        Me.Btndelete.TabIndex = 8
        Me.Btndelete.Text = "delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Btnsearch
        '
        Me.Btnsearch.Location = New System.Drawing.Point(307, 421)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.Btnsearch.TabIndex = 9
        Me.Btnsearch.Text = "search"
        Me.Btnsearch.UseVisualStyleBackColor = True
        '
        'TxtdrugID
        '
        Me.TxtdrugID.Location = New System.Drawing.Point(76, 1)
        Me.TxtdrugID.Name = "TxtdrugID"
        Me.TxtdrugID.Size = New System.Drawing.Size(121, 22)
        Me.TxtdrugID.TabIndex = 11
        '
        'Txtdrugtype
        '
        Me.Txtdrugtype.Location = New System.Drawing.Point(76, 56)
        Me.Txtdrugtype.Name = "Txtdrugtype"
        Me.Txtdrugtype.Size = New System.Drawing.Size(121, 22)
        Me.Txtdrugtype.TabIndex = 12
        '
        'Txtdrugcode
        '
        Me.Txtdrugcode.Location = New System.Drawing.Point(76, 110)
        Me.Txtdrugcode.Name = "Txtdrugcode"
        Me.Txtdrugcode.Size = New System.Drawing.Size(121, 22)
        Me.Txtdrugcode.TabIndex = 13
        '
        'ComboBoxdrugname
        '
        Me.ComboBoxdrugname.FormattingEnabled = True
        Me.ComboBoxdrugname.Items.AddRange(New Object() {"calcium", "glute", "calcium", "calories", "pectin"})
        Me.ComboBoxdrugname.Location = New System.Drawing.Point(76, 152)
        Me.ComboBoxdrugname.Name = "ComboBoxdrugname"
        Me.ComboBoxdrugname.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxdrugname.TabIndex = 14
        '
        'ComboBoxnursename
        '
        Me.ComboBoxnursename.FormattingEnabled = True
        Me.ComboBoxnursename.Items.AddRange(New Object() {"12121212", "Jesse", "mary", "wamaitha", "sam"})
        Me.ComboBoxnursename.Location = New System.Drawing.Point(76, 189)
        Me.ComboBoxnursename.Name = "ComboBoxnursename"
        Me.ComboBoxnursename.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxnursename.TabIndex = 15
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"castor oil", "aqua tablets", "syrups", "capsule", "Abz", "ARV", "gluten", "protein"})
        Me.ListBox1.Location = New System.Drawing.Point(696, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(118, 148)
        Me.ListBox1.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-5, 287)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(819, 128)
        Me.DataGridView1.TabIndex = 18
        '
        'Btnupdate
        '
        Me.Btnupdate.Location = New System.Drawing.Point(451, 421)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.Btnupdate.TabIndex = 19
        Me.Btnupdate.Text = "update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'Txtdateofexp
        '
        Me.Txtdateofexp.Location = New System.Drawing.Point(79, 258)
        Me.Txtdateofexp.Name = "Txtdateofexp"
        Me.Txtdateofexp.Size = New System.Drawing.Size(118, 22)
        Me.Txtdateofexp.TabIndex = 20
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(311, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 22)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Btnwaterbilling
        '
        Me.Btnwaterbilling.Location = New System.Drawing.Point(683, 421)
        Me.Btnwaterbilling.Name = "Btnwaterbilling"
        Me.Btnwaterbilling.Size = New System.Drawing.Size(81, 23)
        Me.Btnwaterbilling.TabIndex = 22
        Me.Btnwaterbilling.Text = "waterbilling"
        Me.Btnwaterbilling.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Btnprint
        '
        Me.Btnprint.Location = New System.Drawing.Point(563, 421)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(75, 23)
        Me.Btnprint.TabIndex = 23
        Me.Btnprint.Text = "print"
        Me.Btnprint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(416, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 52)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 456)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btnprint)
        Me.Controls.Add(Me.Btnwaterbilling)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Txtdateofexp)
        Me.Controls.Add(Me.ComboBoxnursename)
        Me.Controls.Add(Me.Btnupdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBoxdrugname)
        Me.Controls.Add(Me.Txtdrugcode)
        Me.Controls.Add(Me.Txtdrugtype)
        Me.Controls.Add(Me.TxtdrugID)
        Me.Controls.Add(Me.Btnsearch)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Lbldateofexp)
        Me.Controls.Add(Me.LblNursename)
        Me.Controls.Add(Me.Lbldrugname)
        Me.Controls.Add(Me.Lbldrugcode)
        Me.Controls.Add(Me.Lbldrugtype)
        Me.Controls.Add(Me.LbldrugID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "dashboard"
        Me.Text = "dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbldrugID As System.Windows.Forms.Label
    Friend WithEvents Lbldrugtype As System.Windows.Forms.Label
    Friend WithEvents Lbldrugcode As System.Windows.Forms.Label
    Friend WithEvents Lbldrugname As System.Windows.Forms.Label
    Friend WithEvents LblNursename As System.Windows.Forms.Label
    Friend WithEvents Lbldateofexp As System.Windows.Forms.Label
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnsearch As System.Windows.Forms.Button
    Friend WithEvents TxtdrugID As System.Windows.Forms.TextBox
    Friend WithEvents Txtdrugtype As System.Windows.Forms.TextBox
    Friend WithEvents Txtdrugcode As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxdrugname As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxnursename As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Txtdateofexp As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btnwaterbilling As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Btnprint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

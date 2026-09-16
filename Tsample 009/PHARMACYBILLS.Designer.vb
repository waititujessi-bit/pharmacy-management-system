<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PHARMACYBILLS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PHARMACYBILLS))
        Me.LBLpatientname = New System.Windows.Forms.Label()
        Me.LBLmedicineprescribed = New System.Windows.Forms.Label()
        Me.LBLquantity = New System.Windows.Forms.Label()
        Me.LBLunitprice = New System.Windows.Forms.Label()
        Me.LBLtotalbill = New System.Windows.Forms.Label()
        Me.Btncalculate = New System.Windows.Forms.Button()
        Me.BtnADD = New System.Windows.Forms.Button()
        Me.BtnPRINT = New System.Windows.Forms.Button()
        Me.Txtpatientname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxmedicineprescried = New System.Windows.Forms.ComboBox()
        Me.Txtquantity = New System.Windows.Forms.TextBox()
        Me.Txtunitprice = New System.Windows.Forms.TextBox()
        Me.Txttotalbill = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.patientname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medicineprescribed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalbill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLpatientname
        '
        Me.LBLpatientname.AutoSize = True
        Me.LBLpatientname.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBLpatientname.Location = New System.Drawing.Point(3, 9)
        Me.LBLpatientname.Name = "LBLpatientname"
        Me.LBLpatientname.Size = New System.Drawing.Size(86, 17)
        Me.LBLpatientname.TabIndex = 1
        Me.LBLpatientname.Text = "patientname"
        '
        'LBLmedicineprescribed
        '
        Me.LBLmedicineprescribed.AutoSize = True
        Me.LBLmedicineprescribed.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBLmedicineprescribed.Location = New System.Drawing.Point(3, 61)
        Me.LBLmedicineprescribed.Name = "LBLmedicineprescribed"
        Me.LBLmedicineprescribed.Size = New System.Drawing.Size(131, 17)
        Me.LBLmedicineprescribed.TabIndex = 2
        Me.LBLmedicineprescribed.Text = "medicineprescribed"
        '
        'LBLquantity
        '
        Me.LBLquantity.AutoSize = True
        Me.LBLquantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBLquantity.Location = New System.Drawing.Point(3, 113)
        Me.LBLquantity.Name = "LBLquantity"
        Me.LBLquantity.Size = New System.Drawing.Size(58, 17)
        Me.LBLquantity.TabIndex = 3
        Me.LBLquantity.Text = "quantity"
        '
        'LBLunitprice
        '
        Me.LBLunitprice.AutoSize = True
        Me.LBLunitprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBLunitprice.Location = New System.Drawing.Point(3, 179)
        Me.LBLunitprice.Name = "LBLunitprice"
        Me.LBLunitprice.Size = New System.Drawing.Size(62, 17)
        Me.LBLunitprice.TabIndex = 4
        Me.LBLunitprice.Text = "unitprice"
        '
        'LBLtotalbill
        '
        Me.LBLtotalbill.AutoSize = True
        Me.LBLtotalbill.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBLtotalbill.Location = New System.Drawing.Point(3, 235)
        Me.LBLtotalbill.Name = "LBLtotalbill"
        Me.LBLtotalbill.Size = New System.Drawing.Size(52, 17)
        Me.LBLtotalbill.TabIndex = 5
        Me.LBLtotalbill.Text = "totalbill"
        '
        'Btncalculate
        '
        Me.Btncalculate.Location = New System.Drawing.Point(544, 292)
        Me.Btncalculate.Name = "Btncalculate"
        Me.Btncalculate.Size = New System.Drawing.Size(170, 33)
        Me.Btncalculate.TabIndex = 6
        Me.Btncalculate.Text = "calculate"
        Me.Btncalculate.UseVisualStyleBackColor = True
        '
        'BtnADD
        '
        Me.BtnADD.Location = New System.Drawing.Point(544, 263)
        Me.BtnADD.Name = "BtnADD"
        Me.BtnADD.Size = New System.Drawing.Size(75, 23)
        Me.BtnADD.TabIndex = 7
        Me.BtnADD.Text = "ADD"
        Me.BtnADD.UseVisualStyleBackColor = True
        '
        'BtnPRINT
        '
        Me.BtnPRINT.Location = New System.Drawing.Point(639, 263)
        Me.BtnPRINT.Name = "BtnPRINT"
        Me.BtnPRINT.Size = New System.Drawing.Size(75, 23)
        Me.BtnPRINT.TabIndex = 8
        Me.BtnPRINT.Text = "PRINT"
        Me.BtnPRINT.UseVisualStyleBackColor = True
        '
        'Txtpatientname
        '
        Me.Txtpatientname.Location = New System.Drawing.Point(225, 6)
        Me.Txtpatientname.Name = "Txtpatientname"
        Me.Txtpatientname.Size = New System.Drawing.Size(273, 22)
        Me.Txtpatientname.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(752, 257)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ComboBoxmedicineprescried
        '
        Me.ComboBoxmedicineprescried.FormattingEnabled = True
        Me.ComboBoxmedicineprescried.Items.AddRange(New Object() {"Ketoconazole Cream ", "", "Salicylic Acid Lotion", "        ", "Atorvastatin 20mg", "Metoprolol 50mg", "Paracetamol Syrup 120ml", "", "Amoxicillin Suspension 125mg", "", "Vitamin C Tablets (adult)", "Ibuprofen 200mg (adult) "})
        Me.ComboBoxmedicineprescried.Location = New System.Drawing.Point(225, 54)
        Me.ComboBoxmedicineprescried.Name = "ComboBoxmedicineprescried"
        Me.ComboBoxmedicineprescried.Size = New System.Drawing.Size(273, 24)
        Me.ComboBoxmedicineprescried.TabIndex = 10
        '
        'Txtquantity
        '
        Me.Txtquantity.Location = New System.Drawing.Point(225, 108)
        Me.Txtquantity.Name = "Txtquantity"
        Me.Txtquantity.Size = New System.Drawing.Size(273, 22)
        Me.Txtquantity.TabIndex = 11
        '
        'Txtunitprice
        '
        Me.Txtunitprice.Location = New System.Drawing.Point(225, 174)
        Me.Txtunitprice.Name = "Txtunitprice"
        Me.Txtunitprice.Size = New System.Drawing.Size(273, 22)
        Me.Txtunitprice.TabIndex = 12
        '
        'Txttotalbill
        '
        Me.Txttotalbill.Location = New System.Drawing.Point(225, 232)
        Me.Txttotalbill.Name = "Txttotalbill"
        Me.Txttotalbill.Size = New System.Drawing.Size(273, 22)
        Me.Txttotalbill.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"ketocoazolecream               250", "salicylic acid lotion              350", "atorvastation 20mg                250", "metopotal 50mg                     180", "paracetamol                             120", "amoxilie                                   180", "vitamiC                                      200", "luprofen                                     60"})
        Me.ListBox1.Location = New System.Drawing.Point(504, 9)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(242, 180)
        Me.ListBox1.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.patientname, Me.medicineprescribed, Me.quantity, Me.unitprice, Me.totalbill})
        Me.DataGridView1.Location = New System.Drawing.Point(-6, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(529, 73)
        Me.DataGridView1.TabIndex = 15
        '
        'patientname
        '
        Me.patientname.HeaderText = "patientname"
        Me.patientname.Name = "patientname"
        '
        'medicineprescribed
        '
        Me.medicineprescribed.HeaderText = "medicineprescribed"
        Me.medicineprescribed.Name = "medicineprescribed"
        '
        'quantity
        '
        Me.quantity.HeaderText = "quantity"
        Me.quantity.Name = "quantity"
        '
        'unitprice
        '
        Me.unitprice.HeaderText = "unitprice"
        Me.unitprice.Name = "unitprice"
        '
        'totalbill
        '
        Me.totalbill.HeaderText = "totalbill"
        Me.totalbill.Name = "totalbill"
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
        'PHARMACYBILLS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 405)
        Me.Controls.Add(Me.LBLmedicineprescribed)
        Me.Controls.Add(Me.LBLpatientname)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Txttotalbill)
        Me.Controls.Add(Me.Txtunitprice)
        Me.Controls.Add(Me.Txtquantity)
        Me.Controls.Add(Me.ComboBoxmedicineprescried)
        Me.Controls.Add(Me.Txtpatientname)
        Me.Controls.Add(Me.BtnPRINT)
        Me.Controls.Add(Me.BtnADD)
        Me.Controls.Add(Me.Btncalculate)
        Me.Controls.Add(Me.LBLtotalbill)
        Me.Controls.Add(Me.LBLunitprice)
        Me.Controls.Add(Me.LBLquantity)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PHARMACYBILLS"
        Me.Text = "PHARMACYBILLS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLpatientname As System.Windows.Forms.Label
    Friend WithEvents LBLmedicineprescribed As System.Windows.Forms.Label
    Friend WithEvents LBLquantity As System.Windows.Forms.Label
    Friend WithEvents LBLunitprice As System.Windows.Forms.Label
    Friend WithEvents LBLtotalbill As System.Windows.Forms.Label
    Friend WithEvents Btncalculate As System.Windows.Forms.Button
    Friend WithEvents BtnADD As System.Windows.Forms.Button
    Friend WithEvents BtnPRINT As System.Windows.Forms.Button
    Friend WithEvents Txtpatientname As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBoxmedicineprescried As System.Windows.Forms.ComboBox
    Friend WithEvents Txtquantity As System.Windows.Forms.TextBox
    Friend WithEvents Txtunitprice As System.Windows.Forms.TextBox
    Friend WithEvents Txttotalbill As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents patientname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medicineprescribed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unitprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalbill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class

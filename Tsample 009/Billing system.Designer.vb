<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing_system
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing_system))
        Me.lblcustomernumer = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.Lblplaceofresidence = New System.Windows.Forms.Label()
        Me.Lblcustomernumber = New System.Windows.Forms.Label()
        Me.Lblpreviousreading = New System.Windows.Forms.Label()
        Me.lblcurrentreading = New System.Windows.Forms.Label()
        Me.Lbltotalbill = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Btnprintbill = New System.Windows.Forms.Button()
        Me.Txtcustomerumer = New System.Windows.Forms.TextBox()
        Me.Txtcustomertname = New System.Windows.Forms.TextBox()
        Me.Txtplaceofresidence = New System.Windows.Forms.TextBox()
        Me.Txtphonenumber = New System.Windows.Forms.TextBox()
        Me.TXTPREVIOUSREADING = New System.Windows.Forms.TextBox()
        Me.Txtcurrentreading = New System.Windows.Forms.TextBox()
        Me.Txttotalbill = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Btnpritreport = New System.Windows.Forms.Button()
        Me.btnschoolgrade = New System.Windows.Forms.Button()
        Me.TXTPHONE = New System.Windows.Forms.TextBox()
        Me.TXTAMOUNT = New System.Windows.Forms.TextBox()
        Me.TXTINVOICE = New System.Windows.Forms.TextBox()
        Me.BTNPAYMPESA = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcustomernumer
        '
        Me.lblcustomernumer.AutoSize = True
        Me.lblcustomernumer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomernumer.Location = New System.Drawing.Point(2, 67)
        Me.lblcustomernumer.Name = "lblcustomernumer"
        Me.lblcustomernumer.Size = New System.Drawing.Size(193, 29)
        Me.lblcustomernumer.TabIndex = 0
        Me.lblcustomernumer.Text = "customernumer"
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(2, 118)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(214, 32)
        Me.lblcustomername.TabIndex = 1
        Me.lblcustomername.Text = "customername"
        '
        'Lblplaceofresidence
        '
        Me.Lblplaceofresidence.AutoSize = True
        Me.Lblplaceofresidence.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblplaceofresidence.Location = New System.Drawing.Point(2, 165)
        Me.Lblplaceofresidence.Name = "Lblplaceofresidence"
        Me.Lblplaceofresidence.Size = New System.Drawing.Size(248, 32)
        Me.Lblplaceofresidence.TabIndex = 2
        Me.Lblplaceofresidence.Text = "placeofresidence"
        '
        'Lblcustomernumber
        '
        Me.Lblcustomernumber.AutoSize = True
        Me.Lblcustomernumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcustomernumber.Location = New System.Drawing.Point(2, 209)
        Me.Lblcustomernumber.Name = "Lblcustomernumber"
        Me.Lblcustomernumber.Size = New System.Drawing.Size(202, 32)
        Me.Lblcustomernumber.TabIndex = 3
        Me.Lblcustomernumber.Text = "phonenumber"
        '
        'Lblpreviousreading
        '
        Me.Lblpreviousreading.AutoSize = True
        Me.Lblpreviousreading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpreviousreading.Location = New System.Drawing.Point(2, 253)
        Me.Lblpreviousreading.Name = "Lblpreviousreading"
        Me.Lblpreviousreading.Size = New System.Drawing.Size(234, 32)
        Me.Lblpreviousreading.TabIndex = 4
        Me.Lblpreviousreading.Text = "previousreading"
        '
        'lblcurrentreading
        '
        Me.lblcurrentreading.AutoSize = True
        Me.lblcurrentreading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentreading.Location = New System.Drawing.Point(2, 291)
        Me.lblcurrentreading.Name = "lblcurrentreading"
        Me.lblcurrentreading.Size = New System.Drawing.Size(199, 32)
        Me.lblcurrentreading.TabIndex = 5
        Me.lblcurrentreading.Text = "currentreading"
        '
        'Lbltotalbill
        '
        Me.Lbltotalbill.AutoSize = True
        Me.Lbltotalbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotalbill.Location = New System.Drawing.Point(2, 338)
        Me.Lbltotalbill.Name = "Lbltotalbill"
        Me.Lbltotalbill.Size = New System.Drawing.Size(116, 32)
        Me.Lbltotalbill.TabIndex = 6
        Me.Lbltotalbill.Text = "totalbill"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(38, 416)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(163, 85)
        Me.BtnCalculate.TabIndex = 7
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'Btnadd
        '
        Me.Btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(227, 416)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(117, 85)
        Me.Btnadd.TabIndex = 8
        Me.Btnadd.Text = "add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'Btnprintbill
        '
        Me.Btnprintbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprintbill.Location = New System.Drawing.Point(432, 416)
        Me.Btnprintbill.Name = "Btnprintbill"
        Me.Btnprintbill.Size = New System.Drawing.Size(98, 85)
        Me.Btnprintbill.TabIndex = 9
        Me.Btnprintbill.Text = "printbill"
        Me.Btnprintbill.UseVisualStyleBackColor = True
        '
        'Txtcustomerumer
        '
        Me.Txtcustomerumer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcustomerumer.Location = New System.Drawing.Point(227, 61)
        Me.Txtcustomerumer.Name = "Txtcustomerumer"
        Me.Txtcustomerumer.Size = New System.Drawing.Size(100, 38)
        Me.Txtcustomerumer.TabIndex = 10
        '
        'Txtcustomertname
        '
        Me.Txtcustomertname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcustomertname.Location = New System.Drawing.Point(222, 112)
        Me.Txtcustomertname.Name = "Txtcustomertname"
        Me.Txtcustomertname.Size = New System.Drawing.Size(100, 38)
        Me.Txtcustomertname.TabIndex = 11
        '
        'Txtplaceofresidence
        '
        Me.Txtplaceofresidence.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtplaceofresidence.Location = New System.Drawing.Point(222, 165)
        Me.Txtplaceofresidence.Name = "Txtplaceofresidence"
        Me.Txtplaceofresidence.Size = New System.Drawing.Size(100, 38)
        Me.Txtplaceofresidence.TabIndex = 12
        '
        'Txtphonenumber
        '
        Me.Txtphonenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtphonenumber.Location = New System.Drawing.Point(210, 209)
        Me.Txtphonenumber.Name = "Txtphonenumber"
        Me.Txtphonenumber.Size = New System.Drawing.Size(100, 38)
        Me.Txtphonenumber.TabIndex = 13
        '
        'TXTPREVIOUSREADING
        '
        Me.TXTPREVIOUSREADING.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPREVIOUSREADING.Location = New System.Drawing.Point(277, 263)
        Me.TXTPREVIOUSREADING.Name = "TXTPREVIOUSREADING"
        Me.TXTPREVIOUSREADING.Size = New System.Drawing.Size(100, 38)
        Me.TXTPREVIOUSREADING.TabIndex = 14
        '
        'Txtcurrentreading
        '
        Me.Txtcurrentreading.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcurrentreading.Location = New System.Drawing.Point(277, 301)
        Me.Txtcurrentreading.Name = "Txtcurrentreading"
        Me.Txtcurrentreading.Size = New System.Drawing.Size(100, 38)
        Me.Txtcurrentreading.TabIndex = 15
        '
        'Txttotalbill
        '
        Me.Txttotalbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotalbill.Location = New System.Drawing.Point(277, 349)
        Me.Txttotalbill.Name = "Txttotalbill"
        Me.Txttotalbill.Size = New System.Drawing.Size(100, 38)
        Me.Txttotalbill.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(383, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(596, 293)
        Me.DataGridView1.TabIndex = 17
        '
        'Btnclear
        '
        Me.Btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.Location = New System.Drawing.Point(608, 431)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(157, 70)
        Me.Btnclear.TabIndex = 18
        Me.Btnclear.Text = "clear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(946, 43)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "WELCOME  MAJI WATER MANAGEMENT SYSTEM"
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
        'Btnpritreport
        '
        Me.Btnpritreport.Location = New System.Drawing.Point(845, 431)
        Me.Btnpritreport.Name = "Btnpritreport"
        Me.Btnpritreport.Size = New System.Drawing.Size(203, 43)
        Me.Btnpritreport.TabIndex = 20
        Me.Btnpritreport.Text = "pritreport"
        Me.Btnpritreport.UseVisualStyleBackColor = True
        '
        'btnschoolgrade
        '
        Me.btnschoolgrade.Location = New System.Drawing.Point(1048, 269)
        Me.btnschoolgrade.Name = "btnschoolgrade"
        Me.btnschoolgrade.Size = New System.Drawing.Size(124, 23)
        Me.btnschoolgrade.TabIndex = 21
        Me.btnschoolgrade.Text = "schoolgrade"
        Me.btnschoolgrade.UseVisualStyleBackColor = True
        '
        'TXTPHONE
        '
        Me.TXTPHONE.Location = New System.Drawing.Point(985, 47)
        Me.TXTPHONE.Name = "TXTPHONE"
        Me.TXTPHONE.Size = New System.Drawing.Size(157, 22)
        Me.TXTPHONE.TabIndex = 22
        Me.TXTPHONE.Text = "254708374149"
        '
        'TXTAMOUNT
        '
        Me.TXTAMOUNT.Location = New System.Drawing.Point(985, 132)
        Me.TXTAMOUNT.Name = "TXTAMOUNT"
        Me.TXTAMOUNT.Size = New System.Drawing.Size(157, 22)
        Me.TXTAMOUNT.TabIndex = 23
        Me.TXTAMOUNT.Text = "10"
        '
        'TXTINVOICE
        '
        Me.TXTINVOICE.Location = New System.Drawing.Point(985, 186)
        Me.TXTINVOICE.Name = "TXTINVOICE"
        Me.TXTINVOICE.Size = New System.Drawing.Size(187, 22)
        Me.TXTINVOICE.TabIndex = 24
        Me.TXTINVOICE.Text = "INV001"
        '
        'BTNPAYMPESA
        '
        Me.BTNPAYMPESA.Location = New System.Drawing.Point(1034, 336)
        Me.BTNPAYMPESA.Name = "BTNPAYMPESA"
        Me.BTNPAYMPESA.Size = New System.Drawing.Size(130, 23)
        Me.BTNPAYMPESA.TabIndex = 25
        Me.BTNPAYMPESA.Text = "M-PESA"
        Me.BTNPAYMPESA.UseVisualStyleBackColor = True
        '
        'Billing_system
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 492)
        Me.Controls.Add(Me.BTNPAYMPESA)
        Me.Controls.Add(Me.TXTINVOICE)
        Me.Controls.Add(Me.TXTAMOUNT)
        Me.Controls.Add(Me.TXTPHONE)
        Me.Controls.Add(Me.btnschoolgrade)
        Me.Controls.Add(Me.Btnpritreport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Txttotalbill)
        Me.Controls.Add(Me.Txtcurrentreading)
        Me.Controls.Add(Me.TXTPREVIOUSREADING)
        Me.Controls.Add(Me.Txtphonenumber)
        Me.Controls.Add(Me.Txtplaceofresidence)
        Me.Controls.Add(Me.Txtcustomertname)
        Me.Controls.Add(Me.Txtcustomerumer)
        Me.Controls.Add(Me.Btnprintbill)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.Lbltotalbill)
        Me.Controls.Add(Me.lblcurrentreading)
        Me.Controls.Add(Me.Lblpreviousreading)
        Me.Controls.Add(Me.Lblcustomernumber)
        Me.Controls.Add(Me.Lblplaceofresidence)
        Me.Controls.Add(Me.lblcustomername)
        Me.Controls.Add(Me.lblcustomernumer)
        Me.Name = "Billing_system"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcustomernumer As System.Windows.Forms.Label
    Friend WithEvents lblcustomername As System.Windows.Forms.Label
    Friend WithEvents Lblplaceofresidence As System.Windows.Forms.Label
    Friend WithEvents Lblcustomernumber As System.Windows.Forms.Label
    Friend WithEvents Lblpreviousreading As System.Windows.Forms.Label
    Friend WithEvents lblcurrentreading As System.Windows.Forms.Label
    Friend WithEvents Lbltotalbill As System.Windows.Forms.Label
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Btnprintbill As System.Windows.Forms.Button
    Friend WithEvents Txtcustomerumer As System.Windows.Forms.TextBox
    Friend WithEvents Txtcustomertname As System.Windows.Forms.TextBox
    Friend WithEvents Txtplaceofresidence As System.Windows.Forms.TextBox
    Friend WithEvents Txtphonenumber As System.Windows.Forms.TextBox
    Friend WithEvents TXTPREVIOUSREADING As System.Windows.Forms.TextBox
    Friend WithEvents Txtcurrentreading As System.Windows.Forms.TextBox
    Friend WithEvents Txttotalbill As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btnclear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Btnpritreport As System.Windows.Forms.Button
    Friend WithEvents btnschoolgrade As System.Windows.Forms.Button
    Friend WithEvents TXTPHONE As System.Windows.Forms.TextBox
    Friend WithEvents TXTAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents TXTINVOICE As System.Windows.Forms.TextBox
    Friend WithEvents BTNPAYMPESA As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class schoolgrade
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(schoolgrade))
        Me.lbladmissionnumber = New System.Windows.Forms.Label()
        Me.Lblname = New System.Windows.Forms.Label()
        Me.Lblclass = New System.Windows.Forms.Label()
        Me.Lblmaths = New System.Windows.Forms.Label()
        Me.Lblenglish = New System.Windows.Forms.Label()
        Me.Lblscience = New System.Windows.Forms.Label()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.Lblaverage = New System.Windows.Forms.Label()
        Me.Lblgrade = New System.Windows.Forms.Label()
        Me.lblremarks = New System.Windows.Forms.Label()
        Me.TXTadmissionnumber = New System.Windows.Forms.TextBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Txtclass = New System.Windows.Forms.TextBox()
        Me.Txtmaths = New System.Windows.Forms.TextBox()
        Me.Txtenglish = New System.Windows.Forms.TextBox()
        Me.TXTsciece = New System.Windows.Forms.TextBox()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.Txtaverage = New System.Windows.Forms.TextBox()
        Me.Txtgrade = New System.Windows.Forms.TextBox()
        Me.Txtremarks = New System.Windows.Forms.TextBox()
        Me.Btncalculate = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnprint = New System.Windows.Forms.Button()
        Me.BtnEXIT = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbladmissionnumber
        '
        Me.lbladmissionnumber.AutoSize = True
        Me.lbladmissionnumber.Location = New System.Drawing.Point(3, 4)
        Me.lbladmissionnumber.Name = "lbladmissionnumber"
        Me.lbladmissionnumber.Size = New System.Drawing.Size(119, 17)
        Me.lbladmissionnumber.TabIndex = 0
        Me.lbladmissionnumber.Text = "admissionnumber"
        '
        'Lblname
        '
        Me.Lblname.AutoSize = True
        Me.Lblname.Location = New System.Drawing.Point(3, 37)
        Me.Lblname.Name = "Lblname"
        Me.Lblname.Size = New System.Drawing.Size(43, 17)
        Me.Lblname.TabIndex = 1
        Me.Lblname.Text = "name"
        '
        'Lblclass
        '
        Me.Lblclass.AutoSize = True
        Me.Lblclass.Location = New System.Drawing.Point(3, 72)
        Me.Lblclass.Name = "Lblclass"
        Me.Lblclass.Size = New System.Drawing.Size(40, 17)
        Me.Lblclass.TabIndex = 2
        Me.Lblclass.Text = "class"
        '
        'Lblmaths
        '
        Me.Lblmaths.AutoSize = True
        Me.Lblmaths.Location = New System.Drawing.Point(3, 118)
        Me.Lblmaths.Name = "Lblmaths"
        Me.Lblmaths.Size = New System.Drawing.Size(46, 17)
        Me.Lblmaths.TabIndex = 3
        Me.Lblmaths.Text = "maths"
        '
        'Lblenglish
        '
        Me.Lblenglish.AutoSize = True
        Me.Lblenglish.Location = New System.Drawing.Point(3, 158)
        Me.Lblenglish.Name = "Lblenglish"
        Me.Lblenglish.Size = New System.Drawing.Size(53, 17)
        Me.Lblenglish.TabIndex = 4
        Me.Lblenglish.Text = "english"
        '
        'Lblscience
        '
        Me.Lblscience.AutoSize = True
        Me.Lblscience.Location = New System.Drawing.Point(3, 202)
        Me.Lblscience.Name = "Lblscience"
        Me.Lblscience.Size = New System.Drawing.Size(56, 17)
        Me.Lblscience.TabIndex = 5
        Me.Lblscience.Text = "science"
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Location = New System.Drawing.Point(3, 236)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(35, 17)
        Me.Lbltotal.TabIndex = 6
        Me.Lbltotal.Text = "total"
        '
        'Lblaverage
        '
        Me.Lblaverage.AutoSize = True
        Me.Lblaverage.Location = New System.Drawing.Point(-1, 271)
        Me.Lblaverage.Name = "Lblaverage"
        Me.Lblaverage.Size = New System.Drawing.Size(60, 17)
        Me.Lblaverage.TabIndex = 7
        Me.Lblaverage.Text = "average"
        '
        'Lblgrade
        '
        Me.Lblgrade.AutoSize = True
        Me.Lblgrade.Location = New System.Drawing.Point(3, 327)
        Me.Lblgrade.Name = "Lblgrade"
        Me.Lblgrade.Size = New System.Drawing.Size(45, 17)
        Me.Lblgrade.TabIndex = 8
        Me.Lblgrade.Text = "grade"
        '
        'lblremarks
        '
        Me.lblremarks.AutoSize = True
        Me.lblremarks.Location = New System.Drawing.Point(3, 374)
        Me.lblremarks.Name = "lblremarks"
        Me.lblremarks.Size = New System.Drawing.Size(59, 17)
        Me.lblremarks.TabIndex = 9
        Me.lblremarks.Text = "remarks"
        '
        'TXTadmissionnumber
        '
        Me.TXTadmissionnumber.Location = New System.Drawing.Point(152, 4)
        Me.TXTadmissionnumber.Name = "TXTadmissionnumber"
        Me.TXTadmissionnumber.Size = New System.Drawing.Size(100, 22)
        Me.TXTadmissionnumber.TabIndex = 10
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(152, 32)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(100, 22)
        Me.Txtname.TabIndex = 11
        '
        'Txtclass
        '
        Me.Txtclass.Location = New System.Drawing.Point(152, 67)
        Me.Txtclass.Name = "Txtclass"
        Me.Txtclass.Size = New System.Drawing.Size(100, 22)
        Me.Txtclass.TabIndex = 12
        '
        'Txtmaths
        '
        Me.Txtmaths.Location = New System.Drawing.Point(152, 113)
        Me.Txtmaths.Name = "Txtmaths"
        Me.Txtmaths.Size = New System.Drawing.Size(100, 22)
        Me.Txtmaths.TabIndex = 13
        '
        'Txtenglish
        '
        Me.Txtenglish.Location = New System.Drawing.Point(152, 153)
        Me.Txtenglish.Name = "Txtenglish"
        Me.Txtenglish.Size = New System.Drawing.Size(100, 22)
        Me.Txtenglish.TabIndex = 14
        '
        'TXTsciece
        '
        Me.TXTsciece.Location = New System.Drawing.Point(152, 197)
        Me.TXTsciece.Name = "TXTsciece"
        Me.TXTsciece.Size = New System.Drawing.Size(100, 22)
        Me.TXTsciece.TabIndex = 15
        '
        'Txttotal
        '
        Me.Txttotal.Location = New System.Drawing.Point(152, 231)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(100, 22)
        Me.Txttotal.TabIndex = 16
        '
        'Txtaverage
        '
        Me.Txtaverage.Location = New System.Drawing.Point(152, 271)
        Me.Txtaverage.Name = "Txtaverage"
        Me.Txtaverage.Size = New System.Drawing.Size(100, 22)
        Me.Txtaverage.TabIndex = 17
        '
        'Txtgrade
        '
        Me.Txtgrade.Location = New System.Drawing.Point(152, 322)
        Me.Txtgrade.Name = "Txtgrade"
        Me.Txtgrade.Size = New System.Drawing.Size(100, 22)
        Me.Txtgrade.TabIndex = 18
        '
        'Txtremarks
        '
        Me.Txtremarks.Location = New System.Drawing.Point(152, 369)
        Me.Txtremarks.Name = "Txtremarks"
        Me.Txtremarks.Size = New System.Drawing.Size(100, 22)
        Me.Txtremarks.TabIndex = 19
        '
        'Btncalculate
        '
        Me.Btncalculate.Location = New System.Drawing.Point(12, 409)
        Me.Btncalculate.Name = "Btncalculate"
        Me.Btncalculate.Size = New System.Drawing.Size(75, 23)
        Me.Btncalculate.TabIndex = 20
        Me.Btncalculate.Text = "Calculate"
        Me.Btncalculate.UseVisualStyleBackColor = True
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(143, 409)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(75, 23)
        Me.Btnclear.TabIndex = 21
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Btnprint
        '
        Me.Btnprint.Location = New System.Drawing.Point(307, 409)
        Me.Btnprint.Name = "Btnprint"
        Me.Btnprint.Size = New System.Drawing.Size(75, 23)
        Me.Btnprint.TabIndex = 22
        Me.Btnprint.Text = "print"
        Me.Btnprint.UseVisualStyleBackColor = True
        '
        'BtnEXIT
        '
        Me.BtnEXIT.Location = New System.Drawing.Point(438, 409)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(72, 25)
        Me.BtnEXIT.TabIndex = 23
        Me.BtnEXIT.Text = "EXIT"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(302, 58)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(323, 258)
        Me.DataGridView1.TabIndex = 24
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
        'schoolgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 444)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnEXIT)
        Me.Controls.Add(Me.Btnprint)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btncalculate)
        Me.Controls.Add(Me.Txtremarks)
        Me.Controls.Add(Me.Txtgrade)
        Me.Controls.Add(Me.Txtaverage)
        Me.Controls.Add(Me.Txttotal)
        Me.Controls.Add(Me.TXTsciece)
        Me.Controls.Add(Me.Txtenglish)
        Me.Controls.Add(Me.Txtmaths)
        Me.Controls.Add(Me.Txtclass)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.TXTadmissionnumber)
        Me.Controls.Add(Me.lblremarks)
        Me.Controls.Add(Me.Lblgrade)
        Me.Controls.Add(Me.Lblaverage)
        Me.Controls.Add(Me.Lbltotal)
        Me.Controls.Add(Me.Lblscience)
        Me.Controls.Add(Me.Lblenglish)
        Me.Controls.Add(Me.Lblmaths)
        Me.Controls.Add(Me.Lblclass)
        Me.Controls.Add(Me.Lblname)
        Me.Controls.Add(Me.lbladmissionnumber)
        Me.Name = "schoolgrade"
        Me.Text = "schoolgrade"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbladmissionnumber As System.Windows.Forms.Label
    Friend WithEvents Lblname As System.Windows.Forms.Label
    Friend WithEvents Lblclass As System.Windows.Forms.Label
    Friend WithEvents Lblmaths As System.Windows.Forms.Label
    Friend WithEvents Lblenglish As System.Windows.Forms.Label
    Friend WithEvents Lblscience As System.Windows.Forms.Label
    Friend WithEvents Lbltotal As System.Windows.Forms.Label
    Friend WithEvents Lblaverage As System.Windows.Forms.Label
    Friend WithEvents Lblgrade As System.Windows.Forms.Label
    Friend WithEvents lblremarks As System.Windows.Forms.Label
    Friend WithEvents TXTadmissionnumber As System.Windows.Forms.TextBox
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Txtclass As System.Windows.Forms.TextBox
    Friend WithEvents Txtmaths As System.Windows.Forms.TextBox
    Friend WithEvents Txtenglish As System.Windows.Forms.TextBox
    Friend WithEvents TXTsciece As System.Windows.Forms.TextBox
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Txtaverage As System.Windows.Forms.TextBox
    Friend WithEvents Txtgrade As System.Windows.Forms.TextBox
    Friend WithEvents Txtremarks As System.Windows.Forms.TextBox
    Friend WithEvents Btncalculate As System.Windows.Forms.Button
    Friend WithEvents Btnclear As System.Windows.Forms.Button
    Friend WithEvents Btnprint As System.Windows.Forms.Button
    Friend WithEvents BtnEXIT As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class

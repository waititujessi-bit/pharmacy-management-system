
Public Class PHARMACYBILLS

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles LBLunitprice.Click

    End Sub

    Private Sub Btncalculate_Click(sender As System.Object, e As System.EventArgs) Handles Btncalculate.Click
        Dim patientName As String
        Dim medicine As String
        Dim qty As Integer
        Dim unitPrice As Double
        Dim medTotal As Double
        Dim consultation As Double = 1000
        Dim grandTotal As Double


        patientName = Txtpatientname.Text
        medicine = ComboBoxmedicineprescried.Text

        If patientName = "" Or medicine = "" Or Not IsNumeric(Txtquantity.Text) Then
            MessageBox.Show("Fill all fields")
            Exit Sub
        End If

        qty = CInt(Txtquantity.Text)


        Select Case medicine
            Case "Ketoconazole Cream"
                unitPrice = 250
            Case "Salicylic Acid Lotion"
                unitPrice = 350
            Case "Atorvastatin 20mg"
                unitPrice = 250
            Case "Metoprolol 50mg"
                unitPrice = 180
            Case "Paracetamol Syrup 120ml"
                unitPrice = 120
            Case "Amoxicillin Suspension 125mg"
                unitPrice = 180
            Case "Vitamin C Tablets (adult)"
                unitPrice = 200
            Case "Ibuprofen 200mg (adult)"
                unitPrice = 60
            Case Else
                unitPrice = 0
        End Select

        'Calculate
        medTotal = unitPrice * qty
        grandTotal = medTotal + consultation

        'Display in message box like paper requires
        MessageBox.Show("PHARMACY BILL" & vbCrLf & vbCrLf &
                        "Patient: " & patientName & vbCrLf &
                        "Medicine: " & medicine & vbCrLf &
                        "Quantity: " & qty & vbCrLf &
                        "Unit Price: KSh " & unitPrice & vbCrLf &
                        "Medicine Total: KSh " & medTotal & vbCrLf &
                        "Consultation Fee: KSh " & consultation & vbCrLf &
                        "-------------------------" & vbCrLf &
                        "GRAND TOTAL: KSh " & grandTotal,
                        "Patient Bill")

        Txttotalbill.Text = grandTotal  'Also show in textbox
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        ComboBoxmedicineprescried.Items.Add("Ketoconazole Cream")
        ComboBoxmedicineprescried.Items.Add("Salicylic Acid Lotion")
        ComboBoxmedicineprescried.Items.Add("Atorvastatin 20mg")
        ComboBoxmedicineprescried.Items.Add("Metoprolol 50mg")
        ComboBoxmedicineprescried.Items.Add("Paracetamol Syrup 120ml")
        ComboBoxmedicineprescried.Items.Add("Amoxicillin Suspension 125mg")
        ComboBoxmedicineprescried.Items.Add("Vitamin C Tablets (adult)")
        ComboBoxmedicineprescried.Items.Add("Ibuprofen 200mg (adult)")
    End Sub

    Private Sub cboMedicine_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxmedicineprescried.SelectedIndexChanged
        Select Case ComboBoxmedicineprescried.Text
            Case "Ketoconazole Cream" : Txtunitprice.Text = 250
            Case "Salicylic Acid Lotion" : Txtunitprice.Text = 350
            Case "Atorvastatin 20mg" : Txtunitprice.Text = 250
            Case "Metoprolol 50mg" : Txtunitprice.Text = 180
            Case "Paracetamol Syrup 120ml" : Txtunitprice.Text = 120
            Case "Amoxicillin Suspension 125mg" : Txtunitprice.Text = 180
            Case "Vitamin C Tablets (adult)" : Txtunitprice.Text = 200
            Case "Ibuprofen 200mg (adult)" : Txtunitprice.Text = 60
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "patientname"
        DataGridView1.Columns(1).Name = "medicineprescribed"
        DataGridView1.Columns(2).Name = "quantity"
        DataGridView1.Columns(3).Name = "unitprice"
        DataGridView1.Columns(4).Name = "totalbill"

    End Sub

    Private Sub BtnADD_Click(sender As System.Object, e As System.EventArgs) Handles BtnADD.Click
        DataGridView1.Rows.Add(Txtpatientname.Text,
            ComboBoxmedicineprescried.Text,
            Txtquantity.Text,
            Txtunitprice.Text,
            Txttotalbill.Text)


        MessageBox.Show("Record Added Successfully")
    End Sub

    Private Sub BtnPRINT_Click(sender As System.Object, e As System.EventArgs) Handles BtnPRINT.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim brush As Brush = Brushes.Black
        Dim startX As Integer = 40
        Dim startY As Integer = 80
        Dim offsetY As Integer = 25
        e.Graphics.DrawString("pharmacy system", New Font("Arial", 14, FontStyle.Bold), brush, startX, 30)
        e.Graphics.DrawString("Date: " & Date.Now.ToShortDateString(), font, brush, startX, 55)


        For col As Integer = 0 To DataGridView1.Columns.Count - 1
            e.Graphics.DrawString(DataGridView1.Columns(col).HeaderText, font, brush, startX + (col * 120), startY)
        Next

        startY += offsetY
        For row As Integer = 0 To DataGridView1.Rows.Count - 2
            For col As Integer = 0 To DataGridView1.Columns.Count - 1
                e.Graphics.DrawString(
                    DataGridView1.Rows(row).Cells(col).Value.ToString(),
                    font,
                    brush,
                    startX + (col * 120),
                    startY
                )
            Next
            startY += offsetY
        Next



    End Sub

    Private Sub Txtunitprice_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtunitprice.TextChanged

    End Sub
End Class

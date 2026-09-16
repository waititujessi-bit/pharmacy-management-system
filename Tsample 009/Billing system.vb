Imports System.Net
Imports System.IO
Imports System.Drawing.Printing

Public Class Billing_system
    Const standingcharge As Decimal = 200
    Dim totalbill As Decimal
    Dim units As Decimal
    Dim costperunits As Decimal

    Private Sub Billing_system_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 8
        DataGridView1.Columns(0).Name = "number"
        DataGridView1.Columns(1).Name = "name"
        DataGridView1.Columns(2).Name = "place"
        DataGridView1.Columns(3).Name = "phone"
        DataGridView1.Columns(4).Name = "previous"
        DataGridView1.Columns(5).Name = "current"
        DataGridView1.Columns(6).Name = "units"
        DataGridView1.Columns(7).Name = "total bill"
    End Sub

    Private Sub BtnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculate.Click
        ' Declare variables
        Dim current As Decimal = CDec(Txtcurrentreading.Text)
        Dim previous As Decimal = CDec(TXTPREVIOUSREADING.Text)
        Dim units As Decimal
        Dim costperunits As Decimal
        Dim standingcharge As Decimal = 150
        Dim totalbill As Decimal

        ' Calculate units
        units = current - previous

        ' Use Select Case for billing slabs - no If needed
        Select Case units
            Case Is > 10
                costperunits = 10
            Case 6 To 10
                costperunits = 15
            Case 4 To 5
                costperunits = 20
            Case Is < 4
                costperunits = 10
            Case Else
                costperunits = 0
        End Select

        ' Calculate total bill
        totalbill = (units * costperunits) + standingcharge

        MessageBox.Show("Units: " & units & vbCrLf & "Rate: KES " & costperunits & vbCrLf & "Total Bill: KES " & totalbill)
        Try
            'code here

        Catch ex As Exception
            MessageBox.Show("Enter valid numbers in both readings")
        End Try
    End Sub


    Private Sub Btnadd_Click(sender As System.Object, e As System.EventArgs) Handles Btnadd.Click
        DataGridView1.Rows.Add(Txtcustomerumer.Text,
                  Txtcustomertname.Text,
                  Txtplaceofresidence.Text,
                  Txtphonenumber.Text,
                  TXTPREVIOUSREADING.Text,
                  Txtcurrentreading.Text,
                  units,
                  totalbill)

        MessageBox.Show("Record Added Successfully")

    End Sub

    Private Sub Btnclear_Click(sender As System.Object, e As System.EventArgs) Handles Btnclear.Click

        DataGridView1.Rows.Add(Txtcustomerumer.Text, units, costperunits, totalbill)
        MessageBox.Show("Record added")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim brush As Brush = Brushes.Black
        Dim startX As Integer = 40
        Dim startY As Integer = 80
        Dim offsetY As Integer = 25
        e.Graphics.DrawString("MAJI WATER COMPANY BILL", New Font("Arial", 14, FontStyle.Bold), brush, startX, 30)
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

    Private Sub Btnpritreport_Click(sender As System.Object, e As System.EventArgs) Handles Btnpritreport.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnschoolgrade_Click(sender As System.Object, e As System.EventArgs) Handles btnschoolgrade.Click
        schoolgrade.Show()
    End Sub

    Private Sub BTNPAYMPESA_Click(sender As System.Object, e As System.EventArgs) Handles BTNPAYMPESA.Click
        Try
            Dim phone As String = "254708374149"
            Dim amount As String = "10"
            Dim invoice As String = "TEST001"

            Dim result = MpesaSTK.SendSTKPush(phone, amount, invoice)
            MessageBox.Show("SUCCESS: " & result, "M-PESA")

        Catch ex As WebException
            ' THIS SHOWS THE REAL SAFARICOM ERROR
            Dim response As WebResponse = ex.Response
            Dim reader As New StreamReader(response.GetResponseStream())
            Dim errorText As String = reader.ReadToEnd()
            MessageBox.Show("SAFARICOM SAYS: " & errorText, "400 Error Details")

        Catch ex As Exception
            MessageBox.Show("General Error: " & ex.Message)
        End Try
    End Sub
End Class

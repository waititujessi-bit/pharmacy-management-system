Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class schoolgrade
    Sub LoadData()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TXTadmissionnumber.Text = row.Cells("admission number").Value.ToString()
            Txtname.Text = row.Cells("name").Value.ToString()
            Txtclass.Text = row.Cells("class").Value.ToString()
            Txtmaths.Text = row.Cells("maths").Value.ToString()
            Txtenglish.Text = row.Cells("english").Value.ToString()
            TXTsciece.Text = row.Cells("science").Value.ToString()
            Txttotal.Text = row.Cells("total").Value.ToString()
            Txtaverage.Text = row.Cells("average").Value.ToString()
            Txtgrade.Text = row.Cells("grade").Value.ToString()
            Txtremarks.Text = row.Cells("remarks").Value.ToString()
        End If
    End Sub

    Private Sub Btncalculate_Click(sender As System.Object, e As System.EventArgs) Handles Btncalculate.Click

        If TXTadmissionnumber.Text = "" Then
            MessageBox.Show("Enter Admission Number")
            TXTadmissionnumber.Focus()
            Exit Sub
        End If

        If Txtname.Text = "" Then
            MessageBox.Show("Enter Name")
            Txtname.Focus()
            Exit Sub
        End If

        If Txtclass.Text = "" Then
            MessageBox.Show("Enter Class")
            Txtclass.Focus()
            Exit Sub
        End If

        If Txtmaths.Text = "" Or Not IsNumeric(Txtmaths.Text) Then
            MessageBox.Show("Enter Valid Maths Marks")
            Txtmaths.Focus()
            Exit Sub
        End If

        If Txtenglish.Text = "" Or Not IsNumeric(Txtenglish.Text) Then
            MessageBox.Show("Enter Valid English Marks")
            Txtenglish.Focus()
            Exit Sub
        End If

        If TXTsciece.Text = "" Or Not IsNumeric(TXTsciece.Text) Then
            MessageBox.Show("Enter Valid Science Marks")
            TXTsciece.Focus()
            Exit Sub
        End If

        Dim maths, english, science, total As Integer
        Dim average As Double
        Dim grade, remarks As String

        maths = Val(Txtmaths.Text)
        english = Val(Txtenglish.Text)
        science = Val(TXTsciece.Text)

        total = maths + english + science
        Txttotal.Text = total

        average = total / 3
        Txtaverage.Text = average

        If average >= 80 And average <= 100 Then
            grade = "A"
        ElseIf average >= 70 Then
            grade = "B"
        ElseIf average >= 60 Then
            grade = "C"
        ElseIf average >= 40 Then
            grade = "D"
        ElseIf average >= 0 Then
            grade = "E"
        Else
            grade = "Invalid"
        End If

        Txtgrade.Text = grade


        Select Case grade
            Case "A"
                remarks = "Excellent"
            Case "B"
                remarks = "Good"
            Case "C"
                remarks = "Fair"
            Case "D"
                remarks = "Below Average"
            Case "E"
                remarks = "Fail"
            Case Else
                remarks = "Invalid Marks"
        End Select

        Txtremarks.Text = remarks
        DataGridView1.Rows.Add(
            TXTadmissionnumber.Text,
            Txtname.Text,
            Txtclass.Text,
            Txtmaths.Text,
            Txtenglish.Text,
            TXTsciece.Text,
            Txttotal.Text,
            Txtaverage.Text,
            Txtgrade.Text,
            Txtremarks.Text
        )
        'Display in message box like paper requires
        MessageBox.Show("STUDENT REPORT" & vbCrLf & vbCrLf &
                       "Admission No: " & TXTadmissionnumber.Text & vbCrLf &
                       "Name: " & Txtname.Text & vbCrLf &
                       "Class: " & Txtclass.Text & vbCrLf &
                       "Maths: " & maths & vbCrLf &
                       "English: " & english & vbCrLf &
                       "Science: " & science & vbCrLf &
                       "TOTAL: " & total & vbCrLf &
                       "AVERAGE: " & average,
                       "Student Report")

    End Sub

    Private Sub Btnprint_Click(sender As System.Object, e As System.EventArgs) Handles Btnprint.Click
        MessageBox.Show("STUDENT REPORT" & vbNewLine &
                            "Admission No: " & TXTadmissionnumber.Text & vbNewLine &
                            "Name: " & Txtname.Text & vbNewLine &
                            "Class: " & Txtclass.Text & vbNewLine &
                            "Maths: " & Txtmaths.Text & vbNewLine &
                            "English: " & Txtenglish.Text & vbNewLine &
                            "Science: " & TXTsciece.Text & vbNewLine &
                            "Total: " & Txttotal.Text & vbNewLine &
                            "Average: " & Txtaverage.Text & vbNewLine &
                            "Grade: " & Txtgrade.Text & vbNewLine &
                            "Remarks: " & Txtremarks.Text)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub BtnEXIT_Click(sender As System.Object, e As System.EventArgs) Handles BtnEXIT.Click
        Me.Close()
    End Sub

    Private Sub schoolgrade_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 10
        DataGridView1.Columns(0).Name = "Admission"
        DataGridView1.Columns(1).Name = "Name"
        DataGridView1.Columns(2).Name = "Class"
        DataGridView1.Columns(3).Name = "Maths"
        DataGridView1.Columns(4).Name = "English"
        DataGridView1.Columns(5).Name = "sciece"
        DataGridView1.Columns(6).Name = "Total"
        DataGridView1.Columns(7).Name = "Average"
        DataGridView1.Columns(8).Name = "Grade"
        DataGridView1.Columns(9).Name = "Remarks"

        Txttotal.ReadOnly = True
        Txtaverage.ReadOnly = True
        Txtgrade.ReadOnly = True
        Txtremarks.ReadOnly = True

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim brush As Brush = Brushes.Black
        Dim startX As Integer = 40
        Dim startY As Integer = 80
        Dim offsetY As Integer = 25
        e.Graphics.DrawString("SCHOOL EXAMINATION MODULE", New Font("Arial", 14, FontStyle.Bold), brush, startX, 30)
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

    Private Sub btnpharmacybills_Click(sender As System.Object, e As System.EventArgs)
        PHARMACYBILLS.ShowDialog()
    End Sub
End Class






Imports System.Data
Imports System.Data.SqlClient

Public Class dashboard
    Dim connection As New SqlConnection("Data Source=DESKTOP-V5AOVG3\SQLEXPRESS;Initial Catalog=trysampleDB;Integrated Security=True")
    Sub loadtablets()
        Dim sda As New SqlDataAdapter("SELECT* FROM  tablets9 ", connection)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Btnadd_Click(sender As System.Object, e As System.EventArgs) Handles Btnadd.Click
        connection.Open()
        Dim cmd As New SqlCommand("INSERT INTO tablets9 VALUES('" & Txtdrugtype.Text & "','" & Txtdrugcode.Text & "','" & ComboBoxdrugname.Text & "','" & ComboBoxnursename.Text & "','" & Txtdateofexp.Text & "')", connection)
        cmd.ExecuteNonQuery()
        connection.Close()
        loadtablets()
        MessageBox.Show("Drug Added")

    End Sub

    Private Sub Btndelete_Click(sender As System.Object, e As System.EventArgs) Handles Btndelete.Click
        connection.Open()
        Dim cmd As New SqlCommand("DELETE FROM  tablets9 WHERE DrugID=" & DataGridView1.CurrentRow.Cells(0).Value, connection)
        cmd.ExecuteNonQuery()
        connection.Close()
        loadtablets()
        MessageBox.Show("Drug Deleted")
    End Sub

    Private Sub ComboBoxnursename_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxnursename.SelectedIndexChanged
    End Sub

    Private Sub ComboBoxdrugname_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxdrugname.SelectedIndexChanged

    End Sub

    Private Sub Btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles Btnsearch.Click
        ' Remove the extra ) and add space after select
        Dim cmd As New SqlCommand("SELECT * FROM tablets9 WHERE drugID = @id", connection)
        cmd.Parameters.AddWithValue("@id", TxtdrugID.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        DataGridView1.DataSource = dt
        connection.Close()
    End Sub


    Private Sub Btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles Btnupdate.Click

        If TxtdrugID.Text = "" Then
            MessageBox.Show("Enter DrugID first")
            Exit Sub
        End If

        connection.Open()

        Dim cmd As New SqlCommand("UPDATE tablets9 SET drugtype=@type, drugcode=@code, drugname=@name, Nursename=@nurse, dateofexp=@exp WHERE DrugId=@id", connection)

        cmd.Parameters.AddWithValue("@type", Txtdrugtype.Text)
        cmd.Parameters.AddWithValue("@code", Txtdrugcode.Text)
        cmd.Parameters.AddWithValue("@name", ComboBoxdrugname.Text)
        cmd.Parameters.AddWithValue("@nurse", ComboBoxnursename.Text)
        cmd.Parameters.AddWithValue("@exp", Txtdateofexp.Text)
        cmd.Parameters.AddWithValue("@id", TxtdrugID.Text)

        cmd.ExecuteNonQuery()
        connection.Close()

        loadtablets()
        MessageBox.Show("Drug Updated")
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Btnwaterbilling_Click(sender As System.Object, e As System.EventArgs) Handles Btnwaterbilling.Click
        Billing_system.Show()
    End Sub

    Private Sub Btnprint_Click(sender As System.Object, e As System.EventArgs) Handles Btnprint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim brush As Brush = Brushes.Black
        Dim startX As Integer = 40
        Dim startY As Integer = 80
        Dim offsetY As Integer = 25
        e.Graphics.DrawString("PHARMACY MANAGMENT SYSTEM ", New Font("Arial", 14, FontStyle.Bold), brush, startX, 30)
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PHARMACYBILLS.ShowDialog()
    End Sub
End Class




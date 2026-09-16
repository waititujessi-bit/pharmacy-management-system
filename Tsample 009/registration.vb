Imports System.Data
Imports System.Data.SqlClient
Public Class registration

    Private Sub btnregistratio_Click(sender As System.Object, e As System.EventArgs) Handles btnregistratio.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-V5AOVG3\SQLEXPRESS;Initial Catalog=trysampleDB;Integrated Security=True")
        connection.Open()
        Dim command As New SqlCommand("INSERT INTO Register VALUES ('" & Txtusername.Text & "','" & Txtpassword.Text & "','" & Txtcofirmpassword.Text & "')", connection)
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("registration successful")
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class


Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles Btnlogin.Click
        Dim connection As New SqlConnection("Data Source=DESKTOP-V5AOVG3\SQLEXPRESS;Initial Catalog=trysampleDB;Integrated Security=True")
        Dim command As New SqlCommand("Select 'Username','Password' From register where Username='" + txtusername.Text + "'and Password='" + Txtpassword.Text + "'", connection)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(command)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim f As New SUCCESS
            f.ShowDialog()
        Else
            ' Keep MessageBox for error, or make frmError with red background later
            MessageBox.Show("Password will expire soon", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'Yellow !
            txtusername.Clear()
            Txtpassword.Clear()
            txtusername.Focus()
        End If

    End Sub


    Private Sub Btnregister_Click(sender As System.Object, e As System.EventArgs) Handles Btnregister.Click
        registration.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class





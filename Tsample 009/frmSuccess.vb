Public Class SUCCESS
    Private Sub frmSuccess_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.LightGreen  'Form background
        btnOK.BackColor = Color.White
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        dashboard.ShowDialog()
    End Sub
End Class
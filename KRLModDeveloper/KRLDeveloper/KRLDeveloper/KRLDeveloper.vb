Public Class KRLDeveloper
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Items
        frm.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Me.DesignMode Then Exit Sub
        ModDir = TextBox1.Text
    End Sub

End Class

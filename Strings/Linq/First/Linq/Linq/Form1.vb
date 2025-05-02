Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim values() As Integer = {2, 9, 5, 0, 3, 7, 1, 4, 8, 6}
        TextBox1.Text &= "Original array " & vbCrLf

        For Each element In values
            TextBox1.Text &= "  " & element
        Next

        Dim filtered = From value In values
                       Where (value > 4)
                       Select value
        TextBox1.Text &= vbCrLf & "New array " & vbCrLf

        For Each element In filtered
            TextBox1.Text &= "  " & element
        Next



    End Sub
End Class

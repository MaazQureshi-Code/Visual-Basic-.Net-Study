Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim C As String
        Dim num As Integer = NumericUpDown1.Value

        For i As Integer = 1 To num

            For j As Integer = 1 To num
                ListBox1.Items.Add(C & " ")
            Next

        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class

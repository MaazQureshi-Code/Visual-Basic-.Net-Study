Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim letters As String = "abcdefghijklmabdefghijklm"

        Dim seachLetters As Char() = {"c"c, "a"c, "$"c}
        TextBox1.Text &= "First 'def' is located at index  " & letters.IndexOf("def", 7)
        TextBox1.Text &= vbCrLf

        TextBox1.Text &= "First 'A' is located at index  " & letters.IndexOf("a", 0)

        TextBox1.Text &= vbCrLf

        TextBox1.Text &= "First '$' is located at index  " & letters.IndexOf("$", 3, 5)
        TextBox1.Text &= vbCrLf
        TextBox1.Text &= "Last '' is located at index   " & letters.LastIndexOf("a", 7, 5)

    End Sub
End Class

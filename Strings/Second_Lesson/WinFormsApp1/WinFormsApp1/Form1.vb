Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim string1 As String = "b"
        Dim string2 As String = "c"
        Dim string3 As String = "Happy Birthday"
        Dim string4 As String = "hello birthday"
        Dim string5 As String = "a"

        TextBox1.Text &= vbCrLf
        TextBox1.Text &= vbCrLf
        TextBox1.Text &= vbCrLf
        TextBox1.Text &= "String1  compare string   " & string2.CompareTo(string1)





    End Sub
End Class

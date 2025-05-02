Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim string1 As String = "hello there"

        Dim characterArray() As Char = New Char(5) {}




        TextBox1.Text = "String11: " & Chr(34) & string1 & Chr(34) & "  Also the length is " & string1.Length
        TextBox1.Text &= vbCrLf

        For i = string1.Length - 1 To 0 Step -1
            TextBox1.Text &= string1(i)
        Next
        TextBox1.Text &= vbCrLf


        string1.CopyTo(0, characterArray, 0, 5)

        For i = 0 To characterArray.Length - 1
            TextBox1.Text &= characterArray(i)
        Next



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim number1 As Integer
        Dim number2 As Integer
        number1 = TextBox1.Text
        number2 = TextBox2.Text

        If number1 = number2 Then
            TextBox3.AppendText(number1 & " = " & number2)
        End If

        If number1 <> number2 Then
            TextBox3.AppendText(number1 & " != " & number2)
        End If

        If number1 > number2 Then
            TextBox3.AppendText(vbCrLf & number1 & " > " & number2)
        End If

        If number1 < number2 Then
            TextBox3.AppendText(vbCrLf & number1 & " < " & number2)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox3.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox3.Clear()
    End Sub
End Class

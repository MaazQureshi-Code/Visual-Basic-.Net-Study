Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim firstNum As Integer
        Dim secondNum As Integer
        firstNum = TextBox1.Text
        secondNum = TextBox2.Text
        Dim result As Integer
        result = firstNum + secondNum
        TextBox3.Text = "The sum is" & result





    End Sub
End Class

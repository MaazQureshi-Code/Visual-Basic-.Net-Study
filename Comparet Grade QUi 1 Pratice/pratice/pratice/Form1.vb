Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result As Integer
        Dim num1 As Integer = TextBox1.Text
        Dim num2 As Integer = TextBox2.Text

        result = num1 + num2

        TextBox3.Text = "The sum is " & result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer = (TextBox1.Text)
        Dim num2 As Integer = (TextBox2.Text)


        If num1 <> num2 Then
            TextBox3.AppendText(num1 & "<>" & num2 & vbCrLf)
        End If
        If num1 = num2 Then
            TextBox3.AppendText(num1 & "=" & num2 & vbCrLf)
        End If
        If num1 > num2 Then
            TextBox3.AppendText(num1 & ">" & num2 & vbCrLf)
        End If
        If num1 < num2 Then
            TextBox3.AppendText(num1 & "<" & num2 & vbCrLf)
        End If
        If num1 <= num2 Then
            TextBox3.AppendText(num1 & "<=" & num2 & vbCrLf)
        End If
        If num1 >= num2 Then
            TextBox3.AppendText(num1 & ">=" & num2 & vbCrLf)
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim gradde As Integer = TextBox7.Text
        ListBox1.Items.Add(gradde)
        TextBox7.Clear()
        TextBox7.Focus()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num3 As Integer = TextBox5.Text

        If num3 >= 90 Then
            TextBox4.Text = "A"
        ElseIf num3 >= 80 Then
            TextBox4.Text = "B"
        ElseIf num3 >= 70 Then
            TextBox4.Text = "C"
        ElseIf num3 >= 60 Then
            TextBox4.Text = "D"
        Else
            TextBox4.Text = "F"
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Avg As Double
        Dim counter As Integer
        Dim grade As Integer
        Dim total As Integer

        While counter < ListBox1.Items.Count
            grade = ListBox1.Items(counter)
            total += grade
            counter += 1
        End While
        If counter <> 0 Then
            Avg = total / counter
            TextBox6.AppendText("Number of stduent is " & counter & vbCrLf)
            TextBox6.AppendText("Total is " & total & vbCrLf)
            TextBox6.AppendText("Average is " & String.Format("{0:F}", Avg) & vbCrLf)
        End If
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox6.Clear()

    End Sub
End Class

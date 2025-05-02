Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text <> String.Empty Then
            ListBox1.Items.Add(TextBox2.Text)
            TextBox2.Clear()
        End If
        TextBox2.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim counter As Integer = 0
        Dim grade As Integer = 0
        Dim total As Integer


        While counter < ListBox1.Items.Count

            ListBox1.SelectedItem(counter)
            total += grade
            counter += 1
        End While
        Dim avg As Double
        avg = total / counter

        Label4.Text = "Total of the " & counter & " grade(s) is  " & total & vbCrLf & " Class average  is " &
            String.Format("{0:F}", avg)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Label4.Text = String.Empty

    End Sub
End Class

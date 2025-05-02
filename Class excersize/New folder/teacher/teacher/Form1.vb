Public Class Form1
    Dim frequency(100) As Integer
    Dim array() As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer
        Dim random As New Random
        ReDim Preserve array(TextBox1.Text)
        ReDim Preserve frequency(TextBox1.Text)
        For i = 0 To array.GetUpperBound(0)
            array(i) = random.Next(1, TextBox1.Text)
            ListBox1.Items.Add(array(i))
        Next

        Dim all_data = From fre In array
                       Select fre
        For Each x In all_data
            frequency(array(x)) += 1
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To Array.GetUpperBound(0)
            ListBox2.Items.Add(frequency(i))
        Next

    End Sub
End Class

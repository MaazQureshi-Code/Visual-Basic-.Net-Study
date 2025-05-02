Public Class Form1
    Dim F As Integer
    Dim c As Integer
    Dim b As Integer
    Dim A As Integer
    Sub grade(ByVal number As Integer)
        Select Case number
            Case 0 To 49
                F = F + 1
            Case 50 To 70
                c = c + 1
            Case 71 To 85
                b = b + 1
            Case 86 To 100
                A = A + 1
            Case Else
                ListBox1.Items.Add("Wrong number")
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer

        If Integer.TryParse(TextBox1.Text, number) Then
            If CheckBox1.Checked AndAlso (CheckBox3.Checked OrElse CheckBox4.Checked OrElse CheckBox5.Checked) Then
                grade(number)
            ElseIf CheckBox2.Checked Then
                grade(number)
            Else
                ListBox1.Items.Add("Please select a valid group.")
            End If
        Else
            ListBox1.Items.Add("Invalid number, please enter an integer between 0 and 100.")
        End If

            TextBox1.Clear()
        TextBox1.Focus()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Check which group is selected and display results
        If CheckBox1.Checked AndAlso CheckBox3.Checked Then
            ListBox1.Items.Add("CMSE 321 Group1 Results")
        ElseIf CheckBox1.Checked AndAlso CheckBox4.Checked Then
            ListBox1.Items.Add("CMSE 321 Group2 Results")
        ElseIf CheckBox1.Checked AndAlso CheckBox5.Checked Then
            ListBox1.Items.Add("CMSE 321 Group3 Results")
        ElseIf CheckBox2.Checked Then
            ListBox1.Items.Add("CMSE 415 Group Results")
        Else
            ListBox1.Items.Add("Please select a group to display results.")
            Exit Sub
        End If

        ' Add results to ListBox with line breaks
        ListBox1.Items.Add("F: " & F)
        ListBox1.Items.Add("C: " & c)
        ListBox1.Items.Add("B: " & b)
        ListBox1.Items.Add("A: " & A)

        ' Reset counts after displaying results
        A = 0
        F = 0
        b = 0
        c = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Enabled = False
        Else
            CheckBox2.Enabled = True
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Enabled = False
        Else
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
        Else
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            CheckBox3.Enabled = False
            CheckBox5.Enabled = False
        Else
            CheckBox3.Enabled = True
            CheckBox5.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
        Else
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub
End Class

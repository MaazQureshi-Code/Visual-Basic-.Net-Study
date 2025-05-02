Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ListBox1.Items.Count < 10 Then

            ListBox1.Items.Add(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Focus()
        End If

        If ListBox1.Items.Count = 10 Then
            Button1.Enabled = False
            TextBox1.Enabled = False ' this disable the button when it each to 10
            Button2.Enabled = True 'This enable the button
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim passes As Integer = 0
        Dim failures As Integer = 0
        Dim student As Integer = 0
        Dim result As String

        While student < 10
            result = ListBox1.Items(student)
            If result = "F" Then
                failures += 1
            Else
                passes += 1
            End If

            student += 1
        End While

        TextBox2.Text = "Passed: " & passes & vbCrLf & "Failed: " & failures & vbCrLf

        If passes > 8 Then
            TextBox2.Text &= "Bonus to  instructor"
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()

        TextBox2.Clear()

        Button1.Enabled = True
        TextBox1.Enabled = True 'isable the button when it each to 10
        Button2.Enabled = False

    End Sub
End Class

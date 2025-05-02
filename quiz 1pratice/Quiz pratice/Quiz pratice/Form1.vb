Public Class Form1
    Dim standed As Integer = 150
    Dim DoubleW As Integer = 250
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim name As String = TextBox1.Text
        Dim total As Integer
        Dim typeW As String = ""
        If ListBox1.SelectedItem IsNot Nothing Then
            If ListBox1.SelectedItem = "standard" Then
                typeW = "standard"
                total += 150
            Else
                total += 250
                typeW = "Double"
            End If
        Else
            MsgBox("Please selected at least one")
        End If
        Dim type_fruits As String = ""

        If CheckBox1.Checked Then
            total += 15

            type_fruits += "kiwi"

        End If
        If CheckBox2.Checked Then
            total += 15

            type_fruits += "Stawberry"

        End If
        If CheckBox3.Checked Then
            total += 15

            type_fruits += "Banana"

        End If
        If CheckBox4.Checked Then
            total += 15

            type_fruits += "Apple"

        End If

        TextBox2.AppendText(name & " " & typeW & "(" & type_fruits & ")")
        ListBox2.Items.Add(total)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        total()
    End Sub

    Sub total()
        Dim counter As Integer
        counter = 0

        Dim total As Integer = 0
        While counter < ListBox2.Items.Count
            total = ListBox2.Items(counter)
            counter = counter + 1
        End While
        Label9.Text = total

    End Sub
End Class

Public Class Form1
    Dim var1, var2 As Double
    Dim opern As String
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Clear()

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub
    Private Sub buttonclick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, Button9.MouseClick, Button8.MouseClick, Button7.MouseClick, Button6.MouseClick, Button5.MouseClick, Button4.MouseClick, Button3.MouseClick, Button2.MouseClick, Button10.MouseClick, Button1.MouseClick
        Dim button As Button = CType(sender, Button)
        TextBox1.Text += button.Text
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            var2 = Val(TextBox1.Text)
            Select Case opern
                Case "+"
                    TextBox1.Text = (var1 + var2).ToString()
                Case "-"
                    TextBox1.Text = (var1 - var2).ToString()
                Case "*"
                    TextBox1.Text = (var1 * var2).ToString()
                Case "/"
                    If var2 = 0 Then
                        MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox1.Clear()
                    Else
                        TextBox1.Text = (var1 / var2).ToString()
                    End If
                Case "%"
                    TextBox1.Text = ((var1 * var2) / 100).ToString()
                Case Else
                    MessageBox.Show("Invalid operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        Catch ex As Exception
            MessageBox.Show("An error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub operatorClick(sender As Object, e As EventArgs) Handles MyBase.Click, Button18.Click, Button16.Click, Button14.Click, Button13.Click, Button12.Click
        Dim button As Button = CType(sender, Button)
        var1 = Val(TextBox1.Text)
        opern = button.Text
        TextBox1.Clear()
    End Sub




End Class


Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emptyBoxes = From control In Controls
                         Where TypeOf control Is TextBox
                         Let box As TextBox = CType(control, TextBox)
                         Where String.IsNullOrEmpty(box.Text)
                         Order By box.TabIndex
                         Select box


        If emptyBoxes.Count() > 0 Then
            MessageBox.Show("Please fill in all fields", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emptyBoxes.First.Focus()
        Else
            Select Case False
                Case validateinput(TextBox1.Text, "^[A-Z][a-zA-z]*", "invalid last name")
                    TextBox1.Focus()
                Case validateinput(TextBox2.Text, "^[A-Z][a-zA-z]*", "invalid last name")
                    TextBox2.Focus()
                Case 
            End Select
        End If


    End Sub

    Public Function validateinput(ByVal input As String, ByVal expression As String, ByVal message As String) As Boolean

        Dim valid As Boolean = Regex.Match(input, expression).Success


        If Not valid Then
            MessageBox.Show(message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return valid
    End Function
End Class


Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim testString As String = "abc, DEF, 123"

        Dim expression As New Regex("\d")

        TextBox1.Text &= vbCrLf
        For Each regexMatch As Match In Regex.Matches(testString, ".*")
            TextBox1.AppendText(regexMatch.Value & vbCrLf)
        Next


    End Sub




End Class

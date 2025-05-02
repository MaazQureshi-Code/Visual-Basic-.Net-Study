Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim values() As Integer = {2, 9, 5, 0, 3, 7, 1, 4, 8, 6}

        TextBox1.AppendText(String.Format("Orignal Array :{0}", vbCrLf))

        For Each eleemnt In values
            TextBox1.AppendText(" " & eleemnt)
        Next
        ' LINQ 
        Dim filterd = From value In values
                      Where (value > 4)
                      Select value


        TextBox1.AppendText(String.Format("{0}{0} Array values greater 4  than ", vbCrLf))

        For Each element In filterd
            TextBox1.AppendText("  " & element)
        Next
        TextBox1.AppendText(String.Format("{0}{0} Array values Sorted ", vbCrLf))
        Dim sorted = From value In values
                     Order By value
                     Select value

        For Each element In sorted
            TextBox1.AppendText("  " & element)
        Next


        Dim sortFilteredResults = From value In filterd
                                  Order By value Descending
                                  Select value


        TextBox1.AppendText(String.Format("{0}{0} Array values Sorted  by descending ", vbCrLf))
        For Each element In sortFilteredResults
            TextBox1.AppendText("  " & element)
        Next

        Dim sortAndFilter = From value In values
                            Where (value > 4)
                            Order By value Descending
                            Select value


        TextBox1.AppendText(String.Format("{0}{0} Array values Sorted descending and Filter ", vbCrLf))
        For Each element In sortAndFilter
            TextBox1.AppendText("  " & element)
        Next






    End Sub
End Class

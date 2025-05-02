Public Class Form1

    Dim grades(9, 2) As Integer

    Dim studentcount As Integer = 0
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grades(studentcount, 0) = TextBox1.Text
        grades(studentcount, 1) = TextBox2.Text
        grades(studentcount, 2) = TextBox3.Text

        Dim output As String = "Student" & studentcount & vbTab

        For column = 0 To grades.GetUpperBound(1)
            If RadioButton2.Checked = True Then


                output &= vbTab & LetterGrade(grades(studentcount, column))
            Else
                output &= vbTab & grades(studentcount, column)
            End If
        Next

        output &= vbTab & Calculateaverage(studentcount)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(vbTab & vbTab & "Test 1" & vbTab & "Test 2" & vbTab & "Test 3" & vbTab & "Average")
    End Sub

    Function Calculateaverage(row As Integer) As String
        Dim gradetotal As Integer = 0
        For column = 0 To grades.GetUpperBound(1)
            gradetotal += grades(row, column)
        Next

        Dim studentAverage As String = String.Empty
        If RadioButton2.Checked = True Then
            studentAverage = LetterGrade(gradetotal / (grades.GetUpperBound(1) + 1))
        Else
            studentAverage = String.Format("{0:F}", (gradetotal / (grades.GetUpperBound(1) + 1)))
        End If
        Return studentAverage
    End Function

    Function classAverage() As String
        Dim classTotal As Integer = 0
        For row = 0 To grades.GetUpperBound(0) - 1
            For column = 0 To grades.GetUpperBound(1)

                classTotal += grades(row, column)

            Next
        Next
        Dim classaveragse As String = String.Empty

        If RadioButton2.Checked Then
            classaveragse = LetterGrade(classTotal / (studentcount * (grades.GetUpperBound(1) + 1)))

        Else
            classAverage = String.Format("{0:F}", (classTotal / (studentcount * (grades.GetUpperBound(1) + 1))))
        End If
        Return classAverage
    End Function
    Function LetterGrade(grade As Double) As String
        Dim output As String
        Select Case grade
            Case Is >= 90
                output = "A"
            Case Is >= 80
                output = "B"
            Case Is >= 70
                output = "C"
            Case Is >= 60
                output = "D"
            Case Else
                output = "f"
        End Select
        Return output



    End Function

    Sub display()
        ListBox1.Items.Clear()
        ListBox1.Items.Add(vbTab & vbTab & "Test 1" & vbTab & "Test 2" & vbTab & "Test 3" & vbTab & "Average")

        For row = 0 To studentcount - 1
            Dim output As String = "Student " & row & vbTab
            For column = 0 To grades.GetUpperBound(1)
                If RadioButton2.Checked = True Then
                    output &= vbTab & LetterGrade(grades(row, column))
                Else
                    output &= vbTab & (grades(row, column))
                End If
            Next
            output &= vbTab & Calculateaverage(row)
            ListBox1.Items.Add(output)
            Label5.Text = classAverage()
        Next






    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

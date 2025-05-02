Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim employe() As Class1 = {
            New Class1("maaz", "red", 500),
        New Class1("khan", "Ahmed", 600)}


        TextBox1.AppendText(String.Format("Orignail array:{0}", vbCrLf))
        For Each element In employe
            TextBox1.AppendText(String.Format("  {0}{1}", element, vbCrLf))
        Next

        Dim between = From employes In employe
                      Where (employes.montlySalaryValue >= 4000 AndAlso employes.montlySalaryValue <= 60000)
                      Select employes


        TextBox1.AppendText(String.Format("  The salary between 4000 and 60000  {0}", vbCrLf))

        For Each element In between
            String.Format(" {0}{1}", element, vbCrLf)
        Next
        TextBox1.AppendText(String.Format("{0} First employee when sorted by name:{0}", vbCrLf))
        Dim nameSorted =
            From employee In employe
            Order By employee.Lastname, employe.First
            Select employee

        If Name.Count() > 0 Then
            TextBox1.AppendText(nameSorted.First().ToString() & vbCrLf)
        Else
            TextBox1.AppendText("not found " & vbCrLf)
        End If

        Dim lastnames =
            From employee In employe
            Select employee.Lastname
            Distinct


        TextBox1.AppendText(vbCrLf)

        Dim names =
            From emoployee In employe
            Select emoployee.Firstname, emoployee.Lastname
        For Each element In names
            TextBox1.AppendText(String.Format("   {0}{1}", element, vbCrLf))

        Next
        TextBox1.AppendText(vbCrLf)

        Dim salary = From elem In employe
                     Where elem.montlySalaryValue > 4000
                     Select elem.montlySalaryValue

        ' Ensure salary is not empty before calling Average
        If salary.Any() Then
            ' Calculate the average salary of the filtered employees
            Dim avg As Decimal = salary.Average()

            ' Display the average in TextBox1 (assuming TextBox1 is a valid textbox)
            TextBox1.Text = "Average Salary: " & avg.ToString("C")
        Else
            TextBox1.Text = "No employees with salary greater than $4000"
        End If


    End Sub
End Class
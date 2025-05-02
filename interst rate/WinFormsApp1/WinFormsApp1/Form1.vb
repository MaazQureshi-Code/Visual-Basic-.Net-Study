Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim principal As Double
        Dim interest As Double
        Dim year As Double
        principal = pre_textbox1.Text
        interest = interest1.Text


        Dim amount As Decimal

        For yearCounter As Integer = 1 To NumericUpDown1.Value
            amount = principal * ((1 + interest / 100) ^ yearCounter)
            ListBox1.Items.Add(yearCounter & vbTab & String.Format("{0:F}", amount))


        Next




    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox1.Items.Add("Year" & vbTab & "Amount of Deposit")

    End Sub
End Class

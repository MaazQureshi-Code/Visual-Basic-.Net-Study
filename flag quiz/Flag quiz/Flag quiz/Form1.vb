Public Class Form1

    Dim country() As String = {"Turkey3", "Azerbaijian1", "Trnc2"}

    Dim random As New Random

    Dim used(country.GetUpperBound(0)) As Boolean

    Dim count As Integer = 0
    Dim countries As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = countries Then
            MsgBox("Correct!")
        Else

            MsgBox("The correct answer is " & countries)

        End If


        If count >= country.Length Then
            ComboBox1.Enabled = False
            Button1.Enabled = False
        Else

            ComboBox1.SelectedIndex = 0
            count += 1

        End If

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = country
        DisplayFlag()
    End Sub

    Function getuniqueRandomNumber() As Integer
        Dim randomnumber As Integer
        Do
            randomnumber = random.Next(0, used.Length)
        Loop Until used(randomnumber) = False
        Return randomnumber
    End Function

    Sub DisplayFlag()
        Dim randomNumber As Integer = getuniqueRandomNumber()
        countries = country(randomNumber)

        Dim pictureResource = My.Resources.ResourceManager.GetObject(countries)
        PictureBox1.Image = pictureResource
    End Sub
End Class

Public Class Form1
    Dim player1 As Integer
    Dim player2 As Integer
    Dim amount As Integer
    Dim num_player1 As Integer
    Dim num_player2 As Integer
    Dim playerRolled As Boolean = False
    Dim player2Rooled As Boolean = False
    Dim debt As Integer
    Dim debtList As New List(Of String)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ro As New Random()
        num_player1 = ro.Next(1, 6 + 1)
        Dim pr = My.Resources.ResourceManager.GetObject(String.Format("dice{0}", num_player1))
        PictureBox1.Image = pr
        player1 = Val(TextBox1.Text)
        playerRolled = True
        MsgBox("Player 1 rolled a " & num_player1.ToString())

        If playerRolled And player2Rooled Then
            DetermineWinner()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ro As New Random()
        num_player2 = ro.Next(1, 6 + 1)
        Dim pr = My.Resources.ResourceManager.GetObject(String.Format("dice{0}", num_player2))
        PictureBox2.Image = pr
        player2 = Val(TextBox1.Text)

        player2Rooled = True ' Mark that Player 2 has rolled
        MsgBox("Player 2 rolled a " & num_player2.ToString())

        If playerRolled And player2Rooled Then
            DetermineWinner()
        End If



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Not Integer.TryParse(TextBox3.Text, amount) Then
            MsgBox("Please enter a valid bet amount.")
            Exit Sub
        End If

        ' Validate that both players have enough money to bet
        player1 = Val(TextBox1.Text)
        player2 = Val(TextBox2.Text)

        If amount > player1 Then
            MsgBox("Player 1 does not have enough money.")
        ElseIf amount > player2 Then
            MsgBox("Player 2 does not have enough money.")
        End If
    End Sub

    Sub DetermineWinner()
        If num_player1 > num_player2 Then
            player1 += amount
            player2Rooled -= amount
            MsgBox("PLayer 1 wins the bet!")
        ElseIf num_player2 > num_player1 Then
            player2Rooled += amount
            player1 -= amount
            MsgBox("Player 2 wins the bet!")
        Else
            MsgBox("IT is a tie!")
        End If
        ' Update player balances
        TextBox1.Text = player1.ToString()
        TextBox2.Text = player2.ToString()

        playerRolled = False
        playerRolled = False
        CheckForDebt()

    End Sub
    Sub CheckForDebt()
        If player1 <= 0 Then
            Dim requestDebt = MsgBox("Player 1 has run out of money. Do they want to request a loan?", MsgBoxStyle.YesNo)
            If requestDebt = MsgBoxResult.Yes Then
                Dim debtAmount = InputBox("How much does Player 1 want to borrow?", "Request Loan")
                If IsNumeric(debtAmount) Then
                    debtList.Add("Player 1 borrowed " & debtAmount & " units.")
                    player1 += Val(debtAmount)
                    TextBox1.Text = player1.ToString()
                    UpdateDebtList()
                End If
            End If
        End If

        If player2 <= 0 Then
            Dim requestDebt = MsgBox("Player 2 has run out of money. Do they want to request a loan?", MsgBoxStyle.YesNo)
            If requestDebt = MsgBoxResult.Yes Then
                Dim debtAmount = InputBox("How much does Player 2 want to borrow?", "Request Loan")
                If IsNumeric(debtAmount) Then
                    debtList.Add("Player 2 borrowed " & debtAmount & " units.")
                    player2 += Val(debtAmount)
                    TextBox2.Text = player2.ToString()
                    UpdateDebtList()
                End If
            End If
        End If

    End Sub

    Private Sub UpdateDebtList()
        ListBox1.Items.Clear()
        For Each debt In debtList
            ListBox1.Items.Add(debt)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class Class1

    Public lastname As String
    Public Firstnamr As String
    Public SalaartValue As Decimal


    Public Sub New(F As String, L As String, S As Decimal)
        Firstnamr = F
        lastname = L
        SalaartValue = S

    End Sub

    Public Overrides Function ToString() As String
        Return String.Format("{0}{1}{2}", Firstnamr, lastname, SalaartValue)
    End Function
End Class

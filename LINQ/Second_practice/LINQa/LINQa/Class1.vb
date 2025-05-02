Public Class Class1
    Public Property Lastname As String
    Public Property Firstname As String

    Public montlySalaryValue As Decimal


    Public Sub New(ByVal first As String, ByVal last As String, ByVal salary As Decimal)
        Firstname = first
        Lastname = last
        montlySalaryValue = salary

    End Sub


    Public Overrides Function ToString() As String
        Return String.Format("{0,-10} {1,-10} {2,10:C}", Firstname, Lastname, montlySalaryValue)
    End Function


End Class

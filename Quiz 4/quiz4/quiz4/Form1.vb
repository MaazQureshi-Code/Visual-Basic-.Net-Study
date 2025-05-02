
Imports System.Data.SqlClient
Public Class Form1
    Dim cn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Database\New folder.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.Open()
    End Sub
    Sub display()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            Dim query As String = "SELECT * FROM myTable"
            Dim command As New SqlCommand(query, cn)
            Dim DT As New DataTable
            Dim SDAdapter As New SqlDataAdapter(command)

            SDAdapter.Fill(DT)
            DataGridView1.DataSource = DT

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        display()

    End Sub
End Class

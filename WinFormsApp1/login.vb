Imports System.Data
Imports System.Data.SqlClient


Public Class login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredemail As String
        Dim enteredpassword As String
        enteredemail = txtemail.Text
        enteredpassword = txtpassword.Text

        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FHMHP9S\SQLEXPRESS;Initial Catalog=userregvb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT [password] FROM [dbo].[userreg] WHERE [email] = @Email", con)
        cmd.Parameters.AddWithValue("@Email", enteredemail)
        con.Open()
        Dim password As String = Convert.ToString(cmd.ExecuteScalar())

        If ((enteredemail.Equals("admin") And enteredpassword.Equals("admin")) Or enteredpassword = password) Then
            MessageBox.Show("Login Successful", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("invalid values", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        txtpassword.UseSystemPasswordChar = True
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Imports System.Data
Imports System.Data.SqlClient


Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FHMHP9S\SQLEXPRESS;Initial Catalog=userregvb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[userreg]
           ([username]
           ,[lastname]
           ,[telephone]
           ,[email]
           ,[password])
            VALUES
           ('" + txtusername.Text + "','" + txtlastname.Text + "','" + txttelephone.Text + "','" + txtemail.Text + "','" + txtpassword.Text + "')", con)

        If String.IsNullOrEmpty(txtusername.Text) Or String.IsNullOrEmpty(txtlastname.Text) Or String.IsNullOrEmpty(txttelephone.Text) Or String.IsNullOrEmpty(txtemail.Text) Or String.IsNullOrEmpty(txtpassword.Text) Or Not txtemail.Text Like "*@gmail.com" Or Len(CStr(txttelephone.Text)) <> 10 Then
            MessageBox.Show("missing values", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("You have registered successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        End If

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        txtpassword.UseSystemPasswordChar = True
    End Sub


End Class

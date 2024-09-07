Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim currentDate As DateTime = DateTime.Now
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FHMHP9S\SQLEXPRESS;Initial Catalog=userregvb;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("INSERT INTO [dbo].[evenement]
           ([nom_even]
           ,[type_even]
           ,[date_reservation]
           ,[date_organisation]
           ,[duree]
           ,[localisation]
           ,[nbrs_participants])
            VALUES
           ('" + txtnom_even.Text + "','" + combotype_even.Text + "', @variable  ,'" + date_even.Text + "','" + Comboduree_even.Text + "' , '" + Combolocal_even.Text + "', '" + txtnbrs_partc.Text + "')", con)
        Dim cmd2 As SqlCommand = New SqlCommand("INSERT INTO personnels ([nom_evenement]) VALUES ('" + txtnom_even.Text + "') WHERE type_personnel = '" + personnel_d_accueil.Name + "' ")

        cmd1.Parameters.AddWithValue("@variable", currentDate.ToString("yyyy-MM-dd"))
        con.Open()
        cmd1.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        MessageBox.Show("reservation avec succes", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = String.Empty
            End If
        Next

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.Cursor = Cursors.Hand
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Environment.Exit(0)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

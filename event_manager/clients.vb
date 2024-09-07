Imports System.Data
Imports System.Data.SqlClient


Public Class clients


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
           ,[nbrs_participants]
           ,[personnel_acceuil]
           ,[Photographe]
           ,[Responsable_prog]
           ,[Personnel_rest]
           ,[technicien]
           ,[nbrs_tables]
           ,[nbrs_chaises]
           ,[etat_even])
            VALUES
           ('" + txtnom_even.Text + "','" + combotype_even.Text + "', @variable  ,'" + date_even.Text + "','" + Comboduree_even.Text + "' , '" + Combolocal_even.Text + "', '" + txtnbrs_partc.Text + "' , " & CInt(NumericUpDown1.Value) & "," & CInt(NumericUpDown10.Value) & "," & CInt(NumericUpDown7.Value) & "," & CInt(NumericUpDown9.Value) & ", " & CInt(NumericUpDown8.Value) & "," & CInt(NumericUpDown3.Value) & ",  " & CInt(NumericUpDown2.Value) & " ,'planifiee' )", con)


        cmd1.Parameters.AddWithValue("@variable", currentDate.ToString("yyyy-MM-dd"))
        con.Open()
        cmd1.ExecuteNonQuery()
        MessageBox.Show("reservation avec succes", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Text = String.Empty
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).Text = String.Empty
            ElseIf TypeOf ctrl Is NumericUpDown Then
                DirectCast(ctrl, NumericUpDown).Value = 0
            End If
        Next
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.Cursor = Cursors.Hand
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Environment.Exit(0)
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.Cursor = Cursors.Hand
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.Cursor = Cursors.Hand
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.Cursor = Cursors.Hand
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        participants.Show()
        Me.Hide()
    End Sub

    Private Sub client1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
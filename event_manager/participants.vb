Imports System.Data.SqlClient
Public Class participants

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FHMHP9S\SQLEXPRESS;Initial Catalog=userregvb;Integrated Security=True")
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.Cursor = Cursors.Hand
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.Cursor = Cursors.Hand
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        clients.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.Cursor = Cursors.Hand
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Show()
    End Sub


    Private Sub Label5_MouseEnter(sender As Object, e As EventArgs) Handles Label5.MouseEnter
        Label5.Cursor = Cursors.Hand
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Environment.Exit(0)
    End Sub

    Private Sub participant1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim columnName As String = "nom_even"
        Dim com2 As New SqlCommand("SELECT " & columnName & " FROM evenement ", con)

        con.Open()
        com2.ExecuteNonQuery()
        Dim reader As SqlDataReader = com2.ExecuteReader()

        While reader.Read()
            ComboBox1.Items.Add(reader(columnName).ToString())
        End While
        con.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eventName As String = ComboBox1.SelectedItem.ToString()
        con.Open()
        Dim command As New SqlCommand("SELECT * FROM evenement  WHERE nom_even = @EventName ", con)
        command.Parameters.AddWithValue("@EventName", eventName)
        Dim adapter1 As New SqlDataAdapter(command)
        Dim table1 As New DataTable()
        adapter1.Fill(table1)
        DataGridView1.DataSource = table1
        con.Close()
    End Sub
End Class
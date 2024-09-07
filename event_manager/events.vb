Imports System.Buffers
Imports System.ComponentModel.DataAnnotations
Imports System.Data.SqlClient

Public Class Form1

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-FHMHP9S\SQLEXPRESS;Initial Catalog=userregvb;Integrated Security=True")
    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.Cursor = Cursors.Hand
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Environment.Exit(0)
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Show()
        update_grid()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        clients.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        participants.Show()
        Me.Hide()
    End Sub

    Private Sub update_grid()

        con.Open()
        Dim adapter1 As New SqlDataAdapter("SELECT * FROM evenement WHERE etat_even = 'planifiee' ", con)
        Dim adapter2 As New SqlDataAdapter("SELECT * FROM evenement WHERE etat_even = 'confirmee' ", con)
        Dim table1 As New DataTable()
        Dim table2 As New DataTable()
        adapter1.Fill(table1)
        adapter2.Fill(table2)
        DataGridView1.DataSource = table1
        DataGridView2.DataSource = table2
        con.Close()

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


        update_grid()


    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.CenterToScreen()


        update_grid()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id_even").Value)
            Dim newValue As String = "confirmee"
            Dim query As String = "UPDATE evenement SET etat_even = @NewValue WHERE id_even = @Id"

            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@NewValue", newValue)
                command.Parameters.AddWithValue("@Id", id)

                con.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()


                If rowsAffected > 0 Then
                    MessageBox.Show("Row updated successfully!")
                Else
                    MessageBox.Show("Failed to update row.")
                End If

                con.Close()
            End Using
        Else
            MessageBox.Show("  Please select an event ! ")
        End If
        update_grid()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim id = Convert.ToInt32(selectedRow.Cells("id_even").Value)
            Dim query = "DELETE FROM evenement WHERE id_even = @Id"

            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@Id", id)
                con.Open()
                Dim rowsAffected = command.ExecuteNonQuery

                If rowsAffected > 0 Then
                    MessageBox.Show("Row deleted successfully!")
                Else
                    MessageBox.Show("Failed to delete row.")
                End If

                con.Close()
            End Using
        Else
            MessageBox.Show("  Please select an event ! ")
        End If
        update_grid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView2.SelectedRows.Count > 0 Then

            Dim selectedRow = DataGridView2.SelectedRows(0)
            Dim id = Convert.ToInt32(selectedRow.Cells("id_even").Value)
            Dim query = "DELETE FROM evenement WHERE id_even = @Id"

            Using command As New SqlCommand(query, con)
                command.Parameters.AddWithValue("@Id", id)
                con.Open()
                Dim rowsAffected = command.ExecuteNonQuery

                If rowsAffected > 0 Then
                    MessageBox.Show("Row deleted successfully!")
                Else
                    MessageBox.Show("Failed to delete row.")
                End If

                con.Close()
            End Using
        Else
            MessageBox.Show("  Please select an event ! ")
        End If
        update_grid()
    End Sub
End Class

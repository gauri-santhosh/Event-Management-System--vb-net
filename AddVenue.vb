Imports System.Data.SqlClient
Public Class AddVenue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = "Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from add_venue where venue_name='" & TextBox1.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("FirstName Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO add_venue values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & RichTextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & RichTextBox2.Text & "')", con)
                If (TextBox1.Text = "" Or ComboBox1.Text = "" Or RichTextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or RichTextBox2.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    TextBox1.Clear()
                    ComboBox1.Text = " "
                    RichTextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox5.Clear()
                    TextBox6.Clear()
                    RichTextBox2.Clear()
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
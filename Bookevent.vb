Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Imports System.Net
Imports System.Reflection.Emit
Imports System.Windows

Public Class Bookevent

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("select venue_name,types_of_events,address,map_location,phone,venue_contact_name,email,website,price from add_venue where types_of_events=@types_of_events ", conn)
        cmd.Parameters.AddWithValue("types_of_events", ComboBox1.Text)
        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader
        If myreader.Read Then
            Label2.Text = "Venue Name: " & vbCrLf & myreader("venue_name") & vbCrLf & vbCrLf & "Price: " & vbCrLf & myreader("price")
            Label3.Text = "Address: " & myreader("address") & vbCrLf & "Location: " & myreader("map_location") & vbCrLf & "Phone: " & myreader("phone") & vbCrLf & "Contact Name: " & myreader("venue_contact_name") & vbCrLf & "Email: " & myreader("email") & vbCrLf & "Website: " & myreader("website")
        Else
            MessageBox.Show("No Data Found")
        End If
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New Payment With {
            .StringPass = Label2.Text
        }
        OBJ.Show()
        Me.Hide()
    End Sub
End Class
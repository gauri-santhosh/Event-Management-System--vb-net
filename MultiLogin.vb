Imports System.Data.SqlClient
Public Class Multilogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "") Then
            MsgBox("Enter the Username")
            TextBox1.Focus() 'focus he username textbox'
            Exit Sub
        End If
        If (TextBox2.Text = "") Then
            MsgBox("Enter the Password")
            TextBox2.Focus() 'focus the password textbox'
            Exit Sub
        End If

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True"

        Try

            Dim objcon As SqlConnection = Nothing
            Dim objcmd As SqlCommand = Nothing
            objcon = New SqlConnection("Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from user_registration where username ='" & TextBox1.Text & "' AND password ='" & TextBox2.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                Form2.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                TextBox1.Clear()
                TextBox2.Clear()

            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        user_or_organiser.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (TextBox3.Text = "") Then
            MsgBox("Enter the Username")
            TextBox3.Focus() 'focus he username textbox'
            Exit Sub
        End If
        If (TextBox4.Text = "") Then
            MsgBox("Enter the Password")
            TextBox4.Focus() 'focus the password textbox'
            Exit Sub
        End If

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True"

        Try

            Dim objcon As SqlConnection = Nothing
            Dim objcmd As SqlCommand = Nothing
            objcon = New SqlConnection("Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from org_registration where username ='" & TextBox3.Text & "' AND password ='" & TextBox4.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                Form3.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                TextBox3.Clear()
                TextBox4.Clear()

            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim cmd As New SqlCommand("select * from admin where username='admin' and password=@password", con)
        cmd.Parameters.AddWithValue("password", TextBox6.Text)
        Dim myreader As SqlDataReader = cmd.ExecuteReader
        If (myreader.Read()) Then

            MessageBox.Show("Login successfully")
            Admin.Show()
            Me.Hide()
        Else
            MsgBox("Error Password")
        End If
    End Sub

    Private Sub Multilogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
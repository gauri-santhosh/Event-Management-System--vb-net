Imports System.Data.SqlClient
Public Class User_Registration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = "Data Source=DESKTOP-TEK2TU8\SQLEXPRESS;Initial Catalog=EVM;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from user_registration where username='" & username.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Username Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO user_registration values('" & username.Text & "','" & gender.Text & "','" & phone.Text & "','" & address.Text & "','" & email.Text & "','" & password.Text & "')", con)
                If (username.Text = "" Or gender.Text = "" Or phone.Text = "" Or address.Text = "" Or email.Text = "" Or password.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Multilogin.Show()
                    username.Clear()
                    gender.Text = " "
                    phone.Clear()
                    address.Clear()
                    email.Clear()
                    password.Clear()
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Multilogin.Show()
        username.Clear()
        gender.Text = " "
        phone.Clear()
        address.Clear()
        email.Clear()
        password.Clear()
        Hide()
    End Sub
End Class
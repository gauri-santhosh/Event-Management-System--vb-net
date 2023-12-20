Public Class user_or_organiser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User_Registration.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Org_Registration.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Multilogin.Show()
    End Sub
End Class
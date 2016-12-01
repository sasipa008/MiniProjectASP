
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim authen As New th.ac.psu.passport.Authentication
        Dim b As String
        Dim i As Integer
        Dim Data(99) As String
        i = 0
        If authen.Authenticate(Me.Username.Text, Me.Password.Text) Then

            For Each b In authen.GetUserDetails(Me.Username.Text, Me.Password.Text)
                Data(i) = b
                i += 1
                Response.Write(b & "<br>")
            Next
        End If

    End Sub
End Class

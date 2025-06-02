Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblOu.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Imports System.DirectoryServices

    Public Class Form1

        Private Sub btnCrearUser_Click(sender As Object, e As EventArgs) Handles btnCrearUser.Click
            Dim username As String = txtUser.Text.Trim()
            Dim fullName As String = txtName.Text.Trim()
            Dim password As String = txtpasswd.Text
            Dim ouPath As String = txtOu.Text.Trim()

            If username = "" Or fullName = "" Or password = "" Or ouPath = "" Then
                estado.Text = "Por favor completa todos los campos."
                Return
            End If

            Try
                Dim entry As New DirectoryEntry("LDAP://" & ouPath)
                Dim newUser As DirectoryEntry = entry.Children.Add("CN=" & fullName, "user")

                newUser.Properties("samAccountName").Value = username
                newUser.Properties("userPrincipalName").Value = username & "@midominio.com"
                newUser.Properties("displayName").Value = fullName

                newUser.CommitChanges()

                newUser.Invoke("SetPassword", New Object() {password})

                ' Habilitar cuenta
                Dim val As Integer = CInt(newUser.Properties("userAccountControl").Value)
                newUser.Properties("userAccountControl").Value = val And Not &H2
                newUser.CommitChanges()

                estado.Text = "✅ Usuario creado correctamente."

            Catch ex As Exception
                estado.Text = "❌ Error: " & ex.Message
            End Try
        End Sub

    End Class

    Private Sub btnCrearUser_Click(sender As Object, e As EventArgs) Handles btnCrearUser.Click

    End Sub
End Class

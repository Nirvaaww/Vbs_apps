Imports System.DirectoryServices
' agregamos la dependencia para manejar los servicios de directorio

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        ' estancia del label nombre de usuario
    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUser.Click
        '  Evento del boton que crea usuario
        Dim username As String = txtUser.Text.Trim()
        ' llamada a la variable del text field para el nombre de usuario
        Dim fullName As String = txtName.Text.Trim()
        ' llamada a la variable del text field para el nombre de usuario
        Dim password As String = txtPasswd.Text
        ' llamada a la variable del text field que contiene la contraseña del usuario 
        Dim ouPath As String = txtOU.Text.Trim()
        ' llamada a la variable que contiene el nombre de la ou
        ' Son llamados variables ya que no se mantienen a lo largo de la ejecución del programa de lo contrario estas cambian dependiendo el valor que tome cada field
        If username = "" Or fullName = "" Or password = "" Or ouPath = "" Then
            ' Condicional que corre las variables para verificar que estas esten completadas.
            Estado.Text = "Por favor completa todos los campos."
            ' Mensaje
            Return
        End If
        If ouPath = "" Then
            ouPath = "CN=Users,DC=dominio18,DC=ga" ' 
        End If

        Try
            ' manejador de errores try catch
            Dim entry As New DirectoryEntry("LDAP://" & ouPath)
            ' crea una entrada al ldap concatenando la ruta a la unidad organizativa
            Dim newUser As DirectoryEntry = entry.Children.Add("CN=" & fullName, "user")
            ' crea el objeto user y le asigna el valor de la variable que contiene el nombre del usuario que ingresamos.
            newUser.Properties("samAccountName").Value = username
            ' asignamos el username con la variable del campo que ya ingresamos como el nombre corto para el inicio de sesión
            newUser.Properties("userPrincipalName").Value = username & "@midominio.com"
            ' Crea el formato del correo de usuario concatenando el nombre 
            newUser.Properties("displayName").Value = fullName
            ' asignamos el nombre a mostrar en el directorio que seria el nombre completo del usuario
            newUser.CommitChanges()
            ' Guarda los cambios de estos en el active directory
            newUser.Invoke("SetPassword", New Object() {password})
            ' configura la contraseña de este.
            ' Habilitar cuenta
            Dim val As Integer = CInt(newUser.Properties("userAccountControl").Value)
            ' accede al valor de la propiedad useraccountcontrol convierte el valor de la bandera del estado de la cuenta a tipo entero y guarda este numero en una variable
            newUser.Properties("userAccountControl").Value = val And Not &H2
            ' modificamos las propiedades de la cuenta de usuario el valor cambia el hexadecimal que representa cuenta desabilitada con el operador and not
            newUser.CommitChanges()
            ' guarda los cambios
            Estado.Text = "Usuario creado correctamente."

        Catch ex As Exception
            ' arroja la excepcion como mensaje al label vacio
            Estado.Text = "Error: " & ex.Message
        End Try
    End Sub

End Class

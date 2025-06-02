Imports System
Imports System.Diagnostics
'estos campos nos permiten trabajar con las funciones del sistema sin tener que importar la funcion en cada linea
' sytem diagnostics nos permite agregar funciones avanzadas

Module Program
    Sub Main(args As String())
        ' Entrada de la aplicacion arreglo de argumentos
        Console.WriteLine("=== Crear Usuario Local en Ubuntu ===")
        ' Creación del menu con una salida de texto con console.writeline
        Console.Write("Nombre del nuevo usuario: ")
        Dim nombreUsuario As String = Console.ReadLine()
        ' Se establece la variable nombreUsuario cuando la consola
        Console.Write("Contraseña: ")
        Dim contraseña As String = LeerContraseña()


        Dim cmd As String = $"sudo adduser --disabled-password --gecos """" {nombreUsuario}"
        ' se establece una nueva variable usando comandos del sistema como sudo adduser 
        Dim resultado = EjecutarComando(cmd)
        ' llamado a una funcion
        If resultado.ExitCode = 0 Then
            'condicion si el resultado es 0 que significa que fue ejecutado conexito arroja un mensaje 
            Console.WriteLine("Usuario creado. Estableciendo contraseña...")

            Dim passwdCmd = $"echo ""{nombreUsuario}:{contraseña}"" | sudo chpasswd"
            ' esta linea asigna la contraseña al usuario creado
            Dim resultadoPass = EjecutarComando(passwdCmd)

            If resultadoPass.ExitCode = 0 Then
                ' si el resultado es 0 se ejecutó con exito
                Console.WriteLine($"Usuario '{nombreUsuario}' creado y contraseña asignada.")
            Else
                Console.WriteLine("Error al asignar la contraseña.")
            End If
        Else
            Console.WriteLine("Error al crear el usuario:")
            Console.WriteLine(resultado.Salida)
            ' Muestra el error si el usuario no fue creado.
        End If
    End Sub

    Function EjecutarComando(comando As String) As (Salida As String, ExitCode As Integer)
        ' funcion para ejecutar los comandos usando bash se especifica que el comando y la salida debe ser una cadena de texto 
        ' el resultado en su caso será un numero entero 0 si tuvo exito
        Dim psi As New ProcessStartInfo("bash", "-c """ & comando & """")
        ' crea variable que ejecuta el comando como si se escribiese en la terminal
        psi.RedirectStandardOutput = True
        psi.RedirectStandardError = True
        psi.UseShellExecute = False
        psi.CreateNoWindow = True
        ' valores booleanos que captura el comando y evita que se abra una nueva ventana 

        Dim proceso As Process = Process.Start(psi)
        ' crea la variable que permite el inicio del proceso
        Dim salida As String = proceso.StandardOutput.ReadToEnd() & proceso.StandardError.ReadToEnd()
        ' guarda o lee la salida en texto del proceso
        proceso.WaitForExit()
        Return (salida, proceso.ExitCode)
        ' salida o espera a que este proceso termine arrojando un exitcode
    End Function

    Function LeerContraseña() As String
        ' funcion para leer la contraseña que se guarda como un string
        Dim pwd As String = ""

        While True
            ' condicional 
            Dim key = Console.ReadKey(True)
            ' lee las teclas sin mostar en pantalla 
            If key.Key = ConsoleKey.Enter Then
                Console.WriteLine()
                ' al ser presionado enter se termina la entrada 
                Exit While
            ElseIf key.Key = ConsoleKey.Backspace AndAlso pwd.Length > 0 Then
                pwd = pwd.Substring(0, pwd.Length - 1)
                ' elimina el ultimo caracter si se presiona el espaciado
                Console.Write(vbBack & " " & vbBack)
            ElseIf Not Char.IsControl(key.KeyChar) Then
                ' no se agregan letras especiales
                pwd &= key.KeyChar
                Console.Write("*")
            End If
        End While
        Return pwd
    End Function
End Module

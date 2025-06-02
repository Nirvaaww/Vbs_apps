Imports System.Net.Http
Imports Newtonsoft.Json

Module Program
    ' Generamos una constante que contiene la llave de la api
    Const apiKey As String = "a3eab05cd2cdb9128940c4b2c27a17db"
    Const apiUrl As String = "https://api.openweathermap.org/data/2.5/weather?"
    ' constante que contiene la url de la pagina
    Sub Main(args As String())
        ' Solicitamos que introduzcan el nombre la ciudad a buscar 
        Console.WriteLine("Introduce el nombre de la ciudad:")
        Dim ciudad As String = Console.ReadLine()

        ' Crear la URL completa con la ciudad y la clave de API
        Dim url As String = $"{apiUrl}q={ciudad}&appid={apiKey}&units=metric&lang=es"

        ' Llamar al método para obtener y mostrar el clima
        ObtenerClima(url)

        ' Esperar que el usuario presione una tecla antes de cerrar
        Console.WriteLine("Presiona cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

    ' Método para obtener el clima y mostrarlo
    Async Sub ObtenerClima(url As String)
        Try
            ' Crear un cliente HTTP
            Using cliente As New HttpClient()
                ' Realizar la solicitud GET a la API
                Dim respuesta As String = Await cliente.GetStringAsync(url)

                ' Deserializar la respuesta JSON
                Dim clima As ClimaResponse = JsonConvert.DeserializeObject(Of ClimaResponse)(respuesta)

                ' Verificar si se encontró el clima
                If clima IsNot Nothing AndAlso clima.main IsNot Nothing Then
                    'condicional  que verifica el contenido de clima para que no sea nulo
                    ' Mostrar el clima
                    Console.WriteLine($"Clima en {clima.name}, {clima.sys.country}:")
                    Console.WriteLine($"Temperatura: {clima.main.temp}°C")
                    Console.WriteLine($"Descripción: {clima.weather(0).description}")
                    Console.WriteLine($"Humedad: {clima.main.humidity}%")
                    Console.WriteLine($"Viento: {clima.wind.speed} m/s")
                Else
                    Console.WriteLine("No se pudo obtener la información del clima.")
                End If
            End Using
        Catch ex As Exception
            ' Mostrar el error si hay un problema con la solicitud
            Console.WriteLine("Error al obtener los datos del clima: " & ex.Message)
        End Try
    End Sub

    ' Clase para deserializar la respuesta JSON de la API
    Public Class ClimaResponse
        Public Property name As String
        Public Property sys As Sys
        Public Property main As MainInfo
        Public Property weather As List(Of Weather)
        Public Property wind As Wind
    End Class

    ' Clase para los datos del sistema
    Public Class Sys
        Public Property country As String
    End Class

    ' Clase para los datos de temperatura
    Public Class MainInfo
        Public Property temp As Double
        Public Property humidity As Integer
    End Class

    ' Clase para la descripción del clima
    Public Class Weather
        Public Property description As String
    End Class

    ' Clase para los datos del viento
    Public Class Wind
        Public Property speed As Double
    End Class
End Module

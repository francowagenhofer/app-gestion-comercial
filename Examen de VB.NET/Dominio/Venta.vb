Public Class Venta

    Public Property ID As Integer

    Public Property IDCliente As Integer

    Public Property ClienteNombre As String

    Public Property Fecha As DateTime

    Public Property Total As Double

    Public Property Items As List(Of VentaItem)

End Class

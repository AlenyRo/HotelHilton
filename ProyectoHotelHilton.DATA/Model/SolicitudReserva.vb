Namespace Model

    Public Class SolicitudReserva



        Public Property ID As Integer
        Public Property NumeroReserva As Integer
        Public Overridable Property ListaPersonas As IList(Of Personas)
        Public Overridable Property Solicitante As Usuario
        Public Overridable Property Reserva As Reserva
        Public Overridable Property Estado As EstadoSolicitud
    End Class

End Namespace


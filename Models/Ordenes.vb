Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entorno.Models
    Public Class Ordenes

        <Key>
        <Editable(False)>
        <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        <Display(Name:="ID")>
        Public Property IdOrden As Integer
        Public Property Cantidad As Integer

        <Display(Name:="Fecha de la orden")>
        Public Property FechaOrden As Nullable(Of DateTime)

        <Display(Name:="Entregada")>
        Public Property EstaEntregada As Nullable(Of Boolean)

        <Display(Name:="Dirección")>
        Public Property Direccion As String

        <Display(Name:="Comentarios")>
        Public Property Comentarios As String

        <Display(Name:="Solicitante")>
        Public Property NombreSolicitante As String

        <Display(Name:="Usuario")>
        <Editable(False)>
        Public Property UsuarioInsert As String

        'Llave foránea de Productos
        Public Property IdProducto As Integer

        Public Property Productos As Productos

    End Class
End Namespace

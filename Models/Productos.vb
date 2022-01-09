Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Namespace Entorno.Models
    Public Class Productos

        <Key>
        <Editable(False)>
        <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        <Display(Name:="ID")>
        Public Property IdProducto As Integer

        <Required>
        <StringLength(50, MinimumLength:=8, ErrorMessage:="Debe tener al menos ocho caracteres")>
        <Display(Name:="Nombre")>
        Public Property NombreProducto As String


        <Display(Name:="Porciones")>
        Public Property CantidadPorcion As Nullable(Of Integer)

        <StringLength(150, ErrorMessage:="Debe tener al menos tres caracteres")>
        <Display(Name:="Descripción")>
        Public Property Descripcion As String

        <Display(Name:="Precio por Unidad")>
        Public Property PrecioUnidad As Nullable(Of Decimal)

        <Display(Name:="Tamaño")>
        Public Property Tamanio As String

        <Display(Name:="Usuario")>
        <Editable(False)>
        Public Property UsuarioInsert As String

    End Class
End Namespace

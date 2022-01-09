Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Entorno.Models
    Public Class Usuarios
        <Key>
        <Editable(False)>
        <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
        <Display(Name:="ID")>
        Public Property IdUsuario As Integer

        <Required>
        <StringLength(20, MinimumLength:=8, ErrorMessage:="Debe tener al menos ocho caracteres")>
        <Display(Name:="Nombre de Usuario")>
        Public Property NombreUsuario As String

        <Required>
        <StringLength(500, MinimumLength:=8, ErrorMessage:="Debe tener al menos ocho caracteres")>
        <Display(Name:="Clave")>
        Public Property Clave As String

        <Display(Name:="Es administrador")>
        Public Property EsAdministrador As Nullable(Of Boolean)
    End Class
End Namespace



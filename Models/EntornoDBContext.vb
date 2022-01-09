Imports System
Imports System.Data.Entity

Namespace Entorno.Models
    Public Class EntornoDBContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("EntornoDbContext")
        End Sub

        Public Property Productos As DbSet(Of Productos)
        Public Property Ordenes As DbSet(Of Ordenes)
        Public Property Usuarios As DbSet(Of Usuarios)

    End Class
End Namespace

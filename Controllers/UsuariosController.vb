Imports System.Web.Mvc

Namespace Controllers
    Public Class UsuariosController
        Inherits Controller

        ' GET: Usuarios
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace
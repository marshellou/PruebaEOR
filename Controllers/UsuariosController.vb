Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports PruebaEOR.Entorno.Models

Namespace Controllers
    Public Class UsuariosController
        Inherits Controller

        ' GET: Usuarios
        '    Function Index() As ActionResult
        '        Return View()
        '    End Function
        'End Class

        <HttpGet>
        Function Login() As ActionResult
            Return View()
        End Function

        Function Verify(ByVal acc As Usuarios) As ActionResult
            Return View()
        End Function


    End Class
End Namespace
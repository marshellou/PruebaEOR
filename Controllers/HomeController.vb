Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    <Authorize>
    Function Index() As ActionResult
        Return View()
    End Function

    <Authorize>
    Function About() As ActionResult
        Return View()
    End Function

    <Authorize>
    Function Contact() As ActionResult
        Return View()
    End Function

End Class

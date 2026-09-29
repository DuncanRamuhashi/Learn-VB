Option Strict On
Option Explicit On
Option Infer Off
Public Class Disease

    Private _TB As String
    Private _HIV As String

    Public Property TB As String
        Set(value As String)
            _TB = value
        End Set
        Get
            Return _TB
        End Get
    End Property

    Public Property HIV As String
        Set(value As String)
            _HIV = value
        End Set
        Get
            Return _HIV
        End Get
    End Property
    'methods
End Class

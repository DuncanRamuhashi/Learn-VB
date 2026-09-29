Option Explicit On
Option Strict On
Option Infer Off

Public Class Employee

    Private _Salary As Integer

    Public Property Salary() As Integer
        Set(value As Integer)
            _Salary = value
        End Set
        Get
            Return _Salary
        End Get
    End Property
    Public Overridable Function CalculateSalary(ByVal hours As Integer) As Integer
        Return Salary
    End Function
End Class

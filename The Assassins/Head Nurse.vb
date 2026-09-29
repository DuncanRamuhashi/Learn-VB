Option Explicit On
Option Strict On
Option Infer Off

Public Class HeadNurse
    Inherits Employee

    Public Overrides Function Calculatesalary(ByVal days As Integer) As Integer
        If days = 20 Then
            Salary = 20 * 500
        End If
        Return Salary
    End Function
End Class

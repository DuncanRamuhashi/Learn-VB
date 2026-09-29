Option Explicit On
Option Strict On
Option Infer Off

Public Class Gardener
    Inherits Employee

    Public Overrides Function calculatesalary(ByVal days As Integer) As Integer

        If days = 24 Then
            Salary = 20 * 300
        End If
        Return Salary
    End Function
End Class

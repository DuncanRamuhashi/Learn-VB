Option Explicit On
Option Strict On
Option Infer Off

Public Class Doctor
    Inherits Employee
    Public Overrides Function CalculateSalary(ByVal days As Integer) As Integer
        Dim hours As Integer
        If hours = 8 Then
            Salary = 1100
            If days = 20 Then
                Salary = 20 * 1100
            End If
        ElseIf hours > 8 Then
            Salary += 200
        End If
        Return Salary
    End Function
End Class

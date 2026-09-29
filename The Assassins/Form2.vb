Option Strict On
Option Explicit On
Option Infer Off

Public Class frmAdmission

    Private numpatient As Integer
    Private myclinic As Clinic

    Private Sub btnaddp_Click(sender As Object, e As EventArgs) Handles btnaddp.Click
        ' dim patientnumber as 
        Dim id As Integer
        id = CInt(InputBox("Enter the ID patient requiring medical attention"))
        numpatient = myclinic.npatients
        For p As Integer = 1 To numpatient
            If id = myclinic.patients(p).id Then
                Me.grdadd.Rows.Add(id, myclinic.patients(p).name, myclinic.patients(p).surname)
            End If
        Next p


    End Sub
End Class
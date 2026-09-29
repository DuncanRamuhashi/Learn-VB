Option Strict On
Option Explicit On
Option Infer Off

Public Class frmbooking
    Private clinic As Clinic
    Private addpatients As Integer
    Private clinicname As String
    Private Sub btnname_Click(sender As Object, e As EventArgs) Handles btnname.Click
        clinicname = InputBox("Enter Name of Clinic")
        addpatients = 0
        txtclinicname.Text = clinicname
    End Sub
    Private Sub addpatient_Click(sender As Object, e As EventArgs) Handles addpatient.Click
        addpatients += 1
        clinic = New Clinic(addpatients)
        clinic.patients(addpatients).patientnumber = addpatients
        clinic.patients(addpatients).name = InputBox("Enter the name of the patient")
        clinic.patients(addpatients).surname = InputBox("Enter the surname of the patient")
        clinic.patients(addpatients).id = CInt(InputBox("Enter the ID of " & clinic.patients(addpatients).name & " " & clinic.patients(addpatients).surname))
        Dim gendercheck As Integer = CInt(InputBox("Is " & clinic.patients(addpatients).name & " " & clinic.patients(addpatients).surname & " ,Male or Female " & Environment.NewLine & "1.Male or 2. Female"))
        Select Case gendercheck
            Case 1
                clinic.patients(addpatients).gender = "Male"
            Case 2
                clinic.patients(addpatients).gender = "Female"
        End Select
        clinic.patients(addpatients).contact = CInt(InputBox("Enter Number Phone of " & clinic.patients(addpatients).name & " " & clinic.patients(addpatients).surname))
        clinic.patients(addpatients).kincontact = CInt(InputBox("Enter Number Phone of next to kin " & clinic.patients(addpatients).name & " " & clinic.patients(addpatients).surname))
        clinic.patients(addpatients).place = InputBox("Enter Area that " & clinic.patients(addpatients).name & " " & clinic.patients(addpatients).surname & "live")
        clinic.patients(addpatients).adress = InputBox("Write adress of " & clinic.patients(addpatients).name & " " & clinic.patients(addpatients).surname)
        Me.grdbooking.Rows.Add(clinic.patients(addpatients).patientnumber, clinic.patients(addpatients).id, clinic.patients(addpatients).name, clinic.patients(addpatients).surname, clinic.patients(addpatients).gender, clinic.patients(addpatients).contact, clinic.patients(addpatients).kincontact, clinic.patients(addpatients).adress, clinic.patients(addpatients).place, clinic.patients(addpatients).Booking)
        frmAdmission.Show()
    End Sub

    Private Sub btnpatientvisit_Click(sender As Object, e As EventArgs) Handles btnpatientvisit.Click
        ''''''''''''''coming baaaack
        Dim patientnumber As Integer = CInt(InputBox("Enter the Patient number Visiting "))
        clinic.patients(patientnumber).PatientVisit()
        Dim GridObject As New DataGridViewRow
        GridObject = grdbooking.Rows(addpatients)
        GridObject.Cells(patientnumber).Value = clinic.patients(patientnumber).PatientVisit()
        ' Me.grdbooking.Rows.Add(clinic.patients(patientnumber).patientnumber, clinic.patients(patientnumber).id, clinic.patients(patientnumber).name, clinic.patients(patientnumber).surname, clinic.patients(patientnumber).gender, clinic.patients(patientnumber).contact, clinic.patients(patientnumber).kincontact, clinic.patients(patientnumber).adress, clinic.patients(patientnumber).place, clinic.patients(patientnumber).PatientVisit())
    End Sub

    Private Sub btncancelvisit_Click(sender As Object, e As EventArgs) Handles btncancelvisit.Click
        TextBox1.Text = CStr(addpatients)
    End Sub
End Class

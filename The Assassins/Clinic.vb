Option Explicit On
Option Strict On
Option Infer Off

Public Class Clinic
    Private _npatients As Integer
    Private _ClinicName As String
    Private _areanumber As Integer
    Private _adress As String
    Private _patients() As Patient
    Public Property patients(n As Integer) As Patient
        Get
            Return _patients(n)
        End Get
        Set(value As Patient)
            _patients(n) = value
        End Set
    End Property
    Public Property npatients() As Integer
        Get
            Return _npatients
        End Get
        Set(value As Integer)
            _npatients = value
        End Set
    End Property

    Public Property adress() As String
        Get
            Return _adress
        End Get
        Set(value As String)
            _adress = value
        End Set


    End Property
    Public Property clinicName() As String
        Get
            Return _ClinicName
        End Get
        Set(value As String)
            _ClinicName = value
        End Set
    End Property
    Public Property areanumber() As Integer
        Get
            Return _areanumber
        End Get
        Set(value As Integer)
            _areanumber = value
        End Set
    End Property
    Public Sub New(patient As Integer)
        _npatients = patient
        Full()
        ReDim Preserve _patients(_npatients)
        For n As Integer = 1 To _npatients
            _patients(n) = New Patient(n)
        Next n
    End Sub
    Private Sub Full()
        If _npatients > 45 Then
            _npatients = 45
            MsgBox("Full")
        End If
    End Sub
    Public Sub New()
    End Sub



End Class

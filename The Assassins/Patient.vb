Option Strict On
Option Explicit On
Option Infer Off

Public Class Patient
    Private _patientnumber As Integer
    Private _id As Integer
    Private _name As String
    Private _surname As String
    Private _adress As String
    Private _place As String
    Private _dstype As String
    Private _gender As String
    Private _contact As Integer
    Private _kincontact As Integer
    Private _Booking As Integer

    Public Property surname() As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property
    Public Property patientnumber() As Integer
        Get
            Return _patientnumber
        End Get
        Set(value As Integer)
            _patientnumber = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property gender() As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property
    Public Property Booking() As Integer
        Set(value As Integer)
            _Booking = value
        End Set
        Get
            Return _Booking
        End Get
    End Property
    Public Property kincontact() As Integer
        Get
            Return _kincontact
        End Get
        Set(value As Integer)
            _kincontact = value
        End Set
    End Property
    Public Property contact() As Integer
        Get
            Return _contact
        End Get
        Set(value As Integer)
            _contact = value
        End Set
    End Property
    Public Property dstype() As String
        Get
            Return _dstype
        End Get
        Set(value As String)
            _dstype = value
        End Set


    End Property
    Public Property place() As String
        Get
            Return _place
        End Get
        Set(value As String)
            _place = value
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

    Public Sub New(npatient As Integer)
        Booking = 0
        _patientnumber = npatient
    End Sub
    Public Sub New()
    End Sub

    Public Function PatientVisit() As Integer
        Booking += 1
        Return Booking
    End Function
    Public Function cancelPatientVisit() As Integer
        Booking -= 1
        Return Booking
    End Function
    Public Function pay() As String
        Dim money As Double = 35
        Dim msg As String
        If money > 0 Then
            msg = "Yes"
            Booking += 1
            MsgBox("Give Em the reccpt")

        Else
            msg = "No"
        End If
        Return msg
    End Function

    Public Function SeenOrNot(ByVal check As Integer) As String
        Dim message As String
        If check = 1 Then
            message = "Yes"
        Else check = 2
            message = "Nooooooo!"
        End If
        Return message
    End Function
End Class










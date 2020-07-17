Option Strict On
Public Class Car
#Region "Properties"
    Shared carCount As Integer = 0
    Private identificationNumber As Integer = 0
    Private make As String = String.Empty
    Private model As String = String.Empty
    Private year As Integer = 0
    Private price As Decimal = 0
    Private newStatus As Boolean = False

#End Region

#Region "Constructor "
    Public Sub New()
        identificationNumber = carCount
        carCount += 1
    End Sub

    Public Sub New(carMake As String, carModel As String, carYear As Integer, carPrice As Decimal, carStatus As Boolean)
        identificationNumber = carCount
        carCount += 1
        Me.manufacturer = carMake
        Me.design = carModel
        Me.time = carYear
        Me.amount = carPrice
        Me.status = carStatus


    End Sub
#End Region

#Region "Properties methods"
    Public Property manufacturer() As String
        Get
            Return make
        End Get
        Set(ByVal value As String)
            make = value
        End Set
    End Property

    Public Property design() As String
        Get
            Return model
        End Get
        Set(ByVal value As String)
            model = value
        End Set
    End Property

    Public Property time() As Integer
        Get
            Return year
        End Get
        Set(ByVal value As Integer)
            year = value
        End Set
    End Property

    Public Property amount() As Decimal
        Get
            Return price
        End Get
        Set(ByVal value As Decimal)
            price = value
        End Set
    End Property

    Public Property status() As Boolean
        Get
            Return newStatus
        End Get
        Set(ByVal value As Boolean)
            newStatus = value
        End Set
    End Property

    Public ReadOnly Property Counter() As Integer
        Get
            Return carCount
        End Get
    End Property

    Public ReadOnly Property identityNumber() As Integer
        Get
            Return identificationNumber
        End Get

    End Property
#End Region

#Region "Methods"
    Public Function GetCarData() As String
        Return "Model " & Me.design & "has a manufaturer " & Me.manufacturer
    End Function
#End Region
End Class

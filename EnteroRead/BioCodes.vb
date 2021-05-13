Imports System
Imports System.Xml
Imports System.Xml.Serialization

Imports System.ComponentModel

Public Class BioCodes
    Inherits BindingList(Of Code)


    Public Shared Function Load(ByVal path As System.String) As BioCodes

        If Not IO.File.Exists(path) Then
            Return Nothing
        End If

        Dim s As New System.Xml.Serialization.XmlSerializer(GetType(BioCodes))

        Dim obj As System.Object

        Using fs As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
            obj = s.Deserialize(fs)
            fs.Close()
        End Using

        Return DirectCast(obj, BioCodes)
    End Function

    Public Shared Sub Save(ByVal path As System.String, ByVal data As BioCodes)
        Dim s As New System.Xml.Serialization.XmlSerializer(GetType(BioCodes))
        Using fs As New IO.FileStream(path, IO.FileMode.Create, IO.FileAccess.Write)
            s.Serialize(fs, data)
            fs.Close()
        End Using
    End Sub

End Class

<DataObject(True)> _
<DefaultBindingProperty("Key")> _
Public Class Code
    Private _Key As System.String
    Private _Name As System.String
    Private _ATypicalTests As System.String = "NONE"
    Private _ConfirmatoryTests As System.String = String.Empty

    <XmlAttributeAttribute()> _
    <Bindable(BindableSupport.Yes)> _
    Public Property Key() As System.String
        Get
            Return Me._Key
        End Get
        Set(ByVal value As System.String)
            Me._Key = value
        End Set
    End Property

    <XmlText()> _
    Public Property Name() As System.String
        Get
            Return Me._Name
        End Get
        Set(ByVal value As System.String)
            Me._Name = value
        End Set
    End Property

    <XmlElement("ATypicalTest")> _
    <DefaultValue("NONE")> _
    Public Property ATypicalTests() As System.String
        Get
            Return Me._ATypicalTests
        End Get
        Set(ByVal value As System.String)
            Me._ATypicalTests = value
        End Set
    End Property

    <XmlElement("ConfirmatoryTests")> _
    <DefaultValue("")> _
    Public Property ConfirmatoryTests() As System.String
        Get
            Return Me._ConfirmatoryTests
        End Get
        Set(ByVal value As System.String)
            Me._ConfirmatoryTests = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal key As System.String, ByVal name As System.String, ByVal aTypicalTests As System.String, ByVal confirmatoryTests As System.String)
        Me._Key = key
        Me._Name = name
        Me._ATypicalTests = aTypicalTests
        Me._ConfirmatoryTests = confirmatoryTests
    End Sub

End Class

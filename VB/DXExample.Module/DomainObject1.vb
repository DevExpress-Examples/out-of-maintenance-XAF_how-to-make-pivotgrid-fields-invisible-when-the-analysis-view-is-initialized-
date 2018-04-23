Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace DXExample.Module
	<DefaultClassOptions> _
	Public Class DomainObject1
		Inherits BaseObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private _property1 As String
		Public Property Property1() As String
			Get
				Return _property1
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property1", _property1, value)
			End Set
		End Property
		Private _property2 As String
		Public Property Property2() As String
			Get
				Return _property2
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property2", _property2, value)
			End Set
		End Property
		Private _property3 As String
		Public Property Property3() As String
			Get
				Return _property3
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property3", _property3, value)
			End Set
		End Property
		Private _property4 As String
		Public Property Property4() As String
			Get
				Return _property4
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property4", _property4, value)
			End Set
		End Property
		Private _property5 As String
		Public Property Property5() As String
			Get
				Return _property5
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Property5", _property5, value)
			End Set
		End Property
	End Class
End Namespace

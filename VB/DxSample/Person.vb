Imports Microsoft.VisualBasic
Imports System.ComponentModel

Namespace DxSample
	Public Class Person
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports DevExpress.Data
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace DxSample.Grid
	Public Class CancellingChangesDataController
		Inherits CurrencyDataController
		Private Class ColumnValuePair
			Private privateColumn As DataColumnInfo
			Public Property Column() As DataColumnInfo
				Get
					Return privateColumn
				End Get
				Set(ByVal value As DataColumnInfo)
					privateColumn = value
				End Set
			End Property
			Private privateValue As Object
			Public Property Value() As Object
				Get
					Return privateValue
				End Get
				Set(ByVal value As Object)
					privateValue = value
				End Set
			End Property

			Public Sub Free()
				Column = Nothing
				Value = Nothing
			End Sub
		End Class

		Private originalValues As New List(Of ColumnValuePair)()

		Private privateCanCancelChanges As Boolean
		Public Property CanCancelChanges() As Boolean
			Get
				Return privateCanCancelChanges
			End Get
			Set(ByVal value As Boolean)
				privateCanCancelChanges = value
			End Set
		End Property

		Private ReadOnly Property ShouldCancelChanges() As Boolean
			Get
				Return CanCancelChanges AndAlso CurrentControllerRow <> NewItemRow AndAlso Not(TypeOf CurrentControllerRowObject Is IEditableObject)
			End Get
		End Property

		Public Overrides Sub BeginCurrentRowEdit()
			MyBase.BeginCurrentRowEdit()
			If ShouldCancelChanges AndAlso originalValues.Count = 0 Then
				For Each col As DataColumnInfo In Columns
					originalValues.Add(New ColumnValuePair() With {.Column = col, .Value = GetCurrentRowValue(col)})
				Next col
			End If
		End Sub

		Public Overrides Function EndCurrentRowEdit(ByVal force As Boolean) As Boolean
			Dim result As Boolean = MyBase.EndCurrentRowEdit(force)
			If result Then
				For Each val As ColumnValuePair In originalValues
					val.Free()
				Next val
				originalValues.Clear()
			End If
			Return result
		End Function

		Public Overrides Sub CancelCurrentRowEdit()
			MyBase.CancelCurrentRowEdit()
			For Each val As ColumnValuePair In originalValues
				SetCurrentRowValue(val.Column, val.Value)
				val.Free()
			Next val
			originalValues.Clear()
		End Sub

		Public Overrides Sub Dispose()
			For Each val As ColumnValuePair In originalValues
				val.Free()
			Next val
			originalValues.Clear()
			MyBase.Dispose()
		End Sub
	End Class
End Namespace

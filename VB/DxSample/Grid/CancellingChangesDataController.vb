Imports DevExpress.Data
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace DxSample.Grid
    Public Class CancellingChangesDataController
        Inherits CurrencyDataController

        Private Class ColumnValuePair
            Public Property Column() As DataColumnInfo
            Public Property Value() As Object

            Public Sub Free()
                Column = Nothing
                Value = Nothing
            End Sub
        End Class

        Private originalValues As New List(Of ColumnValuePair)()

        Public Property CanCancelChanges() As Boolean

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

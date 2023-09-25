Imports DevExpress.Utils.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.ComponentModel

Namespace DxSample.Grid

    Public Class GridViewExOptionsBehavior
        Inherits GridOptionsBehavior

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal view As ColumnView)
            MyBase.New(view)
        End Sub

        Private fCanCancelChanges As Boolean

        <DefaultValue(False)>
        Public Property CanCancelChanges As Boolean
            Get
                Return fCanCancelChanges
            End Get

            Set(ByVal value As Boolean)
                If fCanCancelChanges = value Then Return
                Dim prevValue As Boolean = CanCancelChanges
                fCanCancelChanges = value
                OnChanged(New BaseOptionChangedEventArgs("CanCancelChanges", prevValue, CanCancelChanges))
            End Set
        End Property

        Public Overrides Sub Assign(ByVal options As BaseOptions)
            BeginUpdate()
            Try
                MyBase.Assign(options)
                Dim opt As GridViewExOptionsBehavior = TryCast(options, GridViewExOptionsBehavior)
                If opt Is Nothing Then Return
                fCanCancelChanges = opt.CanCancelChanges
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class
End Namespace

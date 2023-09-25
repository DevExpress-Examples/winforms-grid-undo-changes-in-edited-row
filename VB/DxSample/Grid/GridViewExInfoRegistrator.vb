Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base

Namespace DxSample.Grid

    Public Class GridViewExInfoRegistrator
        Inherits GridInfoRegistrator

        Public Overrides ReadOnly Property ViewName As String
            Get
                Return "GridViewEx"
            End Get
        End Property

        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New GridViewEx(grid)
        End Function
    End Class
End Namespace

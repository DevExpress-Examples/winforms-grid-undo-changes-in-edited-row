Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator

Namespace DxSample.Grid

    Public Class GridControlEx
        Inherits GridControl

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New GridViewExInfoRegistrator())
        End Sub
    End Class
End Namespace

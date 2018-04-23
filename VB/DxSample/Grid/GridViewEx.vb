Imports Microsoft.VisualBasic
Imports DevExpress.Data
Imports DevExpress.Utils.Controls
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.ComponentModel

Namespace DxSample.Grid
	Public Class GridViewEx
		Inherits GridView
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal ownerGrid As GridControl)
			MyBase.New(ownerGrid)
		End Sub

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content), XtraSerializableProperty(XtraSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property OptionsBehavior() As GridViewExOptionsBehavior
			Get
				Return CType(MyBase.OptionsBehavior, GridViewExOptionsBehavior)
			End Get
		End Property

		Protected Overrides Function CreateOptionsBehavior() As ColumnViewOptionsBehavior
			Return New GridViewExOptionsBehavior(Me)
		End Function

		Protected Overrides Function CreateDataController() As BaseGridController
			If requireDataControllerType = DataControllerType.Regular Then
				Return New CancellingChangesDataController()
			End If
			Return MyBase.CreateDataController()
		End Function

		Protected Overrides Function OnCreateLookupDisplayFilter(ByVal text As String, ByVal displayMember As String) As String
			Throw New NotSupportedException("This view cannot be used in lookup editors")
		End Function

		Protected Overrides Sub UpdateDataControllerOptions()
			MyBase.UpdateDataControllerOptions()
			Dim controller As CancellingChangesDataController = TryCast(DataController, CancellingChangesDataController)
			If controller IsNot Nothing Then
				controller.CanCancelChanges = OptionsBehavior.CanCancelChanges
			End If
		End Sub
	End Class
End Namespace

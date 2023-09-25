Imports DevExpress.XtraGrid.Views.Base
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DxSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnValidateRow(ByVal sender As Object, ByVal e As ValidateRowEventArgs)
            Dim p As Person = CType(e.Row, Person)
            e.Valid = String.IsNullOrEmpty(p.Name) OrElse p.Name.Contains("A")
        End Sub
    End Class
End Namespace

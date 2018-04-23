Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DxSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub OnValidateRow(ByVal sender As Object, ByVal e As ValidateRowEventArgs) Handles gridViewEx1.ValidateRow
            Dim p As Person = CType(e.Row, Person)
            e.Valid = String.IsNullOrEmpty(p.Name) OrElse p.Name.Contains("A")
        End Sub
    End Class
End Namespace

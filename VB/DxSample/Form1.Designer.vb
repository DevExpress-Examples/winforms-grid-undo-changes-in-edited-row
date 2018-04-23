Namespace DxSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControlEx1 = New DxSample.Grid.GridControlEx()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridViewEx1 = New DxSample.Grid.GridViewEx()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            DirectCast(Me.gridControlEx1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridViewEx1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControlEx1
            ' 
            Me.gridControlEx1.DataSource = Me.bindingSource1
            Me.gridControlEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControlEx1.Location = New System.Drawing.Point(0, 0)
            Me.gridControlEx1.MainView = Me.gridViewEx1
            Me.gridControlEx1.Name = "gridControlEx1"
            Me.gridControlEx1.Size = New System.Drawing.Size(484, 261)
            Me.gridControlEx1.TabIndex = 0
            Me.gridControlEx1.UseEmbeddedNavigator = True
            Me.gridControlEx1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewEx1})
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = GetType(DxSample.Person)
            ' 
            ' gridViewEx1
            ' 
            Me.gridViewEx1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName})
            Me.gridViewEx1.GridControl = Me.gridControlEx1
            Me.gridViewEx1.Name = "gridViewEx1"
            Me.gridViewEx1.OptionsBehavior.CanCancelChanges = True
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(484, 261)
            Me.Controls.Add(Me.gridControlEx1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControlEx1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridViewEx1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControlEx1 As Grid.GridControlEx
        Private bindingSource1 As System.Windows.Forms.BindingSource
        Private WithEvents gridViewEx1 As Grid.GridViewEx
        Private colName As DevExpress.XtraGrid.Columns.GridColumn

    End Class
End Namespace


namespace DxSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControlEx1 = new DxSample.Grid.GridControlEx();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEx1 = new DxSample.Grid.GridViewEx();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlEx1
            // 
            this.gridControlEx1.DataSource = this.bindingSource1;
            this.gridControlEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEx1.Location = new System.Drawing.Point(0, 0);
            this.gridControlEx1.MainView = this.gridViewEx1;
            this.gridControlEx1.Name = "gridControlEx1";
            this.gridControlEx1.Size = new System.Drawing.Size(484, 261);
            this.gridControlEx1.TabIndex = 0;
            this.gridControlEx1.UseEmbeddedNavigator = true;
            this.gridControlEx1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEx1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DxSample.Person);
            // 
            // gridViewEx1
            // 
            this.gridViewEx1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.gridViewEx1.GridControl = this.gridControlEx1;
            this.gridViewEx1.Name = "gridViewEx1";
            this.gridViewEx1.OptionsBehavior.CanCancelChanges = true;
            this.gridViewEx1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.OnValidateRow);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.gridControlEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Grid.GridControlEx gridControlEx1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Grid.GridViewEx gridViewEx1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;

    }
}


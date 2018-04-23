using DevExpress.Data;
using DevExpress.Utils.Controls;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;

namespace DxSample.Grid {
    public class GridViewEx :GridView {
        public GridViewEx() : base() { }
        public GridViewEx(GridControl ownerGrid) : base(ownerGrid) { }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), XtraSerializableProperty(XtraSerializationVisibility.Content)]
        public new GridViewExOptionsBehavior OptionsBehavior {
            get { return (GridViewExOptionsBehavior)base.OptionsBehavior; }
        }

        protected override ColumnViewOptionsBehavior CreateOptionsBehavior() {
            return new GridViewExOptionsBehavior(this);
        }

        protected override BaseGridController CreateDataController() {
            if (requireDataControllerType == DataControllerType.Regular)
                return new CancellingChangesDataController();
            return base.CreateDataController();
        }

        protected override string OnCreateLookupDisplayFilter(string text, string displayMember) {
            throw new NotSupportedException("This view cannot be used in lookup editors");
        }

        protected override void UpdateDataControllerOptions() {
            base.UpdateDataControllerOptions();
            CancellingChangesDataController controller = DataController as CancellingChangesDataController;
            if (controller != null)
                controller.CanCancelChanges = OptionsBehavior.CanCancelChanges;
        }
    }
}

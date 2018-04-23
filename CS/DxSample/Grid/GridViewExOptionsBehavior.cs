using DevExpress.Utils.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.ComponentModel;

namespace DxSample.Grid {
    public class GridViewExOptionsBehavior :GridOptionsBehavior {
        public GridViewExOptionsBehavior() : base() { }
        public GridViewExOptionsBehavior(ColumnView view) : base(view) { }

        bool fCanCancelChanges;
        [DefaultValue(false)]
        public bool CanCancelChanges {
            get { return fCanCancelChanges; }
            set {
                if (fCanCancelChanges == value) return;
                bool prevValue = CanCancelChanges;
                fCanCancelChanges = value;
                OnChanged(new BaseOptionChangedEventArgs("CanCancelChanges", prevValue, CanCancelChanges));
            }
        }

        public override void Assign(BaseOptions options) {
            BeginUpdate();
            try {
                base.Assign(options);
                GridViewExOptionsBehavior opt = options as GridViewExOptionsBehavior;
                if (opt == null) return;
                fCanCancelChanges = opt.CanCancelChanges;
            } finally { EndUpdate(); }
        }
    }
}

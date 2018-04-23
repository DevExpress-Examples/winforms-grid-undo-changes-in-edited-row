using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace DxSample.Grid {
    public class GridViewExInfoRegistrator :GridInfoRegistrator {
        public override string ViewName {
            get { return "GridViewEx"; }
        }

        public override BaseView CreateView(GridControl grid) {
            return new GridViewEx(grid);
        }
    }
}

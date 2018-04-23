using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;

namespace DxSample.Grid {
    public class GridControlEx :GridControl {
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GridViewExInfoRegistrator());
        }
    }
}

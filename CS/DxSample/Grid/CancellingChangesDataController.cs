using DevExpress.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DxSample.Grid {
    public class CancellingChangesDataController :CurrencyDataController {
        class ColumnValuePair {
            public DataColumnInfo Column { get; set; }
            public object Value { get; set; }

            public void Free() {
                Column = null;
                Value = null;
            }
        }

        List<ColumnValuePair> originalValues = new List<ColumnValuePair>();

        public bool CanCancelChanges { get; set; }

        bool ShouldCancelChanges {
            get { return CanCancelChanges && CurrentControllerRow != NewItemRow && !(CurrentControllerRowObject is IEditableObject); }
        }

        public override void BeginCurrentRowEdit() {
            base.BeginCurrentRowEdit();
            if (ShouldCancelChanges && originalValues.Count == 0)
                foreach (DataColumnInfo col in Columns)
                    originalValues.Add(new ColumnValuePair() { Column = col, Value = GetCurrentRowValue(col) });
        }

        public override bool EndCurrentRowEdit(bool force) {
            bool result = base.EndCurrentRowEdit(force);
            if (result) {
                foreach (ColumnValuePair val in originalValues)
                    val.Free();
                originalValues.Clear();
            }
            return result;
        }

        public override void CancelCurrentRowEdit() {
            base.CancelCurrentRowEdit();
            foreach (ColumnValuePair val in originalValues) {
                SetCurrentRowValue(val.Column, val.Value);
                val.Free();
            }
            originalValues.Clear();
        }

        public override void Dispose() {
            foreach (ColumnValuePair val in originalValues)
                val.Free();
            originalValues.Clear();
            base.Dispose();
        }
    }
}

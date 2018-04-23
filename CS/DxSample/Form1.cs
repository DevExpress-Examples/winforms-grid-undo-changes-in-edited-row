using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DxSample {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void OnValidateRow(object sender, ValidateRowEventArgs e) {
            Person p = (Person)e.Row;
            e.Valid = string.IsNullOrEmpty(p.Name) || p.Name.Contains("A");
        }
    }
}

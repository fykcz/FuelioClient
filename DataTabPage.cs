using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYK.Utils.FuelioClient
{
    internal partial class DataTabPage : TabPage
    {
        public DataTabPage()
        {
            InitializeComponent();
        }

        public void LoadData(List<OneRow> data)
        {
            var cols = data[0].GetColumns();
            foreach (var c in cols)
            {
                dataListView.Columns.Add(c.ColumnName);
            }
        }
    }
}

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
            var cols = data[0].Columns;
            foreach (var c in cols)
            {
                dataListView.Columns.Add(c.ColumnName);
            }

            foreach (var d in data)
            {
                var lvi = new ListViewItem();
                var isFirst = true;
                foreach (var c in cols)
                {
                    if (isFirst)
                    {
                        lvi.Text = d.GetColumnValue(c.ColumnName);
                        isFirst = false;
                    }
                    else
                        lvi.SubItems.Add(d.GetColumnValue(c.ColumnName));
                }
                lvi.Tag = d;
                dataListView.Items.Add(lvi);
            }
            dataListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void dataListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataListView.SelectedItems.Count == 0) return;
            detailListView.SuspendLayout();
            detailListView.Items.Clear();
            var or = (OneRow)(dataListView.SelectedItems[0]).Tag;
            foreach (var c in or.Columns)
            {
                var lvi = new ListViewItem();
                lvi.Text = c.ColumnName;
                lvi.SubItems.Add(or.GetColumnValue(c.ColumnName));
                detailListView.Items.Add(lvi);
            }
            detailListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            detailListView.PerformLayout();
        }
    }
}

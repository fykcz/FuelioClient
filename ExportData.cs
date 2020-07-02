using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FYK.Utils.FuelioClient
{
    internal partial class ExportData : Form
    {

        private List<OneRow> _data;
        public ExportData()
        {
            InitializeComponent();
        }

        private void browseForFileButton_Click(object sender, EventArgs e)
        {
            using (var fd = new SaveFileDialog())
            {
                //fd.Filter = "Tab delimited file (*.txt)|*.txt|XML File (*.xml)|*.xml";
                fd.Filter = "Tab delimited file (*.txt)|*.txt";
                fd.FilterIndex = 1;
                fd.CheckPathExists = true;
                fd.Title = Text;
                fd.DefaultExt = "txt";
                if (outputFileTextBox.Text != "")
                    fd.FileName = outputFileTextBox.Text;
                if (fd.ShowDialog() != DialogResult.OK) return;
                outputFileTextBox.Text = fd.FileName;
            }
        }

        public void LoadData(List<OneRow> data)
        {
            if (data.Count == 0) return;
            LoadColumns(data[0]);
            _data = data;
        }

        private void LoadColumns(OneRow columns)
        {
            availableListBox.Items.Clear();
            selectedListBox.Items.Clear();
            foreach (var c in columns.Columns)
                availableListBox.Items.Add(c.ColumnName);
            SetButtons();
        }
        private void SetButtons()
        {
            addAllButton.Enabled = addButton.Enabled = (availableListBox.Items.Count > 0);
            delAllButton.Enabled = delButton.Enabled = (selectedListBox.Items.Count > 0);
            addButton.Enabled = availableListBox.SelectedIndex > -1;
            delButton.Enabled = selectedListBox.SelectedIndex > -1;

            exportButton.Enabled = (outputFileTextBox.Text.Length > 0) && (selectedListBox.Items.Count > 0);
        }
        private void addAllButton_Click(object sender, EventArgs e)
        {
            while (availableListBox.Items.Count > 0)
            {
                var x = availableListBox.Items[0].ToString();
                selectedListBox.Items.Add(x);
                availableListBox.Items.RemoveAt(0);
            }
            SetButtons();
        }

        private void delAllButton_Click(object sender, EventArgs e)
        {
            while (selectedListBox.Items.Count > 0)
            {
                var x = selectedListBox.Items[0].ToString();
                availableListBox.Items.Add(x);
                selectedListBox.Items.RemoveAt(0);
            }
            SetButtons();
        }
        private void AddColumn()
        {
            if (availableListBox.SelectedIndex > -1)
            {
                var x = availableListBox.SelectedItem.ToString();
                availableListBox.Items.RemoveAt(availableListBox.SelectedIndex);
                selectedListBox.Items.Add(x);
            }
            SetButtons();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddColumn();
        }

        private void availableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void selectedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void DelColumn()
        {
            if (selectedListBox.SelectedIndex > -1)
            {
                var x = selectedListBox.SelectedItem.ToString();
                availableListBox.Items.Add(x);
                selectedListBox.Items.RemoveAt(selectedListBox.SelectedIndex);
            }
            SetButtons();
        }
        private void delButton_Click(object sender, EventArgs e)
        {
            DelColumn();
        }

        private void availableListBox_DoubleClick(object sender, EventArgs e)
        {
            AddColumn();
        }

        private void selectedListBox_DoubleClick(object sender, EventArgs e)
        {
            DelColumn();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using (var sw = new StreamWriter(outputFileTextBox.Text, false, Encoding.Unicode))
            {
                var sb = new StringBuilder();
                foreach (var d in _data)
                {
                    sb.Clear();
                    foreach (var c in selectedListBox.Items)
                    {
                        var colName = c.ToString();
                        sb.Append(d.GetColumnValue(colName));
                        if (colName != selectedListBox.Items[selectedListBox.Items.Count - 1].ToString())
                            sb.Append('\t');
                    }
                    sw.WriteLine(sb.ToString());
                }
                sw.Flush();
                sw.Close();
            }
        }

        private void outputFileTextBox_TextChanged(object sender, EventArgs e)
        {
            SetButtons();
        }
    }
}

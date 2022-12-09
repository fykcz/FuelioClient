using System;
using System.Windows.Forms;

namespace FYK.Utils.FuelioClient
{
    public partial class MainForm : Form
    {
        private FileData _actualFileData = null;
        private string _actualFileName = "";

        public MainForm()
        {
            InitializeComponent();
            tabControl.TabPages.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ax = new AboutBox())
            {
                ax.ShowDialog();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoadData()
        {
            Cursor = Cursors.WaitCursor;
            _actualFileData = new FileData();
            _actualFileData.LoadFile(_actualFileName);
            tabControl.TabPages.Clear();
            foreach (var c in _actualFileData.DataSets.Keys)
            {
                if (_actualFileData.DataSets[c].Count > 0)
                {
                    var tp = new DataTabPage();
                    tp.LoadData(_actualFileData.DataSets[c]);
                    tp.Text = c;
                    tabControl.TabPages.Add(tp);
                }

            }
            //tabControl.SelectedIndex = 0;
            if (tabControl.TabPages.Count > 0)
                exportDataToolStripMenuItem.Enabled = _actualFileData.DataSets[tabControl.TabPages[0].Text].Count > 0;
            Cursor = Cursors.Default;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fn = new OpenFileDialog())
            {
                fn.Filter = "CSV files (*.csv)|*.csv*|All files (*.*)|*.*";
                fn.FilterIndex = 1;
                var initialDirectory = "";

                foreach (var d in System.IO.DriveInfo.GetDrives())
                {
                    if (d.VolumeLabel != null && d.VolumeLabel == "Google Drive")
                    {
                        initialDirectory = System.IO.Path.Combine(d.Name, "Můj disk", @"Android\Fuelio\sync");
                        break;
                    }
                }

                fn.InitialDirectory = initialDirectory;
                fn.RestoreDirectory = true;
                fn.CheckFileExists = true;

                if (fn.ShowDialog() != DialogResult.OK) return;
                _actualFileName = fileNameToolStripStatusLabel.Text = fn.FileName;
            }
            LoadData();
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ed = new ExportData())
            {
                ed.LoadData(_actualFileData.DataSets[tabControl.SelectedTab.Text]);
                ed.ShowDialog();
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
            {
                exportDataToolStripMenuItem.Enabled = false;
                return;
            }

            exportDataToolStripMenuItem.Enabled = _actualFileData.DataSets[tabControl.SelectedTab.Text].Count > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYK.Utils.FuelioClient
{
    public partial class MainForm : Form
    {
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fn = new OpenFileDialog())
            {
                fn.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                fn.FilterIndex = 1;
                fn.InitialDirectory = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Disk Google\Android\Fuelio\sync";
                fn.RestoreDirectory = true;
                fn.CheckFileExists = true;

                if (fn.ShowDialog() != DialogResult.OK) return;
                fileNameToolStripStatusLabel.Text = fn.FileName;

                Cursor = Cursors.WaitCursor;
                var fd = new FileData();
                fd.LoadFile(fn.FileName);
                tabControl.TabPages.Clear();
                foreach (var c in fd.DataSets.Keys)
                {
                    if (fd.DataSets[c].Count > 0)
                    {
                        var tp = new DataTabPage();
                        tp.LoadData(fd.DataSets[c]);
                        tp.Text = c;
                        tabControl.TabPages.Add(tp);
                    }
                        
                }
                Cursor = Cursors.Default;
            }
        }
    }
}

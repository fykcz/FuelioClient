namespace FYK.Utils.FuelioClient
{
    partial class DataTabPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataListView = new System.Windows.Forms.ListView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.detailListView = new System.Windows.Forms.ListView();
            this.columnColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListView
            // 
            this.dataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListView.FullRowSelect = true;
            this.dataListView.HideSelection = false;
            this.dataListView.Location = new System.Drawing.Point(0, 0);
            this.dataListView.MultiSelect = false;
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(198, 411);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            this.dataListView.SelectedIndexChanged += new System.EventHandler(this.dataListView_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailListView);
            this.splitContainer1.Size = new System.Drawing.Size(545, 411);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 1;
            // 
            // detailListView
            // 
            this.detailListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnColumnHeader,
            this.valueColumnHeader});
            this.detailListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.detailListView.HideSelection = false;
            this.detailListView.Location = new System.Drawing.Point(0, 0);
            this.detailListView.MultiSelect = false;
            this.detailListView.Name = "detailListView";
            this.detailListView.Size = new System.Drawing.Size(343, 411);
            this.detailListView.TabIndex = 0;
            this.detailListView.UseCompatibleStateImageBehavior = false;
            this.detailListView.View = System.Windows.Forms.View.Details;
            // 
            // columnColumnHeader
            // 
            this.columnColumnHeader.Text = "Column";
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "Value";
            // 
            // DataTabPage
            // 
            this.Controls.Add(this.splitContainer1);
            this.Size = new System.Drawing.Size(545, 411);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dataListView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView detailListView;
        private System.Windows.Forms.ColumnHeader columnColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
    }
}

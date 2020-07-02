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
            this.SuspendLayout();
            // 
            // dataListView
            // 
            this.dataListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataListView.HideSelection = false;
            this.dataListView.Location = new System.Drawing.Point(0, 0);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(150, 150);
            this.dataListView.TabIndex = 0;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            // 
            // DataTabPage
            // 
            this.Controls.Add(this.dataListView);
            this.Name = "DataTabPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dataListView;
    }
}

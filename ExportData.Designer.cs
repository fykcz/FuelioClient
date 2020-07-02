namespace FYK.Utils.FuelioClient
{
    partial class ExportData
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseForFileButton = new System.Windows.Forms.Button();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.delAllButton = new System.Windows.Forms.Button();
            this.addAllButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availableListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(247, 542);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.exportButton.Location = new System.Drawing.Point(166, 542);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.browseForFileButton);
            this.groupBox1.Controls.Add(this.outputFileTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output File";
            // 
            // browseForFileButton
            // 
            this.browseForFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseForFileButton.Location = new System.Drawing.Point(428, 16);
            this.browseForFileButton.Name = "browseForFileButton";
            this.browseForFileButton.Size = new System.Drawing.Size(26, 23);
            this.browseForFileButton.TabIndex = 1;
            this.browseForFileButton.Text = "...";
            this.browseForFileButton.UseVisualStyleBackColor = true;
            this.browseForFileButton.Click += new System.EventHandler(this.browseForFileButton_Click);
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileTextBox.Location = new System.Drawing.Point(6, 19);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(416, 20);
            this.outputFileTextBox.TabIndex = 0;
            this.outputFileTextBox.TextChanged += new System.EventHandler(this.outputFileTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.delButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.delAllButton);
            this.groupBox2.Controls.Add(this.addAllButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.selectedListBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.availableListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 454);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns Selection";
            // 
            // delButton
            // 
            this.delButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delButton.Location = new System.Drawing.Point(214, 155);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(31, 31);
            this.delButton.TabIndex = 7;
            this.delButton.Text = "<";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(214, 44);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 31);
            this.addButton.TabIndex = 6;
            this.addButton.Text = ">";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delAllButton
            // 
            this.delAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delAllButton.Location = new System.Drawing.Point(214, 118);
            this.delAllButton.Name = "delAllButton";
            this.delAllButton.Size = new System.Drawing.Size(31, 31);
            this.delAllButton.TabIndex = 5;
            this.delAllButton.Text = "<<";
            this.delAllButton.UseVisualStyleBackColor = true;
            this.delAllButton.Click += new System.EventHandler(this.delAllButton_Click);
            // 
            // addAllButton
            // 
            this.addAllButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addAllButton.Location = new System.Drawing.Point(214, 81);
            this.addAllButton.Name = "addAllButton";
            this.addAllButton.Size = new System.Drawing.Size(31, 31);
            this.addAllButton.TabIndex = 4;
            this.addAllButton.Text = ">>";
            this.addAllButton.UseVisualStyleBackColor = true;
            this.addAllButton.Click += new System.EventHandler(this.addAllButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Columns";
            // 
            // selectedListBox
            // 
            this.selectedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedListBox.FormattingEnabled = true;
            this.selectedListBox.Location = new System.Drawing.Point(260, 43);
            this.selectedListBox.Name = "selectedListBox";
            this.selectedListBox.Size = new System.Drawing.Size(194, 394);
            this.selectedListBox.TabIndex = 2;
            this.selectedListBox.SelectedIndexChanged += new System.EventHandler(this.selectedListBox_SelectedIndexChanged);
            this.selectedListBox.DoubleClick += new System.EventHandler(this.selectedListBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Columns";
            // 
            // availableListBox
            // 
            this.availableListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.availableListBox.FormattingEnabled = true;
            this.availableListBox.Location = new System.Drawing.Point(6, 43);
            this.availableListBox.Name = "availableListBox";
            this.availableListBox.Size = new System.Drawing.Size(194, 394);
            this.availableListBox.Sorted = true;
            this.availableListBox.TabIndex = 0;
            this.availableListBox.SelectedIndexChanged += new System.EventHandler(this.availableListBox_SelectedIndexChanged);
            this.availableListBox.DoubleClick += new System.EventHandler(this.availableListBox_DoubleClick);
            // 
            // ExportData
            // 
            this.AcceptButton = this.exportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(484, 577);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.cancelButton);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ExportData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button browseForFileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox availableListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox selectedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button delAllButton;
        private System.Windows.Forms.Button addAllButton;
        private System.Windows.Forms.Button delButton;
    }
}
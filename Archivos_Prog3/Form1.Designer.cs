namespace Archivos_Prog3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxDirectories = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbxResults = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a directory:";
            // 
            // cmbxDirectories
            // 
            this.cmbxDirectories.FormattingEnabled = true;
            this.cmbxDirectories.Items.AddRange(new object[] {
            "D:\\\\",
            "C:\\\\"});
            this.cmbxDirectories.Location = new System.Drawing.Point(118, 71);
            this.cmbxDirectories.Name = "cmbxDirectories";
            this.cmbxDirectories.Size = new System.Drawing.Size(483, 23);
            this.cmbxDirectories.TabIndex = 1;
            this.cmbxDirectories.SelectedValueChanged += new System.EventHandler(this.cmbxDirectories_SelectedValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(118, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 53);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbxResults
            // 
            this.txtbxResults.Location = new System.Drawing.Point(12, 169);
            this.txtbxResults.Multiline = true;
            this.txtbxResults.Name = "txtbxResults";
            this.txtbxResults.ReadOnly = true;
            this.txtbxResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxResults.Size = new System.Drawing.Size(589, 268);
            this.txtbxResults.TabIndex = 3;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(392, 110);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(153, 53);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Visible = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTitle.Location = new System.Drawing.Point(2, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 21);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Current File/Directory:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txtTitle.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtTitle.Location = new System.Drawing.Point(197, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(404, 25);
            this.txtTitle.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 449);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtbxResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbxDirectories);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbxDirectories;
        private Button btnSearch;
        private TextBox txtbxResults;
        private Button btnRead;
        private Label lblTitle;
        private TextBox txtTitle;
    }
}
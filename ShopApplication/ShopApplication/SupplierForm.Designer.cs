namespace ShopApplication
{
    partial class SupplierForm
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
            this.lbSupllierName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lvSupllier = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSupllierName
            // 
            this.lbSupllierName.AutoSize = true;
            this.lbSupllierName.Location = new System.Drawing.Point(13, 13);
            this.lbSupllierName.Name = "lbSupllierName";
            this.lbSupllierName.Size = new System.Drawing.Size(35, 13);
            this.lbSupllierName.TabIndex = 0;
            this.lbSupllierName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(16, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // lvSupllier
            // 
            this.lvSupllier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvSupllier.Location = new System.Drawing.Point(183, 41);
            this.lvSupllier.Name = "lvSupllier";
            this.lvSupllier.Size = new System.Drawing.Size(121, 189);
            this.lvSupllier.TabIndex = 2;
            this.lvSupllier.UseCompatibleStateImageBehavior = false;
            this.lvSupllier.View = System.Windows.Forms.View.Details;
            this.lvSupllier.DoubleClick += new System.EventHandler(this.lvSupllier_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 112;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(16, 68);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 444);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lvSupllier);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbSupllierName);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSupllierName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListView lvSupllier;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btSave;
    }
}
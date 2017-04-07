namespace ShopApplication
{
    partial class CategoryForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.NameBlub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(13, 57);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameBlub});
            this.lvCategory.Location = new System.Drawing.Point(131, 30);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(183, 163);
            this.lvCategory.TabIndex = 3;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.DoubleClick += new System.EventHandler(this.lvCategory_DoubleClick);
            // 
            // NameBlub
            // 
            this.NameBlub.Text = "Name";
            this.NameBlub.Width = 117;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 261);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader NameBlub;
    }
}
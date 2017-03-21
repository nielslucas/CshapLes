namespace ShopApplication
{
    partial class ArtikelForm
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
            this.tbArticalName = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.CreateArtikel = new System.Windows.Forms.Button();
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
            // tbArticalName
            // 
            this.tbArticalName.Location = new System.Drawing.Point(13, 30);
            this.tbArticalName.Name = "tbArticalName";
            this.tbArticalName.Size = new System.Drawing.Size(100, 20);
            this.tbArticalName.TabIndex = 1;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(13, 57);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(60, 13);
            this.lbDescription.TabIndex = 2;
            this.lbDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(13, 74);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(16, 101);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(31, 13);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 117);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 5;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(16, 140);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(35, 13);
            this.lbStock.TabIndex = 6;
            this.lbStock.Text = "Stock";
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(13, 157);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(100, 20);
            this.tbStock.TabIndex = 7;
            // 
            // CreateArtikel
            // 
            this.CreateArtikel.Location = new System.Drawing.Point(13, 184);
            this.CreateArtikel.Name = "CreateArtikel";
            this.CreateArtikel.Size = new System.Drawing.Size(75, 23);
            this.CreateArtikel.TabIndex = 8;
            this.CreateArtikel.Text = "Save Artikel";
            this.CreateArtikel.UseVisualStyleBackColor = true;
            this.CreateArtikel.Click += new System.EventHandler(this.CreateArtikel_Click);
            // 
            // ArtikelCreateAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CreateArtikel);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbArticalName);
            this.Controls.Add(this.lbName);
            this.Name = "ArtikelCreateAndEdit";
            this.Text = "ArtikelCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbArticalName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Button CreateArtikel;
    }
}
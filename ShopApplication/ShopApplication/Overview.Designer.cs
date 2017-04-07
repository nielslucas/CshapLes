namespace ShopApplication
{
    partial class Overview
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
            this.lvArtikels = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonCategorie = new System.Windows.Forms.Button();
            this.addArtikel = new System.Windows.Forms.Button();
            this.gbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvArtikels
            // 
            this.lvArtikels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Description,
            this.Price,
            this.Stock});
            this.lvArtikels.Location = new System.Drawing.Point(13, 13);
            this.lvArtikels.Name = "lvArtikels";
            this.lvArtikels.Size = new System.Drawing.Size(434, 451);
            this.lvArtikels.TabIndex = 0;
            this.lvArtikels.UseCompatibleStateImageBehavior = false;
            this.lvArtikels.View = System.Windows.Forms.View.Details;
            this.lvArtikels.SelectedIndexChanged += new System.EventHandler(this.lvArtikels_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Name";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 250;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.buttonSupplier);
            this.gbAdmin.Controls.Add(this.buttonCategorie);
            this.gbAdmin.Controls.Add(this.addArtikel);
            this.gbAdmin.Location = new System.Drawing.Point(955, 13);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(200, 141);
            this.gbAdmin.TabIndex = 1;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Location = new System.Drawing.Point(7, 79);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(75, 23);
            this.buttonSupplier.TabIndex = 2;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonCategorie
            // 
            this.buttonCategorie.Location = new System.Drawing.Point(7, 50);
            this.buttonCategorie.Name = "buttonCategorie";
            this.buttonCategorie.Size = new System.Drawing.Size(75, 23);
            this.buttonCategorie.TabIndex = 1;
            this.buttonCategorie.Text = "Categorie";
            this.buttonCategorie.UseVisualStyleBackColor = true;
            this.buttonCategorie.Click += new System.EventHandler(this.buttonCategorie_Click);
            // 
            // addArtikel
            // 
            this.addArtikel.Location = new System.Drawing.Point(7, 20);
            this.addArtikel.Name = "addArtikel";
            this.addArtikel.Size = new System.Drawing.Size(75, 23);
            this.addArtikel.TabIndex = 0;
            this.addArtikel.Text = "Artikel";
            this.addArtikel.UseVisualStyleBackColor = true;
            this.addArtikel.Click += new System.EventHandler(this.addArtikel_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 606);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.lvArtikels);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Activated += new System.EventHandler(this.Overview_Activated);
            this.Load += new System.EventHandler(this.Overview_Load);
            this.gbAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvArtikels;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button addArtikel;
        private System.Windows.Forms.Button buttonCategorie;
        private System.Windows.Forms.Button buttonSupplier;
    }
}


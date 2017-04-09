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
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonCategorie = new System.Windows.Forms.Button();
            this.addArtikel = new System.Windows.Forms.Button();
            this.cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.buttonSearchCategory = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchTextbox = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.gbAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvArtikels
            // 
            this.lvArtikels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Description,
            this.Price,
            this.Stock,
            this.cat});
            this.lvArtikels.Location = new System.Drawing.Point(12, 33);
            this.lvArtikels.Name = "lvArtikels";
            this.lvArtikels.Size = new System.Drawing.Size(936, 451);
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
            this.gbAdmin.Controls.Add(this.buttonOrders);
            this.gbAdmin.Controls.Add(this.buttonCustomers);
            this.gbAdmin.Controls.Add(this.buttonSupplier);
            this.gbAdmin.Controls.Add(this.buttonCategorie);
            this.gbAdmin.Controls.Add(this.addArtikel);
            this.gbAdmin.Location = new System.Drawing.Point(955, 13);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(200, 166);
            this.gbAdmin.TabIndex = 1;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Location = new System.Drawing.Point(7, 108);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomers.TabIndex = 3;
            this.buttonCustomers.Text = "Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
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
            // cat
            // 
            this.cat.Text = "Category";
            this.cat.Width = 430;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(13, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // buttonSearchCategory
            // 
            this.buttonSearchCategory.Location = new System.Drawing.Point(153, 6);
            this.buttonSearchCategory.Name = "buttonSearchCategory";
            this.buttonSearchCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCategory.TabIndex = 3;
            this.buttonSearchCategory.Text = "Search";
            this.buttonSearchCategory.UseVisualStyleBackColor = true;
            this.buttonSearchCategory.Click += new System.EventHandler(this.buttonSearchCategory_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(235, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(317, 6);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 5;
            // 
            // buttonSearchTextbox
            // 
            this.buttonSearchTextbox.Location = new System.Drawing.Point(424, 6);
            this.buttonSearchTextbox.Name = "buttonSearchTextbox";
            this.buttonSearchTextbox.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchTextbox.TabIndex = 6;
            this.buttonSearchTextbox.Text = "Search Text";
            this.buttonSearchTextbox.UseVisualStyleBackColor = true;
            this.buttonSearchTextbox.Click += new System.EventHandler(this.buttonSearchTextbox_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(7, 135);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(75, 23);
            this.buttonOrders.TabIndex = 4;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 606);
            this.Controls.Add(this.buttonSearchTextbox);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearchCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.lvArtikels);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Activated += new System.EventHandler(this.Overview_Activated);
            this.Load += new System.EventHandler(this.Overview_Load);
            this.gbAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.ColumnHeader cat;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button buttonSearchCategory;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button buttonSearchTextbox;
        private System.Windows.Forms.Button buttonOrders;
    }
}


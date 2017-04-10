namespace ShopApplication
{
    partial class OrderForm
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
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvOrders = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.lvOrderDetails = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.lvArtikels = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriptionnnn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Storage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtikelAmount = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCustomers
            // 
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvCustomers.Location = new System.Drawing.Point(12, 12);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(121, 604);
            this.lvCustomers.TabIndex = 0;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            this.lvCustomers.DoubleClick += new System.EventHandler(this.lvCustomers_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Customer";
            this.columnHeader1.Width = 110;
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvOrders.Location = new System.Drawing.Point(140, 37);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(121, 579);
            this.lvOrders.TabIndex = 1;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.DoubleClick += new System.EventHandler(this.lvOrders_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order";
            this.columnHeader2.Width = 112;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(140, 12);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(121, 23);
            this.buttonAddOrder.TabIndex = 2;
            this.buttonAddOrder.Text = "Add Order";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // lvOrderDetails
            // 
            this.lvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.Description,
            this.PerPrice,
            this.Amount,
            this.Total});
            this.lvOrderDetails.Location = new System.Drawing.Point(268, 37);
            this.lvOrderDetails.Name = "lvOrderDetails";
            this.lvOrderDetails.Size = new System.Drawing.Size(772, 286);
            this.lvOrderDetails.TabIndex = 3;
            this.lvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // PerPrice
            // 
            this.PerPrice.Text = "PerPrice";
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Location = new System.Drawing.Point(268, 18);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(66, 13);
            this.labelOrderDetails.TabIndex = 4;
            this.labelOrderDetails.Text = "Order details";
            // 
            // lvArtikels
            // 
            this.lvArtikels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.Descriptionnnn,
            this.Price,
            this.Storage});
            this.lvArtikels.Location = new System.Drawing.Point(268, 374);
            this.lvArtikels.Name = "lvArtikels";
            this.lvArtikels.Size = new System.Drawing.Size(772, 242);
            this.lvArtikels.TabIndex = 5;
            this.lvArtikels.UseCompatibleStateImageBehavior = false;
            this.lvArtikels.View = System.Windows.Forms.View.Details;
            this.lvArtikels.DoubleClick += new System.EventHandler(this.lvArtikels_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            // 
            // Descriptionnnn
            // 
            this.Descriptionnnn.Text = "Description";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Storage
            // 
            this.Storage.Text = "Storage";
            // 
            // ArtikelAmount
            // 
            this.ArtikelAmount.Location = new System.Drawing.Point(271, 348);
            this.ArtikelAmount.Name = "ArtikelAmount";
            this.ArtikelAmount.Size = new System.Drawing.Size(100, 20);
            this.ArtikelAmount.TabIndex = 6;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(377, 351);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(43, 13);
            this.lb.TabIndex = 7;
            this.lb.Text = "Amount";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(344, 11);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(160, 23);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "remove selected artikel";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 628);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.ArtikelAmount);
            this.Controls.Add(this.lvArtikels);
            this.Controls.Add(this.labelOrderDetails);
            this.Controls.Add(this.lvOrderDetails);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.lvCustomers);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.ListView lvOrderDetails;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.ListView lvArtikels;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader PerPrice;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader Descriptionnnn;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Storage;
        private System.Windows.Forms.TextBox ArtikelAmount;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button buttonRemove;
    }
}
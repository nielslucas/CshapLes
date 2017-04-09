using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApplication
{
    public partial class SupplierForm : Form
    {
        Supplier ExistingSupplier;

        public SupplierForm()
        {
            InitializeComponent();
            fillListViewSupplier();
            lvSupllier.FullRowSelect = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (ExistingSupplier == null)
            {
                //Define variables
                string SupplierName = tbName.Text;

                //Create new category object
                Supplier NewSupplier = new Supplier(SupplierName);

                //Add object to the database
                Program.db.Suppliers.Add(NewSupplier);

            }
            else
            {
                ExistingSupplier.Name = tbName.Text;
            }

            //Save database changes
            Program.db.SaveChanges();

            ExistingSupplier = null;

            //Clear textbox
            tbName.Clear();

            //Update listView
            fillListViewSupplier();
        }

        private void fillListViewSupplier()
        {
            //Clear list
            lvSupllier.Items.Clear();

            foreach (Supplier supplier in Program.db.Suppliers)
            {
                //Create string array
                string[] Supplier = {
                    supplier.Name };

                //Create ListViewItem
                ListViewItem item = new ListViewItem(Supplier);

                //Set key value
                item.Name = supplier.ID.ToString();

                //Add item to ListView
                lvSupllier.Items.Add(item);
            }

        }

        private void lvSupllier_DoubleClick(object sender, EventArgs e)
        {
            //Get the id from the double clicked item
            int supllierID = int.Parse(lvSupllier.SelectedItems[0].Name);

            //Find and add the category to the object
            ExistingSupplier = Program.db.Suppliers.Find(supllierID);

            //Fill the textbox with the name so it can be changed
            tbName.Text = ExistingSupplier.Name;
        }
    }
}

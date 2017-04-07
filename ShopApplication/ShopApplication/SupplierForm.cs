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
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Name = tbName.Text;

            Supplier supplier = new Supplier(Name);
        }
    }
}

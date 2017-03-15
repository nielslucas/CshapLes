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
    public partial class CustomerRegistration : Form
    {

        ShopEntities db;
        public CustomerRegistration(ShopEntities db)
        {
            InitializeComponent();
            this.db = db;
            
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Customer tempCustomer = new Customer();
            tempCustomer.Name = tbName.Text;
            tempCustomer.Email = tbEmail.Text;
            tempCustomer.Street = tbStreet.Text;

            db.Customers.Add(tempCustomer);
            db.SaveChanges();

            ToOverview();

        }

        private void ToOverview()
        {
            Close();
            //Overview form = new Overview(db);
            //form.Show();
        }
    }
}

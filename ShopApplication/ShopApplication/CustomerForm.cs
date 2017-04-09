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
    public partial class CustomerForm : Form
    {
        Customer ExistingCustomer;

        public CustomerForm()
        {
            InitializeComponent();
            fillListViewCustomer();
            lvCustomer.FullRowSelect = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                //reference to textboxes
                string name = tbName.Text;
                string email = tbEmail.Text;
                string street = tbStreet.Text;
                int housenumber = int.Parse(tbHouseNumber.Text);
                string postcode = tbPostcode.Text;
                string place = tbPlace.Text;
                string land = tbLand.Text;
                int phonenumber = int.Parse(tbPhoneNumber.Text);

                if (ExistingCustomer == null)
                {
                    //create new customer
                    Customer NewCustomer = new Customer(name, email, street, housenumber, postcode, place, land, phonenumber);

                    //add to database
                    Program.db.Customers.Add(NewCustomer);

                } else
                {
                    //update customer
                    ExistingCustomer.Name = name;
                    ExistingCustomer.Email = email;
                    ExistingCustomer.Street = street;
                    ExistingCustomer.HouseNumber = housenumber;
                    ExistingCustomer.Postcode = postcode;
                    ExistingCustomer.Place = place;
                    ExistingCustomer.Land = land;
                    ExistingCustomer.PhoneNumber = phonenumber;
                    //empty object
                    ExistingCustomer = null;

                    //clear textfields
                    tbName.Clear();
                    tbEmail.Clear();
                    tbStreet.Clear();
                    tbHouseNumber.Clear();
                    tbPostcode.Clear();
                    tbPlace.Clear();
                    tbLand.Clear();
                    tbPhoneNumber.Clear();

                    
                }

                //save changes
                Program.db.SaveChanges();

                //refresh ListView
                fillListViewCustomer();

            } catch
            {
                MessageBox.Show("something went wrong");
            }
        }

        private void fillListViewCustomer()
        {
            //Clear list
            lvCustomer.Items.Clear();

            foreach (Customer customer in Program.db.Customers)
            {
                //Create string array
                string[] Customer = {
                    customer.Name,
                    customer.Email,
                    customer.Street,
                    customer.HouseNumber.ToString(),
                    customer.Postcode,
                    customer.Place,
                    customer.Land,
                    customer.PhoneNumber.ToString()
                };

                //Create ListViewItem
                ListViewItem item = new ListViewItem(Customer);

                //Set key value
                item.Name = customer.ID.ToString();

                //MessageBox.Show(item.Name);

                //Add item to ListView
                lvCustomer.Items.Add(item);
            }

        }

        private void lvCustomer_DoubleClick(object sender, EventArgs e)
        {
            //Get the id from the double clicked item
            int customerID = int.Parse(lvCustomer.SelectedItems[0].Name);

            //Find and add the category to the object
            ExistingCustomer = Program.db.Customers.Find(customerID);

            //Fill the textbox with the name so it can be changed
            tbName.Text         = ExistingCustomer.Name;
            tbEmail.Text        = ExistingCustomer.Email;
            tbStreet.Text       = ExistingCustomer.Street;
            tbHouseNumber.Text  = ExistingCustomer.HouseNumber.ToString();
            tbPostcode.Text     = ExistingCustomer.Postcode;
            tbPlace.Text        = ExistingCustomer.Place;
            tbLand.Text         = ExistingCustomer.Land;
            tbPhoneNumber.Text  = ExistingCustomer.PhoneNumber.ToString();
        }
    }
}

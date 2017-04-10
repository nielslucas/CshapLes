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
    public partial class OrderForm : Form
    {
        Order Order;

        public OrderForm()
        {
            InitializeComponent();
            fillListViewCustomer();
            lvCustomers.FullRowSelect = true;
            lvOrderDetails.FullRowSelect = true;
            lvArtikels.FullRowSelect = true;
            ArtikelAmount.Text = "1";
        }

        public void fillListViewCustomer()
        {
            //Clear list
            lvCustomers.Items.Clear();

            foreach (Customer customer in Program.db.Customers)
            {
                //Create string array
                string[] Customer = {
                    customer.Name,
                };

                //Create ListViewItem
                ListViewItem item = new ListViewItem(Customer);

                //Set key value
                item.Name = customer.ID.ToString();

                //Add item to ListView
                lvCustomers.Items.Add(item);
            }
        }

        public void fillListViewOrder()
        {
            //clear listview
            lvOrders.Items.Clear();

            //get customer id
            int customerID = int.Parse(lvCustomers.SelectedItems[0].Name);

            //get the customer from the id
            Customer customer = Program.db.Customers.Find(customerID);

            //get all order from the customer
            foreach (Order order in customer.Orders)
            {
                //Create string array
                string[] Order = {
                    order.ID.ToString()
                };

                //Create ListViewItem
                ListViewItem item = new ListViewItem(Order);

                //Set key value
                item.Name = order.ID.ToString();

                //Add item to ListView
                lvOrders.Items.Add(item);
            }
        }

        private void lvCustomers_DoubleClick(object sender, EventArgs e)
        {
            fillListViewOrder();
            lvOrderDetails.Items.Clear();
            lvArtikels.Items.Clear();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            try 
            {
                //get customer id
                int customerID = int.Parse(lvCustomers.SelectedItems[0].Name);

                //get the customer from the id
                Customer customer = Program.db.Customers.Find(customerID);

                //create new order
                Order NewOrder = new Order();

                //add new order
                customer.Orders.Add(NewOrder);

                //Save database
                Program.db.SaveChanges();

                //refresh the listview
                fillListViewOrder();

            } catch
            {
                MessageBox.Show("Please select a customer first");
            }
        }

        private void lvOrders_DoubleClick(object sender, EventArgs e)
        {
            //Fill listview artikels
            artikelsList();

            //clear listview
            lvOrderDetails.Items.Clear();

            //get order id
            int orderID = int.Parse(lvOrders.SelectedItems[0].Name);

            //remember this order
            this.Order = Program.db.Orders.Find(orderID);

            foreach (Artikel_Order artikel_order in Order.Artikel_Order)
            {
                Artikel OrderArtikel = artikel_order.Artikel;
                
                //Create string array
                string[] Artikel = {
                    OrderArtikel.Name,
                    OrderArtikel.Description,
                    OrderArtikel.Price.ToString(),
                    artikel_order.Amount.ToString(),
                    artikel_order.Price.ToString()

                };

                //Create ListViewItem
                ListViewItem item = new ListViewItem(Artikel);

                //Set key value
                item.Name = OrderArtikel.ID.ToString();

                //Add item to ListView
                lvOrderDetails.Items.Add(item);

            }

        }

        private void artikelsList()
        {
            //clear list if it needs to be refreshed
            lvArtikels.Items.Clear();

            //fill list
            foreach (Artikel artikel in Program.db.Artikels)
            {
                string ArtikelCategoryText = "";

                foreach (Category ArtikelCategory in artikel.Categories)
                {
                    if (ArtikelCategoryText.Length == 0)
                        ArtikelCategoryText = ArtikelCategory.Name;
                    else
                        ArtikelCategoryText = ArtikelCategoryText + ", " + ArtikelCategory.Name;
                };

                //MessageBox.Show(ArtikelCategoryText);

                string[] TempArtikel = {
                    artikel.Name,
                    artikel.Description,
                    artikel.Price.ToString(),
                    artikel.Storage.ToString(),
                    ArtikelCategoryText
            };

                //creating a Item for the ListView
                ListViewItem artikelItem = new ListViewItem(TempArtikel);

                //'artikelItem.Name' is the key value
                artikelItem.Name = artikel.ID.ToString();

                //Add the item the the ListView
                lvArtikels.Items.Add(artikelItem);
            }
        }

        private void lvArtikels_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //define so it wont give errors
                int amount = 00;
                decimal total = 00;

                //get artikel by id
                int artikelID = int.Parse(lvArtikels.SelectedItems[0].Name);
                Artikel artikel = Program.db.Artikels.Find(artikelID);

                try
                {
                    int stockLeft = (int)artikel.Storage - int.Parse(ArtikelAmount.Text);

                    if (stockLeft >= 0)
                    {
                        amount = int.Parse(ArtikelAmount.Text);
                        total = (decimal)artikel.Price * amount;
                        artikel.Storage = artikel.Storage - amount;

                        //create new match from artikelID and the Order.ID
                        Artikel_Order artikelOrder = new Artikel_Order
                        {
                            ArtikelID = artikelID,
                            OrderID = Order.ID,
                            Amount = int.Parse(ArtikelAmount.Text),
                            Price = total
                        };

                        //now insert it to database
                        Order.Artikel_Order.Add(artikelOrder);

                        //save database
                        Program.db.SaveChanges();

                        ////////////////////

                        //clear items
                        lvOrderDetails.Items.Clear();

                        foreach (Artikel_Order artikel_order in Order.Artikel_Order)
                        {
                            Artikel OrderArtikel = artikel_order.Artikel;

                            //Create string array
                            string[] Artikel = {
                                OrderArtikel.Name,
                                OrderArtikel.Description,
                                OrderArtikel.Price.ToString(),
                                artikel_order.Amount.ToString(),
                                artikel_order.Price.ToString()

                            };

                            //Create ListViewItem
                            ListViewItem item = new ListViewItem(Artikel);

                            //Set key value
                            item.Name = OrderArtikel.ID.ToString();

                            //Add item to ListView
                            lvOrderDetails.Items.Add(item);

                        }

                        //refresh artikel list so the amount will be refreshed
                        artikelsList();

                    } else
                    {
                        MessageBox.Show("Not enough stock");
                    }
                        
                } catch
                {
                    MessageBox.Show("Please enter a number/decimal in the textbox");
                }

            } catch
            {
                MessageBox.Show("You cant have 2 of the same artikels, please delete the previous one and add a new one with the correct amount");
            }

            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //get id from selected Artikel
            int id = int.Parse(lvOrderDetails.SelectedItems[0].Name);

            //create the Artikel_Order object that would match the needed removed object
            Artikel_Order RemoveArtikelOrder = (Artikel_Order)Program.db.Artikel_Order
                                                .Where(b => b.ArtikelID == id)
                                                .Where(b => b.OrderID == Order.ID)
                                                .First();

            //now remove this object from database
            Order.Artikel_Order.Remove(RemoveArtikelOrder);

            //save database
            Program.db.SaveChanges();

            //refresh listview

            //clear listview
            lvOrderDetails.Items.Clear();

            //remember this order

            foreach (Artikel_Order artikel_order in Order.Artikel_Order)
            {
                Artikel OrderArtikel = artikel_order.Artikel;

                //Create string array
                string[] Artikel = {
                    OrderArtikel.Name,
                    OrderArtikel.Description,
                    OrderArtikel.Price.ToString(),
                    artikel_order.Amount.ToString(),
                    artikel_order.Price.ToString()

                };

                //Create ListViewItem
                ListViewItem item = new ListViewItem(Artikel);

                //Set key value
                item.Name = OrderArtikel.ID.ToString();

                //Add item to ListView
                lvOrderDetails.Items.Add(item);

            }


        }
        //end function

    }//end class

}//end namespace

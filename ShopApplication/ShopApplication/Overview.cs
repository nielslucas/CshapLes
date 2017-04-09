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

    public partial class Overview : Form
    {

        public Overview()
        {
            InitializeComponent();

            //fill listview with all artikels
            artikelsList();

            //make sure you can select full row
            lvArtikels.FullRowSelect = true;

            //fill dropdown category
            fillComboListCategory();
        }

        private void Overview_Load(object sender, EventArgs e)
        {

        }

        private void lvArtikels_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        public void fillComboListCategory()
        {
            Dictionary<int, string> categorys = new Dictionary<int, string>();

            foreach (Category category in Program.db.Categories)
            {
                categorys.Add(category.ID, category.Name);
            }

            cbCategory.DataSource = new BindingSource(categorys, null);
            cbCategory.ValueMember = "Key";
            cbCategory.DisplayMember = "Value";
        }

        private void addArtikel_Click(object sender, EventArgs e)
        {
            if(lvArtikels.SelectedItems.Count < 1)
            {
                ArtikelForm form = new ArtikelForm();
                form.Show();
            } else
            {
                int artikelID = int.Parse(lvArtikels.SelectedItems[0].Name);

                Artikel artikel = Program.db.Artikels.Find(artikelID);

                ArtikelForm form = new ArtikelForm(artikel);
                form.Show();
            }
        }

        private void Overview_Activated(object sender, EventArgs e)
        {
            artikelsList();
        }

        private void buttonCategorie_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.Show();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm form = new SupplierForm();
            form.Show();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.Show();
        }

        private void buttonSearchCategory_Click(object sender, EventArgs e)
        {

            //get category
            Category categoryList = Program.db.Categories.Find(cbCategory.SelectedValue);

            //clear list if it needs to be refreshed
            lvArtikels.Items.Clear();

            //fill list
            foreach (Artikel artikel in categoryList.Artikels)
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            artikelsList();
        }

        private void buttonSearchTextbox_Click(object sender, EventArgs e)
        {
            //clear list if it needs to be refreshed
            lvArtikels.Items.Clear();

            //fill list
            foreach (Artikel artikel in Program.db.Artikels.Where(db => db.Name.Contains(tbSearch.Text)))
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
    }
}

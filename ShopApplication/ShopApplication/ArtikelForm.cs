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
    public partial class ArtikelForm : Form
    {
        Artikel artikel;
        int artikelID;

        public ArtikelForm()
        {
            InitializeComponent();

            fillComboBoxCategory();
        }

        public ArtikelForm(Artikel artikel)
        {
            InitializeComponent();
            this.artikel = artikel;
            artikelID = artikel.ID;

            tbArticalName.Text = artikel.Name;
            tbDescription.Text = artikel.Description;
            tbPrice.Text = artikel.Price.ToString();
            tbStock.Text = artikel.Storage.ToString();
            fillComboBoxCategory();
        }

        private void CreateArtikel_Click(object sender, EventArgs e)
        {

            try
            {
                if (artikel == null)
                {
                    Artikel tempArtikel = new Artikel(
                        tbArticalName.Text,
                        tbDescription.Text,
                        decimal.Parse(tbPrice.Text),
                        int.Parse(tbStock.Text)
                    );

                    //Add Artikel to database
                    Program.db.Artikels.Add(tempArtikel);

                    //find the category to attach
                    Category categoryAttach = Program.db.Categories.Find(cbCategory.SelectedValue);

                    //now attach the artikel to category
                    categoryAttach.Artikels.Add(tempArtikel);
                    
                    //Save database
                    Program.db.SaveChanges();
                }
                else
                {
                    //Artikel artikel = db.Artikels.Find(artikelID);
                    artikel.Name = tbArticalName.Text;
                    artikel.Description = tbDescription.Text;
                    artikel.Price = decimal.Parse(tbPrice.Text);
                    artikel.Storage = int.Parse(tbStock.Text);

                    //find the category to attach
                    Category categoryAttach = Program.db.Categories.Find(cbCategory.SelectedValue);

                    //now attach the category to artikel
                    artikel.Categories.Add(categoryAttach);

                    //Save database
                    Program.db.SaveChanges();
                }

                Close();
            } catch
            {
                MessageBox.Show("Someting went wrong");
            }

            

        }

        private void fillComboBoxCategory()
        {
            Dictionary<int, string> categorys = new Dictionary<int, string>();

            foreach(Category category in Program.db.Categories)
            {
                categorys.Add(category.ID, category.Name);
            }

            cbCategory.DataSource = new BindingSource(categorys, null);
            cbCategory.ValueMember = "Key";
            cbCategory.DisplayMember = "Value";
        }
    }
}

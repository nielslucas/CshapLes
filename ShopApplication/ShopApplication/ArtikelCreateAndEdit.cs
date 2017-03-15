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
    public partial class ArtikelCreateAndEdit : Form
    {
        ShopEntities db;
        Artikel artikel;
        int artikelID;

        public ArtikelCreateAndEdit(ShopEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        public ArtikelCreateAndEdit(ShopEntities db, Artikel artikel, int artikelID)
        {
            InitializeComponent();
            this.db = db;
            this.artikel = artikel;
            this.artikelID = artikelID;

            tbArticalName.Text = artikel.Name;
            tbDescription.Text = artikel.Description;
            tbPrice.Text = artikel.Price.ToString();
            tbStock.Text = artikel.Storage.ToString();
        }

        private void CreateArtikel_Click(object sender, EventArgs e)
        {
            if(artikel == null)
            {
                Artikel tempArtikel = new Artikel(
                    tbArticalName.Text,
                    tbDescription.Text,
                    decimal.Parse(tbPrice.Text),
                    int.Parse(tbStock.Text)
                );
                db.Artikels.Add(tempArtikel);
            } else
            {
                Artikel artikel = db.Artikels.Find(artikelID);
                artikel.Name = tbArticalName.Text;
                artikel.Description = tbDescription.Text;
                artikel.Price = decimal.Parse(tbPrice.Text);
                artikel.Storage = int.Parse(tbStock.Text);
                db.SaveChanges();
            }
            //Save database
            db.SaveChanges();

            Close();

        }
    }
}

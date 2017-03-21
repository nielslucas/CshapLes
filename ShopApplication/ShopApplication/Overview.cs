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

            artikelsList();
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
                string[] TempArtikel = {
                    artikel.Name,
                    artikel.Description,
                    artikel.Price.ToString(),
                    artikel.Storage.ToString()
                };

                //creating a Item for the ListView
                ListViewItem artikelItem = new ListViewItem(TempArtikel);

                //'artikelItem.Name' is the key value
                artikelItem.Name = artikel.ID.ToString();

                //Add the item the the ListView
                lvArtikels.Items.Add(artikelItem);
            }
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

        }
    }
}

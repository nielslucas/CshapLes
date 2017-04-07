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
    public partial class CategoryForm : Form
    {
        Category ExistingCategory;

        public CategoryForm()
        {
            InitializeComponent();
            //
            fillListViewCategory();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(ExistingCategory == null)
            {
                //Define variables
                string CategoryName = tbName.Text;

                //Create new category object
                Category newCategoty = new Category(CategoryName);

                //Add object to the database
                Program.db.Categories.Add(newCategoty);
                
            } else
            {
                ExistingCategory.Name = tbName.Text;
            }

            //Save database changes
            Program.db.SaveChanges();

            ExistingCategory = null;

            //Clear textbox
            tbName.Clear();

            //Update listView
            fillListViewCategory();

        }

        private void fillListViewCategory()
        {
            //Clear list
            lvCategory.Items.Clear();

            foreach(Category category in Program.db.Categories)
            {
                //Create string array
                string[] Category = {
                    category.Name };

                //Create ListViewItem
                ListViewItem item = new ListViewItem(Category);

                //Set key value
                item.Name = category.ID.ToString();

                //MessageBox.Show(item.Name);

                //Add item to ListView
                lvCategory.Items.Add(item);
            }

        }

        private void lvCategory_DoubleClick(object sender, EventArgs e)
        {
            //Get the id from the double clicked item
            int categoryID = int.Parse(lvCategory.SelectedItems[0].Name);

            //Find and add the category to the object
            ExistingCategory = Program.db.Categories.Find(categoryID);

            //Fill the textbox with the name so it can be changed
            tbName.Text = ExistingCategory.Name;
        }
    }
}

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
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Define variables
            string CategoryName = tbName.Text;

            //Create new category object
            Category newCategoty = new Category(CategoryName);

            //Add object to the database
            Program.db.Categories.Add(newCategoty);

            //Save database changes
            Program.db.SaveChanges();

            //Clear textbox
            tbName.Clear();
        }
    }
}

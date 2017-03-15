using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationCreatingCars
{
    public partial class Form1 : Form
    {

        class list
        {

        }

        int width = 5;
        int height = 60;

        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void start_Click(object sender, EventArgs e)
        {
            //create a new list
            List<string> MyList = new List<string>();

            //add items to the list
            for (int i = 1; i < 10; i++)
            {
                MyList.Add("List 1: " + i.ToString());
            }

            ListBox nieuweListBox = new ListBox();

            nieuweListBox.DataSource = MyList;
            nieuweListBox.Location = new Point(width, height);

            //get screen with
            int Screenwith = this.Width;
            //set max with
            width = width + 130;
            if (width > Screenwith)
            {
                height = height + 150;
                width = 5;
            } 

            label1.Text = width.ToString();
            label1.Text += "  ";
            label1.Text += Screenwith;

            Controls.Add(nieuweListBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
}

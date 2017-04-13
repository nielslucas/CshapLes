using System;
using Xamarin.Forms;

namespace TestCrossPlatForm
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        void GenerateTokenButton(object sender, EventArgs e)
        {
            string _privateNumber = PrivateNumber.Text.ToString();

            Token.Text = _privateNumber;

        }
    }
}
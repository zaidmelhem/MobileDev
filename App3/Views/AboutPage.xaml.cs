using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
         private void Button_Clicked(object sender, EventArgs e)
        {
            for (int i = 1990; i <= 2030; i++)
            {
                label.Text += i.ToString() + Environment.NewLine;
            }
        }
    }
}


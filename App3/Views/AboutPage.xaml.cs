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
            if (label.Text == null)
            {
                for (int i = 1990; i <= 2030; i++)
                {
                    label.Text += i.ToString() + Environment.NewLine;
                }
            }
             
            Button_1.IsEnabled = false;
            label.IsVisible = true;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            label.IsVisible = false;
            Button_1.IsEnabled = true;
            
        }
    }
}


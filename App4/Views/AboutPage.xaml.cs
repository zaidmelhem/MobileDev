using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MyWebView.Source = "https://zajel.najah.edu/";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MyWebView.Source = "https://www.google.com/";
        }
    }
}
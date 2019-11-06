using System;
using System.IO;
using Xamarin.Forms;

namespace TaskOne
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();
            Config config = new Config();
            if (File.Exists(config.GetFileChangesNameTitle()))
            {
                this.Title = File.ReadAllText(config.GetFileChangesNameTitle());
            }
            else
            {
                this.Title = "Main title";
            }
        }

        async void OnNextPageTwoButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTwo { Title = "Page 2" });
        }

        async void OnNextPageThreeButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageThree { Title = "Page 3" });
        }
    }
}

using System;
using Xamarin.Forms;

namespace TaskOne
{
    public partial class MainPage : ContentPage
    {   
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new PageManager { };
        }

        public void SetTitle(string titleName)
        {
            this.Title = titleName;
        }

        async void OnNextPageTwoButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTwo ());
        }

        async void OnNextPageThreeButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageThree ());
        }
    }
}

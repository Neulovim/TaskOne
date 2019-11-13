using System;
using Xamarin.Forms;

namespace TaskOne
{
    public partial class PageTwo : ContentPage
    {
        FileManager fileManager;

        public PageTwo()
        {            
            InitializeComponent();            
        }
        
        void OnSaveButtonClicked(object sender, EventArgs e)
        {            
            string msg = "Name: \"" + editor.Text + "\". " + "Time: " + DateTime.Now.ToString("u") + "\n";
            fileManager = new FileManager();
            fileManager.WriteFileLog(msg);
            GoNewMainPage();            
        }   
        
        async void GoNewMainPage()
        {
            App.Current.MainPage = new NavigationPage(new MainPage { Title = editor.Text });
            await Navigation.PopAsync();
        }
    }
}
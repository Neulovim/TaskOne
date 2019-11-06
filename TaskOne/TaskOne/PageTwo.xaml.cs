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
        
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {            
            string msg = "Name title: \"" + editor.Text + "\" \n" +
                         "Time changes: " + DateTime.Now.ToString("u") + "\n\n";
            fileManager = new FileManager();
            fileManager.WriteFileLog(msg);
            App.Current.MainPage = new NavigationPage(new MainPage { Title = editor.Text });
            await Navigation.PopToRootAsync();
        }         
    }
}
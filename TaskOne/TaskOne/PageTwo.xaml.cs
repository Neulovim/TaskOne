using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskOne
{
    public partial class PageTwo : ContentPage
    {
        
        public PageTwo()
        {            
            InitializeComponent();            
        }

        

        void OnSaveButtonClicked(object sender, EventArgs e)
        {            
            string msg = "Name title: \"" + editor.Text + "\" \nTime changes: " + DateTime.Now.ToString("u") + "\n\n";
            Config config = new Config();
            if (File.Exists(config.GetFileNamesTitles()))
            {                
                File.AppendAllText(config.GetFileNamesTitles(), msg);
            }
            else
            {
                File.WriteAllText(config.GetFileNamesTitles(), msg);
            }
            File.WriteAllText(config.GetFileChangesNameTitle(), editor.Text);
            Navigation.InsertPageBefore(new MainPage { Title = editor.Text}, this);
            
        }

         

    }
}
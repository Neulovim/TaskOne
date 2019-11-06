using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskOne
{
    
    public partial class PageThree : ContentPage
    {
        public PageThree()
        {
            InitializeComponent();
            Config config = new Config();
            if (File.Exists(config.GetFileNamesTitles()))
            {
                labelChangesList.Text = File.ReadAllText(config.GetFileNamesTitles());
            }
            else
            {
                labelChangesList.Text = "No changes";
            }
        }
    }
}
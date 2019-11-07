using System.Collections.Generic;
using Xamarin.Forms;

namespace TaskOne
{
    public partial class PageThree : ContentPage
    {
        public IList<string> TextListView { get; private set; }
        FileManager fileManager;

        public PageThree()
        {
            InitializeComponent();
            ShowText();
        }

        private void ShowText()
        {
            fileManager = new FileManager();
            TextListView = fileManager.GetTextFileLog();
            BindingContext = this;
        }
    }
}
using Xamarin.Forms;

namespace TaskOne
{

    public partial class PageThree : ContentPage
    {
        FileManager fileManager;

        public PageThree()
        {
            InitializeComponent();
            fileManager = new FileManager();
            labelChangesList.Text = fileManager.SetTextFileLog();            
        }
    }
}
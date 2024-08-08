using HTTP.Views;

namespace HTTP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PostView();
        }
    }
}

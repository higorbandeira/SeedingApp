using AppSample.Views;
using Xamarin.Forms;

namespace AppSample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new StatusAtual();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

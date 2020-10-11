using AppSample.ViewModels;
using AppSample.Views;
using Xamarin.Forms;

namespace AppSample
{
    
    public partial class App : Application
    {
        public static LoginResponse MinhaString = null;

        public App()
        {
            InitializeComponent();
            MainPage = new Login();
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

using AppSample.Services;
using AppSample.ViewModels;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
	{
        public Login()
        {
            InitializeComponent();
            // Define o binding context
            this.BindingContext = this;
            // Define a propriedade
            this.IsBusy = false;
            //Define o evento Click do botão de login
            BtnLogin.Clicked += BtnLogin_Clicked;
        }

        //define a propriedade IsBusy como true
        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            LbError.Text = "";
            //ativa o ActivityIndicator
            this.IsBusy = true;

            string login = LbLogin.Text;
            string password = LbPassword.Text;

            // DEV CREDENTIALS
            //string login = "demo@gmail.com";
            //string password = "Test1234!";

            await DandoUmTempo(5000);

            LoginService service = new LoginService();
            string result = service.Login(login, password);

            if (!string.IsNullOrEmpty(result) && result == "Success")
            {
                Application.Current.MainPage = new NavigationPage(new StatusAtual());
            }
            else
            {
                LbError.Text = result;
            }

            this.IsBusy = false;
        }

        //Dá uma pausa de 5 segundos
        async Task DandoUmTempo(int valor)
        {
            await Task.Delay(valor);
        }

    }
}
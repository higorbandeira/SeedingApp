using AppSample.Models;
using AppSample.Services;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppSample.Views
{
	public partial class StatusAtual : ContentPage
	{
		public StatusAtual ()
		{            
            InitializeComponent ();
            dtAtual.Text = Convert.ToString(DateTime.Now);
            FarmStatusService farmStatusService = new FarmStatusService();
            List<MyArray> status = farmStatusService.GetAtualStatus();
            btnPH.Text += status[0].pH.value;
            btnTempSolo.Text += status[0].tempSolo.value + "°";
            btnTempAmb.Text += status[0].tempAmbiente.value + "°";
            btnLuminosidade.Text += status[0].luminosidade.value + "%";
            btnHumidSolo.Text += status[0].humidSolo.value + "%";
            btnHumidAmbiente.Text += status[0].humidAmbiente.value + "%";

            if(status[0].tempSolo.value > 15 || status[0].tempAmbiente.value > 15)
            {
                try
                {
                    var duration = TimeSpan.FromSeconds(2);
                    Vibration.Vibrate(duration);
                    btnTempSolo.BorderWidth = 1;
                    btnTempAmb.BorderColor = Color.Red;
                    btnTempSolo.BorderWidth = 1;
                    btnTempSolo.BorderColor = Color.Red;

                }
                catch (FeatureNotSupportedException ex)
                {
                    // Feature not supported on device
                }
            }

            BtnMap.Clicked += BtnMap_Clicked;
        }

        private async void BtnMap_Clicked(object sender, EventArgs e)
        {
            var location = new Location(-23.804085, -46.534852);
            var options = new MapLaunchOptions { Name = "Localização do Equipamento" };

            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception ex)
            {
                // No map application available to open
            }
        }

    }
}
using AppSample.Models;
using AppSample.Services;
using System;
using System.Collections.Generic;
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
            btnTempSolo.Text += status[0].tempSolo.value;
            btnTempAmb.Text += status[0].tempAmbiente.value;
            btnLuminosidade.Text += status[0].luminosidade.value;
            btnHumidSolo.Text += status[0].humidSolo.value;
            btnHumidAmbiente.Text += status[0].humidAmbiente.value;
        }
        
    }
}
namespace aplicativoHotel.Views;

public partial class contratacaoDaHospedagem : ContentPage
{
	App PropriedadesApp;



	public contratacaoDaHospedagem()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkout.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month +1, DateTime.Now.Day);
		dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkin.Date.Date.AddMonths(6);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try {

			Navigation.PushAsync(new hospedagemContratada());//permite trocar de tela
		
		}catch(Exception ex)
		{

			DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;
		DateTime data_selecionada_checkin = elemento.Date;
		dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.Date.AddMonths(6);

    }
}
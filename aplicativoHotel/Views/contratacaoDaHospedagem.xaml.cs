namespace aplicativoHotel.Views;

public partial class contratacaoDaHospedagem : ContentPage
{
	public contratacaoDaHospedagem()
	{
		InitializeComponent();
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
}
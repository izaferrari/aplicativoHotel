namespace aplicativoHotel.Views;

public partial class hospedagemContratada : ContentPage
{
	public hospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            Navigation.PopAsync(); //permite trocar de tela (voltando)

        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
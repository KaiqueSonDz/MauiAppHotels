namespace MauiAppHotels.View;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ContratacaoHospedagem());
    }
}
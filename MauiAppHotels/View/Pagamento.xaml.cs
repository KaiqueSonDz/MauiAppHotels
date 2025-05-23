namespace MauiAppHotels.View;

public partial class Pagamento : ContentPage
{
	public Pagamento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ContratacaoHospedagem());
    }
}
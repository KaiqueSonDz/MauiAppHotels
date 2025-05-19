namespace MauiAppHotels.View;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropApp;
        
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropApp = (App)App.Current;
        pck_quarto.ItemsSource = PropApp.lista_quarto;

        dtpck_checkin.MinimumDate = DateTime.Now;        
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month +1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Sobre();
    }
    //botao sobre

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {

            Navigation.PushAsync(new HospedagemContratada());

        }
        catch (Exception ex)
        {

            DisplayAlert("Ops", ex.Message, "OK");

        }
    }//botao avançar

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {

        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);

    }

    
}//fecha classe
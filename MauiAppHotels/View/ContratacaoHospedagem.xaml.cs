using MauiAppHotels.Models;

namespace MauiAppHotels.View;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropApp;
        
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropApp = (App)Application.Current;
        pck_quarto.ItemsSource = PropApp.lista_quarto;

        dtpck_checkin.MinimumDate = DateTime.Now;        
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month +1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            await Navigation.PushAsync(new Sobre());

        }
        catch (Exception ex)
        {

           await DisplayAlert("Ops", ex.Message, "OK");

        }
    }

    //botao sobre

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {

            Hospedagem h = new Hospedagem
            {

                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                QntAdultos = Convert.ToInt32(stp_adulto.Value),
                QntCriancas = Convert.ToInt32(stp_crianca.Value),
                DataCheckIn = dtpck_checkin.Date,
                DataCheckOut = dtpck_checkout.Date,

            };

            await Navigation.PushAsync(new HospedagemContratada()
            {

                BindingContext = h

            });

        }
        catch (Exception ex)
        {

            await DisplayAlert("Ops", ex.Message, "OK");

        }
    }//botao avançar

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {

        DatePicker elemento = sender as DatePicker;
        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);

    }// innfos do date picker

    
}//fecha classe
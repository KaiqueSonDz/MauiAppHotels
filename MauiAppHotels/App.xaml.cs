
using MauiAppHotels.Models;

namespace MauiAppHotels
{
    public partial class App : Application
    {

        public List<Quarto> lista_quarto = new List<Quarto>
        {

            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 350.0,
                ValorDiariaCrianca = 150.0
            },

            new Quarto()
            {
                Descricao = "Suite Basica",
                ValorDiariaAdulto = 40.0,
                ValorDiariaCrianca = 25.0
            },

            new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 35.0
                
            },

            new Quarto()
            {
                Descricao = "Suite Classica",
                ValorDiariaAdulto = 45.0,
                ValorDiariaCrianca = 30.0
            },

            new Quarto()
            {
                Descricao = "Suite Formal",
                ValorDiariaAdulto = 300.0,
                ValorDiariaCrianca = 100.0
            },

        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;
            return window;
        }
    }
}

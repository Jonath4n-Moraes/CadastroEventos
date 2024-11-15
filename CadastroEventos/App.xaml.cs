
using CadastroEventos.Models;

namespace CadastroEventos
{
    public partial class App : Application
    {

        public List<Evento> lista_eventos = new List<Evento>
        {
            new Evento()
            {
                descricao = "Aniversário Adulto",
                valorAdulto = 40.00,
                valorCrianca = 20.00,
                buffetAdulto = 90.00,
                buffetCrianca = 45.00,
                decoracao = 2000.00
            }, 
            new Evento()
            {
                descricao = "Aniversário Crinaça",
                valorAdulto = 30.00,
                valorCrianca = 20.00,
                buffetAdulto = 80.00,
                buffetCrianca = 40.00,
                decoracao = 2300.00
            },
            new Evento()
            {
                descricao = "Bodas",
                valorAdulto = 60.00,
                valorCrianca = 30.00,
                buffetAdulto = 120.00,
                buffetCrianca = 60.00,
                decoracao = 3000.00
            },
            new Evento()
            {
                descricao = "Casamento",
                valorAdulto = 80.00,
                valorCrianca = 40.00,
                buffetAdulto = 150.00,
                buffetCrianca = 75.00,
                decoracao = 7500.00
            }

        };


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 750;

            return window;
        }


    }
}

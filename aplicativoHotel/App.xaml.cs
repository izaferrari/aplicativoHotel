
using aplicativoHotel.Models;

namespace aplicativoHotel
{
    public partial class App : Application
    {
         public List<Quarto> lista_quartos = new List<Quarto>
         {
             new Quarto()
             {

                 Descricao= "Suite Luxo",
                 ValorDiariaAdulto = 110.0,
                 ValorDiariaCrianca = 55.0
             },
               new Quarto()
             {

                 Descricao= "Suite Single",
                 ValorDiariaAdulto = 114.0,
                 ValorDiariaCrianca = .0
             },
               new Quarto()
             {

                 Descricao= "Suite Crise",
                 ValorDiariaAdulto = 25,
                 ValorDiariaCrianca = 12
             }


         };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.contratacaoDaHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }

}

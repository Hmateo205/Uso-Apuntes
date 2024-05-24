using Uso_Apuntes.Paginas.Flyouts;

namespace Uso_Apuntes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pagina_Flyout();
        }
    }
}

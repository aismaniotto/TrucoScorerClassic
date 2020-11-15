using TrucoScorerClassic.Presentation.Pages;
using Xamarin.Forms;

namespace TrucoScorerClassic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ScorerPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

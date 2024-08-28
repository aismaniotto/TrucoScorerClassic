using TrucoScorerClassic.Presentation.Pages;

namespace TrucoScorerClassic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ScorerPage();
        }
    }
}

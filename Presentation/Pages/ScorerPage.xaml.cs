using TrucoScorerClassic.ViewModels;

namespace TrucoScorerClassic.Presentation.Pages
{
    public partial class ScorerPage : ContentPage
    {
        public ScorerPage()
        {
            InitializeComponent();
            BindingContext = new ScorerViewModel();
        }
    }
}

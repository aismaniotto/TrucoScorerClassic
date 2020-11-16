using TrucoScorerClassic.ViewModels;
using Xamarin.Forms;

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

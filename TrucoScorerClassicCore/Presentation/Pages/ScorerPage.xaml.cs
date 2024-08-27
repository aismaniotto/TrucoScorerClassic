using TrucoScorerClassic.ViewModels;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

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

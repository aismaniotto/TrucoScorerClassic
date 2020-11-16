using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace TrucoScorerClassic.ViewModels
{
    public class ScorerViewModel : BaseViewModel
    {
        public ICommand ClearCommand { get; set; }

        public int[] UsTotalScorer { get; }
        public int[] UsTotalPoints{ get; }

        public int UsScorer
        {
            get { return Preferences.Get(nameof(UsScorer), 0); }
            set
            {
                Preferences.Set(nameof(UsScorer), value);
                OnPropertyChanged(nameof(UsScorer));
            }
        }

        public int UsPoints
        {
            get { return Preferences.Get(nameof(UsPoints), 0); }
            set
            {
                Preferences.Set(nameof(UsPoints), value);
                OnPropertyChanged(nameof(UsPoints));
            }
        }


        public int[] TheyTotalScorer { get; }
        public int[] TheyTotalPoints { get; }

        public int TheyScorer
        {
            get { return Preferences.Get(nameof(TheyScorer), 0); }
            set
            {
                Preferences.Set(nameof(TheyScorer), value);
                OnPropertyChanged(nameof(TheyScorer));
            }
        }

        public int TheyPoints
        {
            get { return Preferences.Get(nameof(TheyPoints), 0); }
            set
            {
                Preferences.Set(nameof(TheyPoints), value);
                OnPropertyChanged(nameof(TheyPoints));
            }
        }

        public ScorerViewModel()
        {
            UsTotalScorer = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            UsTotalPoints = new[] { 0, 1, 2, 3 };
            TheyTotalScorer = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            TheyTotalPoints = new[] { 0, 1, 2, 3 };
            ClearCommand = new Command(ClearCommandAction);
        }

        public void ClearCommandAction()
        {
            UsScorer = 0;
            UsPoints = 0;
            TheyScorer = 0;
            TheyPoints= 0;
        }
    }
}

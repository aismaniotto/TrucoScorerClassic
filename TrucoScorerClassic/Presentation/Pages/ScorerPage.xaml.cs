using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TrucoScorerClassic.Presentation.Pages
{
    public partial class ScorerPage : ContentPage
    {
        public ScorerPage()
        {
            InitializeComponent();
            var scorerList1 = new [] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            var scorerList2 = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

            usScorer.ItemsSource = scorerList1; 
            theyScorer.ItemsSource = scorerList2;

            var pointsList1 = new[] { "0", "1", "2", "3" };
            var pointsList2 = new[] { "0", "1", "2", "3" };

            usPoints.ItemsSource = pointsList1;
            theyPoints.ItemsSource = pointsList1;
        }
    }
}

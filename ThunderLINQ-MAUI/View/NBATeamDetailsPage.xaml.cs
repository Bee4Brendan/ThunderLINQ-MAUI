using System.Collections.ObjectModel;
using ThunderLINQ_MAUI.Model;
using ThunderLINQ_MAUI.ViewModel;

namespace ThunderLINQ_MAUI
{
    public partial class NBATeamDetailsPage : ContentPage
    {
        public NBATeamDetailsPage(NBATeamDetailsViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
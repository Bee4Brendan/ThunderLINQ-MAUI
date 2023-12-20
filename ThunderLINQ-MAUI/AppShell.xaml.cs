namespace ThunderLINQ_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(NBATeamDetailsPage), typeof(NBATeamDetailsPage));
        }
    }
}
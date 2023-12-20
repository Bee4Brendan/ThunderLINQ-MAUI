using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ThunderLINQ_MAUI.Model;
using static ThunderLINQ_MAUI.Model.NBA_Team;

namespace ThunderLINQ_MAUI.ViewModel;

public partial class NBATeamDetailsViewModel : ObservableObject
{
    // Sorts the Players by Number
    public RelayCommand SortNumberCommand { get; }

    // Sorts the Players by Name
    public RelayCommand SortNameCommand {  get; }

    // Sorts the Players by Age
    public RelayCommand SortAgeCommand { get; }

    // Sorts the Players by Height
    public RelayCommand SortHeightCommand { get; }

    // Sorts the Players by Height
    public RelayCommand SortWeightCommand { get; }

    // Used to switch Age sorts between ascending and descending
    public bool IsAgeSortedDescending { get; set; }

    // Used to switch Height sorts between ascending and descending
    public bool IsHeightSortedDescending { get; set; }

    // Used to switch Weight sorts between ascending and descending
    public bool IsWeightSortedDescending { get; set; }

    // The Main Logic for the NBA Team Data View
    public NBATeamDetailsViewModel()
    {
        // Initialize the Team(s) with Name, Image, City, State, and Roster of Players
        NBA_Team Thunder = new(0, "Oklahoma City Thunder", "thunder.png" , Conference.Western);
        Thunder.DraftPlayers();
        Thunder.Wins = 17;
        Thunder.Losses = 8;

        // Set Current Team
        NBA_Team = Thunder;
        Roster = NBA_Team.Roster;
        Title = string.Format("  {0} {1} {2} ", NBA_Team.City, NBA_Team.Name, $"({NBA_Team.Wins}, {NBA_Team.Losses})");
        Logo = NBA_Team.Logo;

        // Button commands for sorting NBA Player's stats in ascending/descending
        SortHeightCommand = new RelayCommand(OnSortHeightCommand);
        SortWeightCommand = new RelayCommand(OnSortWeightCommand);
        SortNumberCommand = new RelayCommand(OnSortNumberCommand);
        SortNameCommand = new RelayCommand(OnSortNameCommand);
        SortAgeCommand = new RelayCommand(OnSortAgeCommand);
        IsAgeSortedDescending = false;
        IsHeightSortedDescending = false;
        IsWeightSortedDescending = false;
    }



    [ObservableProperty]
    NBA_Team nBA_Team = new();

    // The current NBA Team selected
    [ObservableProperty]
    ObservableCollection<NBA_Player> roster;

    // The current NBA Team's Name
    [ObservableProperty]
    string title;

    // The current NBA Team's Logo that will convert to Image
    [ObservableProperty]
    string logo;

    /**
     * Sorts the listed NBAPlayers by jersey Number
     **/
    void OnSortNumberCommand() 
    {
        IEnumerable<NBA_Player> temp = this.Roster;
        temp = temp.OrderBy(x => x.Number).ToList();

        this.Roster.Clear();

        if (temp != null)
        {
            foreach (NBA_Player item in temp) { this.Roster.Add(item); }
        }
    }

    /**
     * Sorts the listed NBAPlayers by Name
     **/
    void OnSortNameCommand() 
    {
        IEnumerable<NBA_Player> temp = this.Roster;
        temp = temp.OrderBy(x => x.Name).ToList();

        this.Roster.Clear();

        if (temp != null)
        {
            foreach (NBA_Player item in temp) { this.Roster.Add(item); }
        }
    }

    /**
     * Sorts the listed NBAPlayers by Age
     **/
    void OnSortAgeCommand() 
    {
        IEnumerable<NBA_Player> temp = this.Roster;
        if(IsAgeSortedDescending) temp = temp.OrderBy(x => x.DOB).ToList();
        else temp = temp.OrderByDescending(x => x.DOB).ToList();

        IsAgeSortedDescending = !IsAgeSortedDescending;

        this.Roster.Clear();

        if (temp != null)
        {
            foreach (NBA_Player item in temp) { this.Roster.Add(item); }
        }
    }

    /**
     * Sorts the listed NBAPlayers by Height
     **/
    void OnSortHeightCommand()
    {
        IEnumerable<NBA_Player> temp = this.Roster;
        if(IsHeightSortedDescending) temp = temp.OrderBy(x => x.GetRealHeight()).ToList();
        else temp = temp.OrderByDescending(x => x.GetRealHeight()).ToList();

        IsHeightSortedDescending = !IsHeightSortedDescending;

        this.Roster.Clear();

        if (temp != null)
        {
            foreach (NBA_Player item in temp) { this.Roster.Add(item); }
        }
    }

    /**
     * Sorts the listed NBAPlayers by Height
     **/
    void OnSortWeightCommand()
    {
        IEnumerable<NBA_Player> temp = this.Roster;
        if (IsWeightSortedDescending) temp = temp.OrderBy(x => x.GetWeight()).ToList();
        else temp = temp.OrderByDescending(x => x.GetWeight()).ToList();

        IsWeightSortedDescending = !IsWeightSortedDescending;

        this.Roster.Clear();

        if (temp != null)
        {
            foreach (NBA_Player item in temp) { this.Roster.Add(item); }
        }
    }
}

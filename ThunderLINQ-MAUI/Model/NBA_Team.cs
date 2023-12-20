using System.Collections.ObjectModel;

namespace ThunderLINQ_MAUI.Model
{
    /*
     * This is the Model for the NBA Team!
     */
    public class NBA_Team
    {
        // The NBA Team's ID property
        public int Id { get; set; }

        // The NBA Team's current amount of Wins in the season
        public int Wins {  get; set; }

        // The NBA Team's current amount of Losses in the season
        public int Losses {  get; set; }

        // The NBA Team's wins / losses
        public string WinPercentage { get; private set; }

        // The NBA Team's rank compared to other Team's Win Percentage in their conference
        public int Standing { get; private set; }

        // The Conference Enum
        public enum Conference { Eastern, Western }

        // The NBA Team's Conference
        public Conference Conf { get; set; }

        // The NBA Team's Logo property
        public string Logo { get; set; }

        // The NBA Team's Name property
        public string Name { get; set; }

        // The NBA Teams' City property
        public string City { get; set; }

        // The NBA Team's Roster Collection of NBAPlayers
        public ObservableCollection<NBA_Player> Roster { get; set; }

        // Default Constructor
        public NBA_Team() { Roster = new(); }

        // NBA Team's Constructor without a roster parameter
        public NBA_Team(int id, string name, string logo, Conference c)
        {
            Id = id;
            Name = name;
            Logo = logo;
            Roster = new();
            Conf = c;
        }

        // The NBA Team's Full Constructor 
        public NBA_Team(int id, string name, string city, Conference c, ObservableCollection<NBA_Player> roster)
        {
            Id = id;
            Name = name;
            City = city;
            Conf = c;
            Roster = new();
            Roster = roster;
        }

        /*
         * Adds the given NBAPlayer to the Team
         */
        public void AddPlayer(NBA_Player player)
        {
            Roster.Add(player);
        }

        /*
         * 
         */
        public string GetWinPercentage()
        {
            double temp = (double) this.Wins / (this.Wins + this.Losses);
            this.WinPercentage = temp.ToString("P1");
            return this.WinPercentage;
        }

        public void GetStanding()
        {

        }

        /*
         * Gets the Team's ID
         */
        public int GetID()
        {
            return this.Id;
        }

        /*
         * Sets the Team's ID
         */
        public void SetId(int id)
        {
            this.Id = id;
        }

        /*
         * Gets the Team's Name
         */
        public string GetName()
        {
            return this.Name;
        }

        /*
         * Sets the Team's Name
         */
        public void SetName(string name)
        {
            this.Name = name;
        }

        /*
         * Gets the Team's Logo Image
         */
        public string GetLogo()
        {
            return this.Logo;
        }

        /*
         * Sets the Team's Logo Image
         */
        public void SetLogo(string logo)
        {
            this.Logo = logo;
        }

        /*
         * Get's the Team's City
         */
        public string GetCity()
        {
            return this.City;
        }

        /*
         * Sets the Team's City
         */
        public void SetCity(string city)
        {
            this.City = city;
        }

        /*
         * This adds the given list of players to the Team
         */
        public void DraftPlayers(ObservableCollection<NBA_Player> players) 
        { 
            foreach(NBA_Player p in players)
            {
                this.Roster.Add(p);
            }
        }

        /*
         * This hardcodes the current Thunder roster
         */
        public void DraftPlayers()
        {
            // updated 11/22/2023
            this.Roster.Add(new NBA_Player("Shai Gilgeous-Alexander",    "shaigilgeousalexander.png" , "Kentucky", 2, NBA_Player.Position.PG, "6' 6\"", 195, 31.4, 5.5, 4.8, new DateTime(1998, 7, 12)));
            this.Roster.Add(new NBA_Player("Davis Bertans",              "davisbertans.png", "--", 9, NBA_Player.Position.SF, "6' 10\"", 225, 0.0, 0.0, 0.0, new DateTime(1992, 11, 12)));
            this.Roster.Add(new NBA_Player("Luguentz Dort",              "luguentzdort.png", "Arizona State", 5, NBA_Player.Position.G, "6' 4\"", 220, 13.7, 2.1, 4.6, new DateTime(1999, 4, 19)));
            this.Roster.Add(new NBA_Player("Chet Holmgren",              "chetholmgren.png", "Gonzaga", 7, NBA_Player.Position.PF, "7' 1\"", 195, 0.0, 0.0, 0.0, new DateTime(2002, 5, 1)));
            this.Roster.Add(new NBA_Player("Josh Giddey",                "joshgiddey.png", "Australia", 3, NBA_Player.Position.SG, "6' 8\"", 216, 16.6, 6.2, 7.9, new DateTime(2002, 10, 10)));
            this.Roster.Add(new NBA_Player("Ousmane Dieng",              "ousmanedieng.png", "--", 13, NBA_Player.Position.F, "6' 9\"", 220, 4.9, 1.2, 2.7, new DateTime(2003, 5, 21)));
            this.Roster.Add(new NBA_Player("Jalen Williams",             "jalenwilliams.png", "Santa Clara", 8, NBA_Player.Position.F, "6' 5\"", 211, 14.1, 3.3, 4.5, new DateTime(2001, 4, 14)));
            this.Roster.Add(new NBA_Player("Aleksej Pokusevski",         "aleksejpokusevski.png", "--", 17, NBA_Player.Position.F, "7' 0\"", 210, 8.1, 1.9, 4.7, new DateTime(2001, 12, 26)));
            this.Roster.Add(new NBA_Player("Tre Mann",                   "tremann.png", "Florida", 23, NBA_Player.Position.PG, "6' 3\"", 178, 7.7, 1.8, 2.3, new DateTime(2001, 2, 3)));
            this.Roster.Add(new NBA_Player("Kenrich Williams",           "kenrichwilliams.png", "TCU", 34, NBA_Player.Position.SF, "6' 6\"", 210, 8.0, 2.0, 4.9, new DateTime(1994, 12, 2)));
            this.Roster.Add(new NBA_Player("Jaylin Williams",            "jaylinwilliams.png", "Arkansas", 6, NBA_Player.Position.F, "6' 9\"", 240, 5.9, 1.6, 4.9, new DateTime(2002, 6, 29)));
            this.Roster.Add(new NBA_Player("Lindy Waters III",           "lindywatersiii.png", "Oklahoma State", 12, NBA_Player.Position.F, "6' 6\"", 210, 5.2, .7, 1.8, new DateTime(1997, 7, 28)));
            this.Roster.Add(new NBA_Player("Isaiah Joe",                 "isaiahjoe.png", "Arkansas", 11, NBA_Player.Position.SG, "6' 3\"", 165, 9.5, 1.2, 2.4, new DateTime(1999, 7, 2)));
            this.Roster.Add(new NBA_Player("Aaron Wiggins",              "aaronwiggins.png", "Maryland", 21, NBA_Player.Position.SG, "6' 5\"", 190, 6.8, 1.1, 3.0, new DateTime(1999, 1, 2)));
            this.Roster.Add(new NBA_Player("Olivier Sarr",               "oliviersarr.png", "Kentucky", 30, NBA_Player.Position.C, "6' 10\"", 240, 4.0, .4, 3.4, new DateTime(1999, 2, 20)));
            this.Roster.Add(new NBA_Player("Cason Wallace",              "casonwallace.png", "Kentucky", 22, NBA_Player.Position.G, "6' 3\"", 195, 0.0, 0.0, 0.0, new DateTime(2003, 11, 7)));
            this.Roster.Add(new NBA_Player("Keyontae Johnson",           "keyontaejohnson.png", "Kansas State", 18, NBA_Player.Position.F, "6' 4\"", 230, 0, 0, 0, new DateTime(2000, 5, 24)));
            this.Roster.Add(new NBA_Player("Vasilije Micic",             "vasilijemicic.png", "Serbia", 29, NBA_Player.Position.G, "6' 3\"", 188, 13.1, 4.8, 2.4, new DateTime(1994, 1, 13)));
        }
    }
}

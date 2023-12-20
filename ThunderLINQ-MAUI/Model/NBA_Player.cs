using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderLINQ_MAUI.Model
{
    /*
     * This is the Model for the NBA Player!
     */
    public class NBA_Player
    {
        // The NBA Player's Name
        public string Name { get; set; }

        // The NBA Player's Image
        public string Image { get; set; }

        // The NBA Player's College
        public string College { get; set; }

        // The NBA Player's Jersey Number
        public int Number { get; set; }

        // The NBA Player's Age
        public int Age { get; set; }

        // The NBA Player's Position Enum
        public enum Position { PG, SG, G, SF, PF, F, C }

        // The NBA Player's Position
        public Position Pos { get; set; }

        // The NBA Player's Height
        public string Height { get; set; }

        // The NBA Player's Weight
        public int Weight { get; set; }

        // The NBA Player's Average Points Per Game
        public double Pts { get; set; }

        // The NBA Player's Average Assists Per Game
        public double Ast { get; set; }

        // The NBA Player's Average Rebounds Per Game
        public double Reb { get; set; }

        // The NBA Player's Date of Birth
        public DateTime DOB { get; set; }




        // Default Constructor
        public NBA_Player() 
        { 
            
        }

        // Full Constructor
        public NBA_Player(string name, string image, string college, int number, Position pos, string height, int weight, double pts, double ast, double reb, DateTime dob)
        {
            this.Name = name;
            this.Image = image;
            this.College = college;
            this.Number = number;
            this.Pos = pos;
            this.Height = height;
            this.Weight = weight;
            this.Pts = pts;
            this.Ast = ast;
            this.Reb = reb;
            this.DOB = dob;
            this.Age = this.GetAge();
        }




        // Gets the NBA Players Name
        public string GetName()
        {
            return Name;
        }

        // Gets the NBA Players Image
        public string GetImage()
        {
            return Image;
        }

        // Sets the NBA Players Image
        public void SetImage(string image)
        {
            this.Image = image;
        }

        // Gets the NBA Players College
        public string GetCollege()
        {
            return this.College;
        }

        // Sets the NBA Players Position
        public void SetPosition(NBA_Player.Position pos)
        {
            this.Pos = pos;
        }

        // Gets the NBA Players Position
        public NBA_Player.Position GetPosition()
        {
            return this.Pos;
        }

        // Gets the NBA Players Number
        public int GetNumber()
        {
            return this.Number;
        }

        // Gets the NBA Players Age
        public int GetAge()
        {
            int month = DateTime.Now.Month - this.GetDOB().Month;
            int day = DateTime.Now.Day - this.GetDOB().Day;
            int year = DateTime.Now.Year - this.GetDOB().Year;
            if (month == 0 && day <= 0) year--;
            else if (month < 0) year--;
            this.Age = year;
            return year;
        }

        // Gets the NBA Players Height
        public string GetHeight()
        {
            return this.Height;
        }

        // Gets the NBA Players Height in Inches
        public double GetRealHeight()
        {
            double realHeight;
            bool success;

            int.TryParse(this.Height.AsSpan(0, 1), out int feet);
            int.TryParse(this.Height.AsSpan(3, 1), out int inches);

            // Check to see if the 1 could be 10 or 11
            if (inches == 1)
            {
                success = int.TryParse(this.Height.AsSpan(3, 2), out inches);

                // If TryParse failed its because the 1 isn't followed by a number 
                if (!success) inches = 1;
            }

            realHeight = (feet * 12) + inches;

            return realHeight;
        }

        // Gets the NBA Players Weight
        public int GetWeight()
        {
            return this.Weight;
        }

        // Gets the NBA Players Average Points Per Game
        public double GetPoints()
        {
            return this.Pts;
        }

        // Gets the NBA Players Average Assists Per Game
        public double GetAssists()
        {
            return this.Ast;
        }

        // Gets the NBA Players Average Rebounds Per Game
        public double GetRebounds()
        {
            return this.Reb;
        }

        // Gets the NBA Players Date of Birth
        public DateTime GetDOB()
        {
            return this.DOB;
        }
    }
}

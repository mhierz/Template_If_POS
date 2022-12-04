using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_If_POS.Classes
{
    public class Movie
    {
        public string Name { get; set; } = string.Empty;
        public int Season { get; set; } = 0;
        public float Price { get; set; }
        public int AgeRating { get; set; }

        public Movie(string name, float price, int ageRating )
        {
            Name = name;
            Price = price;
            AgeRating = ageRating;
        }

        public Movie(string name, int season, float price, int ageRating)
        {
            Name = name;
            Season = season;
            Price = price;
            AgeRating = ageRating;
        }   
    }
}

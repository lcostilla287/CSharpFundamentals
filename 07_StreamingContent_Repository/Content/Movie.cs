using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository.Content
{
    public class Movie : StreamingContent // inherit streaming content class
    {
        public Movie() { }

        public Movie(string title, string description, double starRating, GenreType genre, MaturityRating maturityRating, double runTime) : base(title, description, starRating, genre, maturityRating)
        {
            // setting properties that aren't included in the base constructor
            RunTime = runTime;
        }

        public double RunTime { get; set; }

    }
}

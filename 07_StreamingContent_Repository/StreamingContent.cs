using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{

    //enums are outside of class
    public enum GenreType { Horror = 1, RomCom, SciFi, Documentary, Bromance, Drama, Action, Comedy, Anime}
    public enum MaturityRating { G = 1, PG, PG_13, R, TV_G, TV_PG, TV_14, TV_MA}
    public class StreamingContent
    {
        //POCO - plain old c# object- classes with properties and constructors

        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendy   //no set so it can't be easily changed
        { 
            get //here below, it returns either a true or false make sure to use double == and "||" for or
            {
                //bool isFamilyFriendly = ((int)MaturityRating < 5) ? true : false; the (int) is casting which is converting to another compatible type the rest is ternary form.
                if (MaturityRating == MaturityRating.R || MaturityRating == MaturityRating.TV_MA)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public StreamingContent() { } // this is our empty constructor, we can new up stuff through this, must declare this in order to have an overloaded construction after

        public StreamingContent(string title, string description, double starRating, GenreType typeOfGenre, MaturityRating maturityRating) // the stuff in () passes through this constructor
        {
            Title = title;
            Description = description;
            StarRating = starRating;   //we don't need isFamilyFriendly because we already made it get the MaturityRating
            TypeOfGenre = typeOfGenre;
            MaturityRating = maturityRating;
        }

    }
}

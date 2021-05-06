using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository //we are gonna use fields here, it exist at the class level
    {
        //this will store our data. a method will interact with this for our front-end stuff
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD methods below- Create new data, Read that data, Update it, or Delete it

        //This will create
        //content
        public bool AddContentToDirectory(StreamingContent newContent) //we need to take in a Streaming content object to add it to our directory
        {
            int startingCount = _contentDirectory.Count; // Count is property of list 

            _contentDirectory.Add(newContent);  //adds StreamingContent object to the _contentdirectory list

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded; //returns true if added to list correctly
        }


        //movie
        public bool AddContentToDirectory(Movie newContent) //we need to take in a Streaming content object to add it to our directory
        {
            int startingCount = _contentDirectory.Count; // Count is property of list 

            _contentDirectory.Add(newContent);  //adds StreamingContent object to the _contentdirectory list

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded; //returns true if added to list correctly
        }


        //show

        //episode



        //This Reads the data
        //content Read all
        public List<StreamingContent> GetContents() //method that displays in the console
        {
            return _contentDirectory; // we don't want anything new just grabs all the content in our directory and returns it we don't want front end to directly talk to the list data above
        }


        //Movie read all
        public List<Movie> GetMovies()
        {
            //Initialize empty list
            List<Movie> allMovies = new List<Movie>();
            
            //look through our directory
            foreach(StreamingContent content in _contentDirectory)
            {
                //check to see if it is movie class
                if(content is Movie)
                {
                    //load into our list
                    allMovies.Add(content as Movie);
                }
            }
            //just returns our list
            return allMovies; //since we set a new list instance, we just get and empty list back
        }


        //Show read all
        public List<Show> GetShows()
        {
            //set up list
            List<Show> allShows = new List<Show>();
            //find our shows
            foreach(StreamingContent content in _contentDirectory)
            {
                //Check to see if it is a show
                if (content.GetType() == typeof(Show)) // we can also use is
                {
                    //Yes? Add to list
                    allShows.Add((Show)content);
                }
            }
            //Gives shows back
            return allShows;
        }

        //Episode Read all

        //This is another read portion, this just sees one item along with everything related to it, take in string return object
        public StreamingContent GetContentByTitle(string title) //takes in the title as our parameter
        { //we gotta look to _contentDirectory to get our info
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower()) //we want to see if the content's title is equal to the string of the title the user input
                {
                    return content; //grabs entire object and return it
                } //don't need an else that returns null because we just top at the first option if they don't match
            }
            return null;
        }

        //Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent movie in _contentDirectory)
            {
                if (movie.Title.ToLower() == title.ToLower() && movie is Movie) // "is" is a bool struct, checks to see if movie is type Movie
                {
                    return (Movie)movie; // can also use return movie as Movie;
                }
            }
            return null;
        }
        //Show
        //get show by title
        public Show GetShowByTitle (string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show)) //this makes sure that if we pull out something, it is a show
                {
                    return (Show)show; //we need to cast show into Show to get our Show object in Show class
                }
            }

            return null;
        }

        //Episode

        //This will update

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues) //(takes in what we want to update)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle); //takes originalTitle, passes through above method and save it as oldContent

            if (oldContent != null)
            {
                oldContent.Title = newContentValues.Title; //take old then make new
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating; //if we switch each sides, just changes the value that won't be used anywhere
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating; //these update property values

                return true; //this makes sure we get out of our method
            }
            else
            {
                return false;
            }
        }

        //This will delete
        public bool DeleteExistingContent(string titleToDelete) // we can use the title to delete a whole object
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete); //calls the method GetContentByTitle, takes the string (which is the actual title and makes it the content to delete
            if(contentToDelete == null)
            {
                return false; // this means that there wasn't one to delete
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}

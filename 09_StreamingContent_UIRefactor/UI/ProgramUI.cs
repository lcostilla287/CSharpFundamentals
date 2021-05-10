using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository(); //this field accesses the streaming content repository class for all methods here
        private IConsole _console;

        public ProgramUI(IConsole console) //dependency injection
        {
            _console = console;
        }




        public void Run() //this will be called by program.cs
        {
            SeedContentList(); //this is the data we put in way in the bottom, we can modify it in one command prompt session
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                _console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit"); // \n is a linebreak displays each on a seperate line

                string input = Console.ReadLine();


                //we could do if but that is too long, switch is better

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                    case "banana": //we can put anything here
                        //Create New Content
                        CreateNewContent(); //calls the CreateNewContent method below
                        break;
                    case "2":
                    case "two":
                        //ViewAllContent
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //ViewContentByTitle
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //UpdateExistingContent
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //DeleteExistingContent
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //exit
                        keepRunning = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number");
                        break;
                }

                _console.WriteLine("Please press any key to continue");
                _console.ReadKey();
                _console.Clear(); // clears the menu when you input something
            }
        }
        private void CreateNewContent() //optional challenge- confirm information before adding to directory
        {
            _console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            _console.WriteLine("What is the Title for this content?");
            newContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Enter the description of the content");
            newContent.Description = _console.ReadLine();

            //StarRating
            _console.WriteLine("Enter the Star Rating for this Content(0-5.0)");
            string starRatingAsString = _console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(_console.ReadLine()); this is way easier than above

            //Genre
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4.Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = _console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt; //takes the int and cast it into genretype enum in streaming content class

            // test this: newContent.TypeOfGenre = (GenreType)Convert.ToInt32(_console.ReadLine()); This also works!!!

            //MaturityRating
            _console.WriteLine("Enter the Maturity rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            string maturityRatingAsString = _console.ReadLine();
            int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;

            // test this: newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine()); This also works!!

            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent); //this adds it to the directory
            if (wasAddedCorrectly) //Checks to see if it was added
            {
                _console.WriteLine("The content was added correctly!");
            }
            else
            {
                _console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent() //Display all content in directory
        {
            _console.Clear();
            List<StreamingContent> allContent = _repo.GetContents(); // we refer to the _repo way at the beginning here to access our streamingcontent list in our streamingcontentRepository
            foreach (StreamingContent content in allContent) //reads for each streaming content item in all content, display the content
            {
               // _console.ForegroundColor = _consoleColor.Green;
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly : {content.IsFamilyFriendy}");
                //_console.ResetColor();
            }
        }

        private void DisplayContentByTitle() //get a title from the user and display all properties of the content that has that title.
        {
            _console.Clear();
            DisplayAllContent(); // try and find something that only displays the title
            _console.WriteLine("Please enter the name of the title you would like to search: ");
            StreamingContent contentToDisplay = _repo.GetContentByTitle(_console.ReadLine());



            if (contentToDisplay != null)
            {
                _console.WriteLine($"Title: {contentToDisplay.Title} \n" +
                    $"Description: {contentToDisplay.Description} \n" +
                    $"Star Rating: {contentToDisplay.StarRating} \n" +
                    $"Genre: {contentToDisplay.TypeOfGenre} \n" +
                    $"Rating: {contentToDisplay.MaturityRating} \n" +
                    $"Is Family Friendly: {contentToDisplay.IsFamilyFriendy}");
            }
            else
            {
                _console.WriteLine("There is no content by that title");
            }
        }

        private void UpdateContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title of the content you would like to update");

            string oldTitle = _console.ReadLine();

            //here we just copy the create method we made before. 

            StreamingContent newContent = new StreamingContent();

            //Title
            _console.WriteLine("What is the Title for this content?");
            newContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Enter the description of the content");
            newContent.Description = _console.ReadLine();

            //StarRating
            _console.WriteLine("Enter the Star Rating for this Content(0-5.0)");
            string starRatingAsString = _console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(_console.ReadLine()); this is way easier than above

            //Genre
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4.Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = _console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt; //takes the int and cast it into genretype enum in streaming content class

            // test this: newContent.TypeOfGenre = (GenreType)Convert.ToInt32(_console.ReadLine()); This also works!!!

            //MaturityRating
            _console.WriteLine("Enter the Maturity rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            string maturityRatingAsString = _console.ReadLine();
            int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent); //this passes our old title to the UpdateExistingContent method in our repository
            if (wasUpdated)
            {
                _console.WriteLine("The content was updated successfully");
            }
            else
            {
                _console.WriteLine("No content by that title exists");
            }
        }

        private void DeleteContent()
        {
            _console.Clear();
            DisplayAllContent();

            _console.WriteLine("Enter the title for the content you want to delete.");
            bool wasDeleted = _repo.DeleteExistingContent(_console.ReadLine());

            if (wasDeleted)
            {
                _console.WriteLine("Your content was successfully deleted!");
            }
            else
            {
                _console.WriteLine("Content could note be deleted");
            }

        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets accidentally transported back in time 30 years", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the day", 3.1, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "A car tire comes to life and goes on a killing spree", 1.2, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}

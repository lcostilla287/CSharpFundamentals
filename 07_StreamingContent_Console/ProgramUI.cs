using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository(); //this field accesses the streaming content repository class for all methods here
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

                Console.WriteLine("Select a menu option:\n" +
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
                        Console.WriteLine("Please enter a valid number");
                        break;
                }

                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear(); // clears the menu when you input something
            }
        }
        private void CreateNewContent() //optional challenge- confirm information before adding to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the Title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //StarRating
            Console.WriteLine("Enter the Star Rating for this Content(0-5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(Console.ReadLine()); this is way easier than above

            //Genre
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4.Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt; //takes the int and cast it into genretype enum in streaming content class

            // test this: newContent.TypeOfGenre = (GenreType)Convert.ToInt32(Console.ReadLine()); This also works!!!

            //MaturityRating
            Console.WriteLine("Enter the Maturity rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            string maturityRatingAsString = Console.ReadLine();
            int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;

            // test this: newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine()); This also works!!

            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent); //this adds it to the directory
            if (wasAddedCorrectly) //Checks to see if it was added
            {
                Console.WriteLine("The content was added correctly!");
            }
            else
            {
                Console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent() //Display all content in directory
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents(); // we refer to the _repo way at the beginning here to access our streamingcontent list in our streamingcontentRepository
            foreach(StreamingContent content in allContent) //reads for each streaming content item in all content, display the content
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly : {content.IsFamilyFriendy}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() //get a title from the user and display all properties of the content that has that title.
        {
            Console.Clear();
            DisplayAllContent(); // try and find something that only displays the title
            Console.WriteLine("Please enter the name of the title you would like to search: ");
            StreamingContent contentToDisplay = _repo.GetContentByTitle(Console.ReadLine());



            if (contentToDisplay != null)
            {
                    Console.WriteLine($"Title: {contentToDisplay.Title} \n" +
                        $"Description: {contentToDisplay.Description} \n" +
                        $"Star Rating: {contentToDisplay.StarRating} \n" +
                        $"Genre: {contentToDisplay.TypeOfGenre} \n" +
                        $"Rating: {contentToDisplay.MaturityRating} \n" +
                        $"Is Family Friendly: {contentToDisplay.IsFamilyFriendy}");
            }
            else
            {
                Console.WriteLine("There is no content by that title");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to update");

            string oldTitle = Console.ReadLine();

            //here we just copy the create method we made before. 

            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the Title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //StarRating
            Console.WriteLine("Enter the Star Rating for this Content(0-5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(Console.ReadLine()); this is way easier than above

            //Genre
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4.Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt; //takes the int and cast it into genretype enum in streaming content class

            // test this: newContent.TypeOfGenre = (GenreType)Convert.ToInt32(Console.ReadLine()); This also works!!!

            //MaturityRating
            Console.WriteLine("Enter the Maturity rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            string maturityRatingAsString = Console.ReadLine();
            int maturityRatingAsInt = Convert.ToInt32(maturityRatingAsString);
            newContent.MaturityRating = (MaturityRating)maturityRatingAsInt;

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent); //this passes our old title to the UpdateExistingContent method in our repository
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully");
            }
            else
            {
                Console.WriteLine("No content by that title exists");
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you want to delete.");
            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Your content was successfully deleted!");
            }
            else
            {
                Console.WriteLine("Content could note be deleted");
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

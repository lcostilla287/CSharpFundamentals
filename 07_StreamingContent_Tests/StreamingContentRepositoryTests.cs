using _07_StreamingContent_Repository;
using _07_StreamingContent_Repository.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA
            //Arrange
            StreamingContent content = new StreamingContent(); // fill up repository values//have to make a reference to the StreamingContent_Repository "CTRL ."
            StreamingContentRepository repository = new StreamingContentRepository(); // access methods

            //Act
            bool addResult = repository.AddContentToDirectory(content); //calling method trying to test

            //Assert
            Assert.IsTrue(addResult); //evaluates above addResult bool
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository(); //() means brand new instance
            repository.AddContentToDirectory(content); // we call the AddContentToDirectory method

            //Act
            List<StreamingContent> directory = repository.GetContents(); //calls to GetContents method

            //Assert
            bool directoryHasContent = directory.Contains(content); //check to see if content passed throught the list we mad to include it above
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContent _content;
        private StreamingContentRepository _repo; //These are fields ,in this case they are only declared

        [TestInitialize] //This runs as a setup for other methods
        public void Arrange() //newmethod
        {
            _repo = new StreamingContentRepository(); //these initialize the above
            _content = new StreamingContent("Back to the Future", "A high school student named Marty gets accidently sent back in time 30 years.", 4.4, GenreType.SciFi, MaturityRating.PG);
            // the above passes through that specific constructor
            _repo.AddContentToDirectory(_content); //now we can do this if we want to new up stuff. much easier
        }

        [TestMethod]
        public void CheckMovieRunTime()
        {
            //Creating a movie type, using full constructor and inherited base
            Movie joe = new Movie("Joe Dirt", "The story about a mullet and his meteor", 3.2, GenreType.Bromance, MaturityRating.PG_13, 112);
            //creating a list to replicate our repo
            List<StreamingContent> miniRepo = new List<StreamingContent>();
            miniRepo.Add(joe);

            //filtering our repo by movies in our foreach loop
            foreach(Movie content in miniRepo)
            {
                    Console.WriteLine(content.RunTime); //this can work without casting
            }
            //searching for StreamingContent makes runTime unavailable without casting.
            foreach(StreamingContent content in miniRepo)
            {
                //finding movie types
                if(content is Movie)
                {
                    //setting content as Movie to access Movie exclusive properties
                    Console.WriteLine((content as Movie).RunTime);
                }
            }
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //Done in Arrange() Method

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Back to the Future");

            //Assert
            Assert.AreEqual(_content, searchResult); //sees if the content is the same as the search result
            //returns null if not found
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnUpdatedValue()
        {
            //Arrange
            //we have testinitialize above so it is already arranged

            //Act
            _repo.UpdateExistingContent("Back to the Future", new StreamingContent("Back to the Future 2", "Marty goes into the future 30 years", 4.0, GenreType.SciFi, MaturityRating.PG_13)); //newing up == instantiating

            //Assert
            Assert.AreEqual(_content.Title, "Back to the Future 2"); //it passes because we succefully changed it
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arranged set up above

            //Act
            bool wasDeleted = _repo.DeleteExistingContent("Back to the Future"); //Call DeleteExistingContent (other page, pass that title and see it it was deleted

            //Assert
            Assert.IsTrue(wasDeleted);
        }
    }
}

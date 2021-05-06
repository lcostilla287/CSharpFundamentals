using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentPOCOTests
    {
        [DataTestMethod] 
        [DataRow(MaturityRating.G, true)] //when we run the test, it sets the rating equal to G and the bool expectedIsfamilyFriendly to true
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool expectedIsFamilyFriendly)
        {
            StreamingContent newContent = new StreamingContent("Back to the Future", "A high school student named Marty gets accidently sent back in time 30 years.", 4.4, GenreType.SciFi, rating); //make sure to use the parameter rating which is above

            bool actual = newContent.IsFamilyFriendy; //calls the IsFamilyFriendly property in StreamingContent.cs
            bool expected = expectedIsFamilyFriendly;
            Assert.AreEqual(actual, expected);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dubuche.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubuche.BL.Tests
{
    [TestClass()]
    public class RestaurantSortTests
    {
        [TestMethod()]
        public void AlphaSortingTest()
        {
            List<Restaurants> restsTests = new List<Restaurants>();//arrange
            Restaurants rests = new Restaurants("def"); //arrange
            restsTests.Add(rests); //arrange
            List<Restaurants> expected = new List<Restaurants>();//arrange

            Restaurants rests2 = new Restaurants("abc"); //arrange
            restsTests.Add(rests2); //arrange

            Restaurants rests3 = new Restaurants("abc"); //arrange
            expected.Add(rests3); //arrange

            Restaurants rests4 = new Restaurants("def"); //arrange
            expected.Add(rests4); //arrange

            List<Restaurants> actual = RestaurantSort.AlphaSorting(restsTests); //act

            Assert.AreEqual(expected[0].Name, actual[0].Name); //assert
            Assert.AreEqual(expected[1].Name, actual[1].Name); //assert
        }

        [TestMethod()]
        public void BetaSortingTest()
        {
            List<Restaurants> restsTests = new List<Restaurants>();//arrange
            Restaurants rests = new Restaurants("def"); //arrange
            restsTests.Add(rests); //arrange
            List<Restaurants> expected = new List<Restaurants>();//arrange

            Restaurants rests2 = new Restaurants("abc"); //arrange
            restsTests.Add(rests2); //arrange

            Restaurants rests3 = new Restaurants("def"); //arrange
            expected.Add(rests3); //arrange

            Restaurants rests4 = new Restaurants("abc"); //arrange
            expected.Add(rests4); //arrange

            List<Restaurants> actual = RestaurantSort.BetaSorting(restsTests); //act

            Assert.AreEqual(expected[0].Name, actual[0].Name); //assert
            Assert.AreEqual(expected[1].Name, actual[1].Name); //assert

        }
         
        
    }
}
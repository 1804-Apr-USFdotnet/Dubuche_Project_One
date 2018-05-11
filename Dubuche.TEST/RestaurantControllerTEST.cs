using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restaurants.MVC.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using Dubuche.DAL;

namespace Dubuche.TEST
{
    [TestClass]
    public class RestaurantControllerTEST
    {
        [TestMethod]
        public void TestRestaurantsIndex()
        {
            //Arrange
            RestaurantController controller = new RestaurantController();
            string e1 = "Mission BBQ";
            

            //Act
            var result1 = controller.Index() as ViewResult;
            var data1 = result1.Model as List<Restaurant>;
           

            //Assert
            Assert.IsNotNull(result1);
            Assert.AreEqual(e1, data1[0].Name);
           
        }
    }
}

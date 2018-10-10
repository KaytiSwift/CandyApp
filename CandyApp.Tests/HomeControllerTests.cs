using CandyApp.Controllers;
using CandyApp.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace CandyApp.Tests
{
    public class HomeControllerTests
    {
        private ICandyRepository candyRepo;
        private HomeController underTest; 

        public HomeControllerTests()
        {
            candyRepo = Substitute.For<ICandyRepository>();
            underTest = new HomeController(candyRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_All_Candies()
        {
            
            var result = underTest.Index();
            candyRepo.Received().GetAll();
        }

        [Fact]
        public void Index_Sets_AllDogs_As_Model()
        {
            var expectedModel = new List<Candy>();
            var result = underTest.Index();
            candyRepo.GetAll().Returns(expectedModel);
        }
    }
}

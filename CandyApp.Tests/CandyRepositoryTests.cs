using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CandyApp.Tests
{
    public class CandyRepositoryTests
    {
        [Fact]
        public void Test1()
        {
            var candyRepo = new CandyRepository();

            var result = candyRepo.GetAll();
            Assert.NotEmpty(result);
        }
    }
}

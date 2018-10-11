using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyApp.Models;

namespace CandyApp
{
    public class CandyRepository : ICandyRepository
    {
        List<Candy> all = new List<Candy>()
            {
                new Candy()
                {
                    Name = "Snickers",
                    Calories = 300,
                    HasChocolate = true,
                    ImgUrl = "https://www.snickers.com",
                    Ingredients = new List<string>()
                    {
                        "chocolate",
                        "peanuts",
                        "love",
                        "caramel",
                        "NuGet"
                    }
                }
            };

        public List<Candy> GetAll()
        {          
            return all;
        }
    }
}

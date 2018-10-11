using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyApp.Models
{
    public class Candy
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public List<string> Ingredients { get; set;}
        public bool HasChocolate { get; set; }
        public int Calories { get; set; }
    }
}

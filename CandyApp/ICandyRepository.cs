using CandyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyApp
{
    public interface ICandyRepository
    {
        List<Candy> GetAll();
        void FindByName();
    }
}

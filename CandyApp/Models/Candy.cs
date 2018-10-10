using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyApp.Models
{
    public class Candy : ICandyRepository
    {
        List<Candy> ICandyRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

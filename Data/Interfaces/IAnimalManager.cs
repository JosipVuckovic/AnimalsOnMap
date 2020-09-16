using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalsOnMap.Data.Classes;

namespace AnimalsOnMap.Data.Interfaces
{
    public interface IAnimalManager
    {
        public List<Animal> GetAllAnimals();
    }
}

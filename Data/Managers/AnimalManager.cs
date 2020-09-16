using AnimalsOnMap.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsOnMap.Data.Interfaces
{
    public class AnimalManager : IAnimalManager
    {
        private AnimalsContext _context;
        public AnimalManager(AnimalsContext context)
        {
            _context = context;
        }

        public List<Animal> GetAllAnimals()
        {
            return _context.Animals.ToList();
        }
    }
}

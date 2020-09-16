using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalsOnMap.Data.Classes;

namespace AnimalsOnMap.Data.Interfaces
{
    public interface IAnimalManager
    {
        List<Animal> GetAllAnimals();
        Animal GetAnimalDetails(int? id);
        void AddNewAnimal(Animal newAnimal);
        bool AnimalExists(int id);
        public void DeleteAnimal(int id);
        public void UpdateAnimal(Animal animal);
    }
}

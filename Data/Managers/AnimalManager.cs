using AnimalsOnMap.Data.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public Animal GetAnimalDetails(int? id)
        {
            return _context.Animals.FirstOrDefault(x => x.Id == id);
        }

        public void AddNewAnimal(Animal newAnimal)
        {
           _context.Add(newAnimal);
           _context.SaveChanges();
        }

        public bool AnimalExists(int id)
        {
            return _context.Animals.Any(x => x.Id == id);
        }

        public void DeleteAnimal(int id)
        {
            _context.Animals.Remove(_context.Animals.FirstOrDefault(x => x.Id == id));
            _context.SaveChanges();
        }

        public void UpdateAnimal(Animal animal)
        {
            try
            {
                _context.Update(animal);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Error on inserting");
            }            
        }
      
    }
}

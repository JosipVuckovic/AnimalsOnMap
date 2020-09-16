using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnimalsOnMap.Data;
using AnimalsOnMap.Data.Classes;
using System.Threading;
using System.Globalization;
using AnimalsOnMap.Data.Interfaces;
using NUglify.JavaScript.Syntax;

namespace AnimalsOnMap.Controllers
{
    public class AnimalsController : Controller
    {        
        private readonly IAnimalManager _manager;

        public AnimalsController(AnimalsContext context, IAnimalManager manager)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            _manager = manager;            
        }

        // GET: Animals
        public IActionResult Index()
        {            
            return View(_manager.GetAllAnimals());
        }

        // GET: Animals/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = _manager.GetAnimalDetails(id);

            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // GET: Animals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Animals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,LocalName,LatinName,AnimalSpecies,Longitude,Latituda")] Animal animal)
        {
            if (ModelState.IsValid)
            {
                _manager.AddNewAnimal(animal);
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        // GET: Animals/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = _manager.GetAnimalDetails(id);
            if (animal == null)
            {
                return NotFound();
            }
            return View(animal);
        }

        // POST: Animals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,LocalName,LatinName,AnimalSpecies,Longitude,Latituda")] Animal animal)
        {
            if (id != animal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _manager.UpdateAnimal(animal);
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }

        // GET: Animals/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = _manager.GetAnimalDetails(id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // POST: Animals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _manager.DeleteAnimal(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalExists(int id)
        {
            return _manager.AnimalExists(id);
        }
    }
}

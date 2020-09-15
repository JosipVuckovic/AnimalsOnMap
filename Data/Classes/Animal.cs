using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AnimalsOnMap.Data.Classes
{
    public enum AnimalSpecies
    {
        [Display(Name = "Invertebrate")]
        Invertebrates = 1,
        [Display(Name = "Fish")]
        Fish = 2,
        [Display(Name = "Amphibian")]
        Amphibians = 3,
        [Display(Name = "Reptile")]
        Reptiles = 4,
        [Display(Name = "Bird")]
        Birds = 5,
        [Display(Name = "Mammal")]
        Mammals = 6
    }
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Local name of the animal")]
        public string LocalName { get; set; }
        [DisplayName("Latin name of the animal")]
        public string LatinName { get; set; }
        [Required]
        [DisplayName("Species")]        
        public AnimalSpecies AnimalSpecies { get; set; }
        [Required]
        [DisplayName("Lokacija: Longituda")]                
        public float Longitude { get; set; }
        [Required]
        [DisplayName("Lokacija: Latituda")]
        public float Latituda { get; set; }
    }
}

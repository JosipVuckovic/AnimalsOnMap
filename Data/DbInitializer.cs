//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AnimalsOnMap.Data
//{
//    public static class DbInitializer
//    {
//        public static void Initialize(AnimalsContext context)
//        {
//            context.Database.EnsureCreated();
//            if (context.Species.Any())
//            {
//                return;   // DB has been seeded
//            }

//            var specis = new List<Species>
//            {
//                new Species{
//                    SubSpecies = "Equidae",
//                    SpecieType = SpecieType.Mammals
//                }
//            };
//            context.Species.AddRange(specis);
//            context.SaveChanges();
//        }
       
//    }
//}

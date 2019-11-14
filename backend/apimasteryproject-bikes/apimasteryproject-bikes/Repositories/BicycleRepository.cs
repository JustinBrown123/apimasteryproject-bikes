using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apimasteryproject_bikes.Context;
using apimasteryproject_bikes.Models;


namespace apimasteryproject_bikes.Repositories
{
    public class BicycleRepository
    {
        private BikeContext db;
<<<<<<< HEAD
        public BicycleRepository(BicycleContext context) : base(context)
        {

        }
        public IEnumerable<Bicycle> GetbyManufacturerID(int ManufacturerID)
        {
            var manufacturer = db.Bicycles.Where(p => p.ManufacturerID == manufacturerID);
            return bicycles;
        }

=======
        public BicycleRepository(BikeContext context) : base(context)
        {

        }
        public IEnumerable<Bicycle> GetByManufacturerID(int manufacturerID)
        {
            var bicycles = db.Bicycles.Where(p => p.ManufacturerID == manufacturerID);
            return bicycles;
        }
>>>>>>> c62f4be4a16247962e300005ada9d8f3bf7148f0
    }
}

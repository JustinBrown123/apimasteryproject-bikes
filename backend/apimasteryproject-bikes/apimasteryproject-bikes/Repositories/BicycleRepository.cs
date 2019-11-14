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
        public BicycleRepository(BicycleContext context) : base(context)
        {

        }
        public IEnumerable<Bicycle> GetbyManufacturerID(int ManufacturerID)
        {
            var manufacturer = db.Bicycles.Where(p => p.ManufacturerID == manufacturerID);
            return bicycles;
        }

    }
}

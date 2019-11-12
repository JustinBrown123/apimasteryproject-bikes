using apimasteryproject_bikes.Context;
using apimasteryproject_bikes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Repositories
{
    public class ManufacturerRepository : Repository<Manufacturer>, IRepository<Manufacturer>
    {
        public ManufacturerRepository(BikeContext context) : base(context)
        {

        }
    }
}

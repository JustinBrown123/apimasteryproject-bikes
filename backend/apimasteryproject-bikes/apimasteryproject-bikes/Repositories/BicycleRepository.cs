using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apimasteryproject_bikes.Context;
using apimasteryproject_bikes.Models;
using Microsoft.EntityFrameworkCore;

namespace apimasteryproject_bikes.Repositories
{
    public class BicycleRepository : Repository<Bicycle>, IRepository<Bicycle>
    {
       

        public BicycleRepository(BikeContext context) : base(context)
        {
            
        }
     
    }
}

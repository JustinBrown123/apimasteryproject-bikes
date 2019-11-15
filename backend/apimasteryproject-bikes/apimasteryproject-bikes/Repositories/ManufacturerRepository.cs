using apimasteryproject_bikes.Context;
using apimasteryproject_bikes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Repositories
{
    public class ManufacturerRepository : Repository<Manufacturer>, IRepository<Manufacturer>
    {
        private DbContext db;
        public ManufacturerRepository(BikeContext context) : base(context)
        {
            this.db = context;
        }

        public override Manufacturer GetById(int id)
        {
            return db.Set<Manufacturer>().Where(i => i.ID == id).Include("Bicycles").FirstOrDefault();
        }
    }
}

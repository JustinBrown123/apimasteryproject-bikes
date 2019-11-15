using apimasteryproject_bikes.Models;
using apimasteryproject_bikes.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicycleController : ControllerBase
    {


        private IRepository<Bicycle> bicycleRepo;

        public BicycleController(IRepository<Bicycle> bicycleRepo)
        {
            this.bicycleRepo = bicycleRepo;
        }

        // GET api/Bicycles
        [HttpGet]
        public IEnumerable<Bicycle> Get()
        {
            return bicycleRepo.GetAll();
        }

        // GET api/Bicycles/5
        [HttpGet("{id}")]
        public Bicycle Get(int id)
        {
            return bicycleRepo.GetById(id);
        }

        [HttpGet("{id}")]
        public IEnumerable<Bicycle> GetByManufacturer(int id)

        {
            BicycleRepository bicycleRepoFix = bicycleRepo as BicycleRepository;
            return bicycleRepoFix.GetByManufacturerID(id);
        }

        // POST api/Bicycles
        [HttpPost]
        public IEnumerable<Bicycle> Post([FromBody] Bicycle bicycle)
        {
            bicycleRepo.Create(bicycle);
            return bicycleRepo.GetAll();
        }

        // PUT api/Bicycles/5
        [HttpPut("{id}")]
        public IEnumerable<Bicycle> Put([FromBody] Bicycle bicycle)
        {
            bicycleRepo.Update(bicycle);
            return bicycleRepo.GetAll();
        }

        // DELETE api/Bicycles/5
        [HttpDelete("{id}")]
        public IEnumerable<Bicycle> Delete(int id)
        {
            var bicycle = bicycleRepo.GetById(id);
            bicycleRepo.Delete(bicycle);
            return bicycleRepo.GetAll();
        }
    }
}

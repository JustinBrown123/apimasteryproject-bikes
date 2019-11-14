using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using apimasteryproject_bikes.Models;
using apimasteryproject_bikes.Repositories;

namespace apimasteryproject_bikes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {


        private IRepository<Manufacturer> manufacturerRepo;

        public ManufacturerController(IRepository<Manufacturer> manufacturerRepo)
        {
            this.manufacturerRepo = manufacturerRepo;
        }

        // GET api/Manufacturer
        [HttpGet]
        public IEnumerable<Manufacturer> Get()
        {
            return manufacturerRepo.GetAll();
        }

        // GET api/Manufacturer/5
        [HttpGet("{id}")]
        public Manufacturer Get(int id)
        {
            return manufacturerRepo.GetById(id);
        }

        // POST api/Manufacturer
        [HttpPost]
        public IEnumerable<Manufacturer> Post([FromBody] Manufacturer manufacturer)
        {
            manufacturerRepo.Create(manufacturer);
            return manufacturerRepo.GetAll();
        }

        // PUT api//Manufacturer
        [HttpPut("{id}")]
        public IEnumerable<Manufacturer> Put(int id, [FromBody] Manufacturer manufacturer)
        {
            manufacturerRepo.Update(manufacturer);
            return manufacturerRepo.GetAll();
        }

        // DELETE api/Manufacturer
        [HttpDelete("{id}")]
        public IEnumerable<Manufacturer> Delete(int id)
        {
            var manufacturer = manufacturerRepo.GetById(id);
            manufacturerRepo.Delete(manufacturer);
            return manufacturerRepo.GetAll();
        }
    }
}

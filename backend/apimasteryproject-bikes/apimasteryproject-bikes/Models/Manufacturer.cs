using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apimasteryproject_bikes.Models
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Bicycle> Bicycles { get; set; }

        public Manufacturer(int id, string name, string image, string description)
        {
            ID = id;
            Name = name;
            Image = image;
            Description = description;
        }
        public Manufacturer()
        {

        }
    }
}

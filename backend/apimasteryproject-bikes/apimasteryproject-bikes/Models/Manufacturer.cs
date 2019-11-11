using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Models
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        public string 
        public virtual ICollection<Bicycle> Bicycles { get; set; }

        public Manufacturer(int id, string name, string logo, string description)
        {
            ID = id;
            Name = name;
            Logo = logo;
            Description = Description;
        }

    }
}

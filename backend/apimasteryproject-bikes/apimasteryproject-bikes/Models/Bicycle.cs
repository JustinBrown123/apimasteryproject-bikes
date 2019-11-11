using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Models
{
    public class Bicycle
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public int Style { get; set; }
        public int ManufacturerID { get; set; }

        public virtual Manufacturer Manufacturers { get; set; }
    }
}

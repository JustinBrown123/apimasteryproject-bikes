using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Models
{
    public class Bicycle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public string Style { get; set; }
        public int ManufacturerID { get; set; }

        public virtual Manufacturer Manufacturers { get; set; }

        public Bicycle(int id, string name, string image, string description, string style, int manufacturerID)
        {
            ID = id;
            Name = name;
            Image = image;
            Description = description;
            Style = style;
            ManufacturerID = manufacturerID;
        }

        public Bicycle()
        {

        }
            
         

    }
}

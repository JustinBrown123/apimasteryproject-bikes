using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apimasteryproject_bikes.Models
{
    public class ManufacturerStyle
    {
        public int StyleID { get; set; }
        public virtual Style Styles { get; set; }

        public int ManufacturerID { get; set; }
        public virtual Manufacturer Manufacturers { get; set; }
    }
}

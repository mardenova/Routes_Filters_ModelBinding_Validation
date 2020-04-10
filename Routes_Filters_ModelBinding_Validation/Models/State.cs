using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routes_Filters_ModelBinding_Validation.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public City CapitalCity { get; set; }
    }
    public class City
    {
        public string CityName { get; set; }
        public int Age { get; set; }
        public string MayorName { get; set; }
    }
}

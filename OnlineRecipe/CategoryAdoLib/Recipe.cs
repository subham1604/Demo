using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryAdoLib
{
    public class Recipe
    {
        public int categoryId { get; set; }
        public string recipeName { get; set; }

        public string picture { get; set; }

        public string description { get; set; }
    }
}

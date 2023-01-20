using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryAdoLib
{
    internal interface IDatabase
    {

         List<Category> GetCategories();
        //changes
    }
}

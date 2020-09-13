using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class Product
    {
        uint id;
        string Name;
        uint count;
    }
    public class DataBase : List<Product>
    {
    }
}

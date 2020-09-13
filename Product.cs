using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
    public class SmallProduct
    {
        public string name { get; set; }
        public int count { get; set; }
    }
}

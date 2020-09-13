using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        DataBaseContext _db;

        public ProductsController(DataBaseContext db)
        {
            this._db = db;
        }
        
        [HttpGet]
        public Product[] Get() => _db.Products.ToArray();

        [HttpGet("{id}")]
        public Product Get(int id)  => _db.Products.Find(id);


        [HttpPost("Insert")]
        public void Post(SmallProduct obj)
        {
            Product product = new Product();
            product.Name = obj.name;
            product.Count = obj.count;

            _db.Products.Add(product); //Insert
            _db.SaveChanges();   //commint
        }

        [HttpDelete]
        public void Delete()
        {
            for(int item=10; item <= 12; item++) 
            { 
                _db.Products.Remove(_db.Products.Find(item+10)); 
            }
            _db.SaveChanges();
        }

    }
}

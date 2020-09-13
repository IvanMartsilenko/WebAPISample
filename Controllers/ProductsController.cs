using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.ControllersS
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
        public IEnumerable<string> Get() => _db.Products.Select(p => p.Name).ToArray();

        [HttpGet("{id}")]
        public string Get(int id) => _db.Products.Find(id).Name;

        [HttpPost]
        public void Post([FromBody]string value)
        {
            Product product = new Product();
            product.Name = value;
            product.Count = 6;

            _db.Products.Add(product); //Insert
            _db.SaveChanges();   //commint
        }


    }
}

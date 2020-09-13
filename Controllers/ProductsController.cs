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
        DataBase _db = new DataBase();

        public ProductsController(DataBase db)
        {
            this._db = db;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _db;
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "undone";
        }
    }
}

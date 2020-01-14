using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleService.Models;

namespace SimpleService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<ICollection<Product>> Get()
        {
            return DB.Database.Products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(uint id)
        {
            return DB.Database.Products.Where(n => n.ProductID == id).FirstOrDefault();
        }
    }
}

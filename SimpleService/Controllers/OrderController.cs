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
    public class OrderController : ControllerBase
    {
        
        // POST: api/Order
        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            foreach (Product product in order.Products)
                if (!DB.Database.Products.Contains(product)) return StatusCode(403);
            DB.Database.Orders.Add(order);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(uint id)
        {
            DB.Database.Orders.Remove(DB.Database.Orders.Where(n => n.OrderID == id).FirstOrDefault());
            return Ok();
        }
    }
}

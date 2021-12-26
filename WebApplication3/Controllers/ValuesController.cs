using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("prod")]
        [HttpGet]
        public List<MockProducts> GetProducts()
        {
            List<MockProducts> mockProduct = new List<MockProducts>();
            MockProducts mk = new MockProducts();
            mk.id = 1;
            mk.ProductName = "hashika";

            mockProduct.Add(mk);
            return mockProduct;
        }
        [HttpPost]
        public IActionResult uploadProduct([FromBody] MockProducts mockProduct)
        {
            Console.WriteLine("name"+ mockProduct.ProductName);

            return Ok();
        }
    }

    public class MockProducts
    {
        public int id { get; set; }
        public string ProductName { get; set; }
    }
}

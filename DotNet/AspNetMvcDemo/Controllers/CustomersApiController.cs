using AspNetMvcDemo.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDemo.Controllers
{
    [Route("api/asiakkaat")]
    [ApiController]
    public class CustomersApiController : ControllerBase
    {
        public List<Customer> KaikkiAsiakkat()
        {
            NorthwindContext konteksti = new();
            return konteksti.Customers.ToList();
        }
    }
}

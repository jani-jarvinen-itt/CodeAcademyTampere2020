using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcDemo.Controllers
{
    [Route("api/laskin")]
    [ApiController]
    public class LaskinApiController : ControllerBase
    {
        [HttpPost]
        [Route("summa/{luku1}/{luku2}")]
        public int Summa(int luku1, int luku2)
        {
            int summa = luku1 + luku2;
            return summa;
        }
    }
}

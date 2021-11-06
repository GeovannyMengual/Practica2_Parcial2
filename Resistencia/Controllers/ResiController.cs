using Microsoft.AspNetCore.Mvc;
using Resist.Domain.Entities;
using System;

namespace Resist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResiController : ControllerBase
    {
          [HttpGet]
        [Route("calcula")]
        public IActionResult Calculo(string C1,string C2,string C3,string C4)
        {
            var resul = new Color();
            resul.Bandeja1(C1);
            resul.Bandeja2(C2);
            resul.Bandeja3(C3);
            resul.Bandeja4(C4);
            resul.RetornaCalculo();
            return Ok(resul.RetornaCalculo());
        }
    }
}
 /* Nombre del Maestro: Joel Ivan Chuc Uc
    Nombre de la actividad: Actividad 1, Ejercicio 2: Alcoholemia
    Nombre del alumno:Geovanny Mengual Tuz
    Cuatrimestre: 4
    Grupo: A
    Parcial: 2
    */

using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alcoholi.Domian.Entities;

namespace Alcoholi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class alcoholiController : ControllerBase
    {
        
         [Route("Calcula")]
        
        public IActionResult Obtener(string Bebida,int cant, int Peso)
        {
            
            var resultado = new SerAlcohol();
            resultado.AlcoholConsumidoPers(Bebida,cant);
            if(Bebida.ToLower()!= "cerveza" && Bebida.ToLower()!="vino" && Bebida.ToLower()!="cava" &&Bebida.ToLower()!="vermu" && Bebida.ToLower()!="licor" && Bebida.ToLower()!="brandy")
            {
                return Ok("ERROR!!!!  bebida que ingresada incorrecta, intente otra vez! xd");
            }
            resultado.PasaSangre(Peso);
            
            return Ok(resultado.Resultado());
        }
        
    }
}
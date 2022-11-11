using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace Semana16_2.Controllers
{
    public class HelloWorldController : Controller
    {

        public  IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "Esta es la accion de bienvenida";
        }

        public string Parameters(string name, int edad)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, tu  edad es: {edad} años");
        }

          
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebVendas.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Mensagem"] = "Esta e um pgn teste";
            ViewData["Email"] = "jv9090@gmail.com";
            ViewData["Nome"] = "João vitor esteves tavares";
            ViewData["materia"] = "Poo";
            ViewData["Dias de aula"] = "Terça-feira";
            ViewData["Bim"] = "3Bim";
            return View();
        }
    }
}

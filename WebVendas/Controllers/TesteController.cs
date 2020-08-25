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
            return View();
        }
    }
}

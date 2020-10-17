using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCProyecto10.Controllers
{
    public class Solicitud : Controller
    {
        public Solicitud()
        {
        }

        public IActionResult Index()
        {
            return View("Solicitud");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ladder.Controllers
{
    public class HomeController : Controller
    {
        IUserService service;

        public HomeController(IUserService _service)
        {
            service = _service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
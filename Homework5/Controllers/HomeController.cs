using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Homework5.Models;

namespace Homework5.Controllers
{
    public class HomeController : Controller
    {
        // DI Constructor

        private readonly RandomInt _randomService;

        public HomeController(RandomInt randomServ)
        {
            _randomService = randomServ;
        }
        public int Index()
        {
            return _randomService.RandomInt;
        }

    }
}

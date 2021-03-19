using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework5.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Homework5.Controllers
{

    //Method

    public class MethodController : Controller
    {
        public int Index([FromServices] RandomInt randomService)
        {
            return randomService.RandomInt;
        }
    }
}

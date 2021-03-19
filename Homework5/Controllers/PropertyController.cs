using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework5.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Homework5.Controllers
{

    //Property

    public class PropertyController : Controller
    {
        private RandomInt _randomService;

        public RandomInt randomService
        {
            get => _randomService ?? (_randomService = new RandomService());
            set
            {
                if (_randomService != null)
                    throw new InvalidOperationException(nameof(value));

                _randomService = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public int Index()
        {
            return randomService.RandomInt;
        }
    }
}

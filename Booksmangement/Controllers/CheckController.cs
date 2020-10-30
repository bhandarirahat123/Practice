using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Booksmangement.Controllers
{
    public class CheckController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}

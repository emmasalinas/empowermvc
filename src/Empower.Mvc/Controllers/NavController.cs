using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Empower.Mvc.Models;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Empower.Mvc.Controllers
{
    public class NavController : Controller
    {
        // GET: /<controller>/
        public IActionResult TopMenu()
        {
            return View();
        }
    }
}

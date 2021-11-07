using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quete_Razor_Symbole_BP.Models;

namespace Quete_Razor_Symbole_BP.Controllers
{
    public class SalaryController : Controller
    {
        public IActionResult Index()
        {
            List<Salary> salary = new List<Salary>{
                new Salary(500000),
                new Salary(1000000),
                new Salary(300000),
                new Salary(8000000),
                new Salary(400000)
            };

            String conclusion;
            Int32 sum = salary.Sum(m => m.Amount);
            if (sum > 10000000)
            {
                conclusion = "You earn too much money";
            }
            else
            {
                conclusion = "You should ask for a salary raise";
            }
            return View("Index",conclusion);
        }
    }
}

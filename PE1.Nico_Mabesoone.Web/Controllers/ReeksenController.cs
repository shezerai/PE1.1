using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE1.Nico_Mabesoone.Lib;

namespace PE1.Nico_Mabesoone.Web.Controllers
{
    public class ReeksenController : Controller
    {
        public IActionResult Index()
        {
            ReeksService eenService = new ReeksService();
            string teruggave = "Priem Getallen:";
          foreach(int getal in eenService.GeefPriemGetallen(10, 20))
            {
                teruggave += "\n " + getal.ToString();

            }
            teruggave += " \n Even Getallen:";

           foreach(int getal in eenService.GeefReeksEven(10, 20))
            {
                teruggave += "\n " + getal.ToString();
            }
            teruggave += " \n getallen Reeks:";

            foreach (int getal in eenService.GeefReeks(10, 20))
            {
                teruggave += "\n " + getal.ToString();
            }

            return Content(teruggave);
        }
    }
}
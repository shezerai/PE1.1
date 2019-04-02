using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE1.Nico_Mabesoone.Lib;

namespace PE1.Nico_Mabesoone.Web.Controllers
{
    public class TekstenController : Controller
    {
        
        public async Task<IActionResult> Index()
        {
            TekstService eenService = new TekstService();
            String naam = "Nico Mabesoone";

            String teruggave = "normaal:";
            
            teruggave += await eenService.GetTekst(naam, TekstMode.Normal);

            teruggave += "\n reversed:";
            teruggave += await eenService.GetTekst(naam, TekstMode.Reverse);

            teruggave += "\n ASCII:";
            teruggave += await eenService.GetTekst(naam, TekstMode.Ascii);
            return Content(teruggave);
        }
    }
}
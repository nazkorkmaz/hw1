using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using deneme.Models;
using Microsoft.AspNetCore.Mvc;

namespace deneme.Controllers
{
    public class ogrencikontrol : Controller
    {
        denemeContext denemeContext;

        public ogrencikontrol(denemeContext context)
        {
            denemeContext = context;

        }
        public IActionResult Index()
        {
            var ogrenciler = denemeContext.ogrenciler.ToList();
            return View(ogrenciler);
        }

        public IActionResult Detay(int id)
        {
            ogrenciler ogrenciler = denemeContext.ogrenciler.Where(b => b.Id == id).FirstOrDefault();
            if (ogrenciler != null)
            {
                return View(ogrenciler);
            } else
            {
                return NotFound();
            }
        }
    }
}
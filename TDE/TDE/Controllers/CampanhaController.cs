using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TDE.Models;
using TDE.Interfaces;

namespace TDE.Controllers
{
    public class CampanhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Campanha pCampanha)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Campanha pCampanha)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
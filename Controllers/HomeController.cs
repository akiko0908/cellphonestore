using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CellphoneStore.Models;
using CellphoneStore.Data;
using Microsoft.EntityFrameworkCore;

namespace CellphoneStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            var lsProducts = db.Products;
            return View(lsProducts.ToList());
        }

        [HttpPost]
        public IActionResult Search(string stringSearch)
        {
            if (!string.IsNullOrEmpty(stringSearch))
            {
                var lsProducts = db.Products.Where(m => m.product_Name.Contains(stringSearch));
                return View("Index", lsProducts.ToList());
            }
            return RedirectToAction("Index");
        }

        public IActionResult CategoriesView(int? idBrand)
        {
            if (idBrand != null)
            {
                var lsProducts = db.Products.Where(o => o.brand_ID == idBrand).ToList();
                return View("Index", lsProducts);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

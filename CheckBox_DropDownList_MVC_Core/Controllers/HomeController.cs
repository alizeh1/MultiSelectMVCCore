using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheckBox_DropDownList_MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        private DBCtx Context { get; }
        public HomeController(DBCtx _context)
        {
            this.Context = _context;
        }

        public IActionResult Index()
        {
            return View(this.PopulateFruits());
        }

        [HttpPost]
        public IActionResult Index(string[] fruitIds)
        {
            List<SelectListItem> fruits = this.PopulateFruits();
            if (fruitIds != null)
            {
                ViewBag.Message = "Selected Fruits:";
                foreach (string fruitId in fruitIds)
                {
                    SelectListItem selectedFruit = fruits.Find(p => p.Value == fruitId);
                    selectedFruit.Selected = true;
                    ViewBag.Message += "\\n" + selectedFruit.Text;
                }
            }

            return View(fruits);
        }

        private List<SelectListItem> PopulateFruits()
        {
            List<SelectListItem> fruitsList = (from p in this.Context.Fruits
                                               select new SelectListItem
                                               {
                                                   Text = p.FruitName,
                                                   Value = p.FruitId.ToString()
                                               }).ToList();

            return fruitsList;
        }
    }
}
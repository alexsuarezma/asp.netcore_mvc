using ApplicationAlexTryout.Models;
using ApplicationAlexTryout.Models.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationAlexTryout.Controllers
{
    public class ProductController : Controller
    {
        private alex_applicationContext db = new alex_applicationContext();

        public IActionResult Index()
        {
            List<Models.Dto.Product> lst = new List<Models.Dto.Product>();

            using (var db = new Models.DB.alex_applicationContext())
            {
                lst = (from e in db.Products
                       select new Models.Dto.Product
                      {
                          Id = e.Id,
                          Description = e.Description,
                          Price = e.Price,
                      }).ToList();
            }
            
            return View(lst);
        }

        public async Task<IActionResult> Create(int? id)
        {
            Models.DB.Product product = new Models.DB.Product();

            if(id != null)
            {
                product = await db.Products.FindAsync(id);
            }
            return View(product);

        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

            Models.DB.Product product = db.Products.Find(id);

            if (product == null)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Models.DB.Product product)
        {
            if (ModelState.IsValid)
            {
                if(product.Id == 0)
                {
                    db.Products.Add(product);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Create));
                }
                else
                {
                    db.Products.Update(product);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Create), new { Id = 0 } );
                }
            }

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Models.DB.Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Update(product);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), new { Id = product.Id });
            }

            return View(product);
        }

        public ActionResult Delete(int id)
        {
            Models.DB.Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

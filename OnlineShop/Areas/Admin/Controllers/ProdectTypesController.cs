using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProdectTypesController : Controller
    {

        private ApplicationDbContext _db;

        public ProdectTypesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.productTypes.ToList();
            return View(data);
        }

        //  Get Create Acation Method 
        public IActionResult Create()
        {
            return View();

        }

        //Creat Post Acation Method 

        [HttpPost]
        [ValidateAntiForgeryToken]
       public async Task<IActionResult>Create(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.productTypes.Add(productTypes);
                await _db.SaveChangesAsync();
                TempData["save"] = "product type has been Saved";
                return RedirectToAction(nameof(Index));
                 
            }
            return View(productTypes);
        }

       


        // Edit Get  Acation Method 
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();

            }
            var ProductType = _db.productTypes.Find(id);
            if (ProductType==null)
            {
                return NotFound();
            }
            return View(ProductType);
        }

        //Creat Post Acation Method 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes productTypes)
        {
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                await _db.SaveChangesAsync();
                TempData["edit"] = "Product type has been updated";
                return RedirectToAction(nameof(Index));

            }
            return View(productTypes);
        }


        // Details Get  Acation Method 
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var ProductType = _db.productTypes.Find(id);
            if (ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }

        //Creat Post Acation Method 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductTypes productTypes)
        {
            

                return RedirectToAction(nameof(Index));

            
        }
        // Delete Get  Acation Method 
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var ProductType = _db.productTypes.Find(id);
            if (ProductType == null)
            {
                return NotFound();
            }
            return View(ProductType);
        }

        //Delete Post Acation Method 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete( int id,ProductTypes productTypes)
        {
            if (id==null)
            {
                return NotFound();
            }
            if (id!=productTypes.Id)
            {
                return NotFound();
            }
            var productType = _db.productTypes.Find(id);
            if (productType==null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Product type has been deleted";
                return RedirectToAction(nameof(Index));

            }
            return View(productTypes);
        }

    }
}

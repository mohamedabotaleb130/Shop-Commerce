using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _db;
        private IHostingEnvironment _he;

        

        public ProductController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }

        public IActionResult Index()
        {
            var data = (_db.products.Include(c => c.ProductTypes).Include(f => f.SpecialTag).ToList());
            return View(data);
        }
        //post Index Action Method
        [HttpPost]
        
        public IActionResult  Index(decimal? lowAmount, decimal? largeAmount)
        {
            var products = (_db.products.Include(c => c.ProductTypes).Include(f => f.SpecialTag)
                .Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList());
            if (lowAmount == null || largeAmount == null)
            {
                products = _db.products.Include(c => c.ProductTypes).Include(f => f.SpecialTag).ToList();


            }
            return View(products);
            }
            //Get Create method
            public IActionResult Create()
        {
            ViewData["productTypeId"] = new SelectList(_db.productTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.specialTags.ToList(), "Id", "Name");

            return View();
        }
        //Post Create method
        [HttpPost]
        
        public async Task<IActionResult> Create(Product product,IFormFile image)
        {
            if (ModelState.IsValid)
            {

                var searchProduct = _db.products.FirstOrDefault(c => c.Name == product.Name);
                if (searchProduct!=null)
                {

                    ViewBag.message = "This Product is Already Exist ";
                    ViewData["productTypeId"] = new SelectList(_db.productTypes.ToList(), "Id", "ProductType");
                    ViewData["TagId"] = new SelectList(_db.specialTags.ToList(), "Id", "Name");
                     return View(product);

                }
                
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    product.Image = "Images/" + image.FileName;
                }
                if (image == null)
                {
                    product.Image = "Images/noimage.JPG";
                }


                _db.products.Add(product);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof (Index));
            }
            return View(product);
        }
        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
            ViewData["productTypeId"] = new SelectList(_db.productTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.specialTags.ToList(), "Id", "Name");
            if (id == null)
            {
                return NotFound();
            }

            var product = _db.products.Include(c => c.ProductTypes).Include(c => c.SpecialTag)
                .FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //post Edit Action Method
        [HttpPost]
        public async Task<IActionResult> Edit(Product product, IFormFile image)
        {
            if (ModelState.IsValid)

            {
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    product.Image = "Images/" + image.FileName;
                }
                if (image == null)
                {
                    product.Image = "Images/noimage.JPG";
                }


                _db.products.Update(product);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);

        }
        //Get Details Action Method
        public ActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();

            }
            var product = _db.products.Include(c => c.ProductTypes).Include(m => m.SpecialTag).FirstOrDefault(v => v.Id==id);
            if ( product==null)
            {
                return NotFound();
            }

            return View(product);
        }
        //Get Delete Action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.products.Include(c => c.ProductTypes).Include(m => m.SpecialTag).Where(v => v.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //post Delete Action Method
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var product = _db.products.FirstOrDefault(c => c.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            _db.products.Remove(product);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




    }
}

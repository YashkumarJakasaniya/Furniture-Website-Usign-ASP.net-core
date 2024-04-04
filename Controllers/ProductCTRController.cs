/*using FURNITURE.Data;
using FURNITURE.Models;
using FURNITURE.DbContextFiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FURNITURE.Controllers
{
    public class ProductCTRController : Controller
    {
        private readonly IWebHostEnvironment environment;
        private readonly FurnitureDbContext dbContext;

        public ProductCTRController(IWebHostEnvironment environment, ProductDbContext dbContext)
        {
            this.environment = environment;
            this.dbContext = dbContext;
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public AddProductViewModel AddProductViewModel { get; set; } = new AddProductViewModel();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddPRODUCT()
        {
            return View();
        }

        // GET: Product/Create


        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPRODUCT([Bind("Id,ImageFileName,Name,Brand,Category,Description,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.CreatedAt = DateTime.Now;
                dbContext.Add(product);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("List");
            }
            return View(product);
        }
        public async Task<IActionResult> List()
        {
            var products = await dbContext.Products.ToListAsync();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var student = await dbContext.Products.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ImageFileName,Name,Brand,Category,Description,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingProduct = await dbContext.Products.FindAsync(product.Id);

                    if (existingProduct == null)
                    {
                        return NotFound();
                    }

                    existingProduct.ImageFileName = product.ImageFileName;
                    existingProduct.Name = product.Name;
                    existingProduct.Brand = product.Brand;
                    existingProduct.Category = product.Category;
                    existingProduct.Description = product.Description;
                    existingProduct.Price = product.Price;
                    existingProduct.CreatedAt = DateTime.Now;

                    await dbContext.SaveChangesAsync();

                    return RedirectToAction(nameof(List));
                }
                catch (Exception)
                {
                    // Handle exception appropriately
                    return StatusCode(500);

                }
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await dbContext.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            dbContext.Products.Remove(product);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }


    }
}
*/
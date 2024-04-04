using FURNITURE.Data;
using FURNITURE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FURNITURE.Controllers
{
    public class HomeController : Controller
    {
        private readonly FurnitureDbContext DbContext;

        public HomeController(FurnitureDbContext dbContext)
        {
            this.DbContext = dbContext;
        }


        public IActionResult CartPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(FurnitureViewModel viewModel)
        {
            var furdata = new FurnitureDataModel
            {
                Name = viewModel.Name,
                Price = viewModel.Price,
                Description = viewModel.Description,
            };

            await DbContext.FurnitureData.AddAsync(furdata);
            await DbContext.SaveChangesAsync();

            return RedirectToAction("Index","FurnitureData"); // Redirect to the updated index page
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var students = await DbContext.FurnitureData.ToListAsync();
            return View(students);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

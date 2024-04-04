using FURNITURE.CartServices;
using FURNITURE.Data;
using FURNITURE.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ProductsController : Controller
{
    private readonly FurnitureDbContext DbContext;
    private readonly ICartService _cartService;

    public ProductsController(FurnitureDbContext dbContext,ICartService cartService)
    {
        this.DbContext = dbContext;
        this._cartService = cartService;
    }

    /* [HttpPost]

     public async Task<IActionResult> StudyAdmin(ProductsDataView viewModel)
     {
         {
             var furdata = new FurnitureDataModel
             {
                 Name = viewModel.Name,
                 Price = viewModel.Price,
                 ImagePath = viewModel.ImagePath,

             };
             await DbContext.FurnitureData.AddAsync(furdata);
             await DbContext.SaveChangesAsync();
         }

         return View();
     }*/


    [HttpGet]
    public async Task<IActionResult> StudyTable()
    {
        var studyProducts = await DbContext.ProductsData.ToListAsync();
        return View(studyProducts);
    }
    [HttpGet]
    public async Task<IActionResult> SofaPage()
    {
        var studyProducts1 = await DbContext.SofaData.ToListAsync();
        return View(studyProducts1);
    }
    [HttpGet]
    public async Task<IActionResult> ChairPage()
    {
        var studyProducts2 = await DbContext.Chairtbl.ToListAsync();
        return View(studyProducts2);
    }
    public async Task<IActionResult> ProductDetail(int id)
    {
        var product = await DbContext.Chairtbl.FirstOrDefaultAsync(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }
    
    public async Task<IActionResult> SofaDetail(int id)
    {
        var product1 = await DbContext.SofaData.FirstOrDefaultAsync(p => p.Id == id);

        if (product1 == null)
        {
            return NotFound();
        }

        return View(product1);
    }
    public async Task<IActionResult> StTableDetail(int id)
    {
        var product1 = await DbContext.ProductsData.FirstOrDefaultAsync(p => p.Id == id);

        if (product1 == null)
        {
            return NotFound();
        }

        return View(product1);
    }
    // ProductsController.cs

    [HttpGet]
     public async Task<IActionResult> CartPage()
    {
        var cartpage = await DbContext.CartData.ToListAsync();
        return View(cartpage);
    }
    [HttpPost]
    public async Task<IActionResult> CartPage1(int id)
    {
        var product = await DbContext.Chairtbl.FirstOrDefaultAsync(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        var furdata = new AddCart()
        {

            ProductName = product.Name,
            ProductPrice = product.Price,
            Images = product.ImagePath,
        };

        await DbContext.CartData.AddAsync(furdata);
        await DbContext.SaveChangesAsync();

        return RedirectToAction("CartPage");
    }
    [HttpPost]
    public async Task<IActionResult> CartPage2(int id)
    {
        var product = await DbContext.SofaData.FirstOrDefaultAsync(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        var furdata = new AddCart()
        {

            ProductName = product.Name,
            ProductPrice = product.Price,
            Images = product.ImagePath,
        };

        await DbContext.CartData.AddAsync(furdata);
        await DbContext.SaveChangesAsync();

        return RedirectToAction("CartPage");
    }

    [HttpPost]
    public async Task<IActionResult> CartPage3(int id)
    {
        var product = await DbContext.ProductsData.FirstOrDefaultAsync(p => p.Id == id);

        if (product == null)
        {
            return NotFound();
        }

        var furdata = new AddCart()
        {

            ProductName = product.Name,
            ProductPrice = product.Price,
            Images = product.ImagePath,
        };

        await DbContext.CartData.AddAsync(furdata);
        await DbContext.SaveChangesAsync();

        return RedirectToAction("CartPage");
    }

    [HttpPost]
    public async Task<IActionResult> CartPage(int productId)
    {
        var cartItemToRemove = await DbContext.CartData.FirstOrDefaultAsync(item => item.ProductId == productId);

        if (cartItemToRemove != null)
        {
            DbContext.CartData.Remove(cartItemToRemove);
            await DbContext.SaveChangesAsync();
        }

        return RedirectToAction("CartPage");
    }
    public IActionResult Checkout()
    {
        return RedirectToAction("Index","Home");
    }

    /*[HttpPost]
    public IActionResult ProcessCheckout(List<AddCart> items)
    {
        if (items == null || items.Count == 0)
        {
            return BadRequest("Invalid checkout data. Items list is null or empty.");
        }

        foreach (var item in items)
        {
            var checkoutData = new CheckoutViewModel 
            {
                ProductId = item.ProductId,
                ProductName = item.ProductName,
                ProductPrice = item.ProductPrice,
                Images = item.Images
            };

            DbContext.CheckoutData.Add(checkoutData);
        }

        DbContext.SaveChanges();

        var savedItemsCount = DbContext.CheckoutData.Count();

        if (savedItemsCount > 0)
        {
            return RedirectToAction("ThankYou");
        }
        else
        {
            return BadRequest("Failed to save the order. Please try again later.");
        }
    }
    public IActionResult ThankYou()
    {
        return View();
    }*/
}




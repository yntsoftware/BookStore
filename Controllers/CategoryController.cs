using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using BookStore.Data;

namespace BookStore.Controllers;

public class CategoryController : Controller
{
  private readonly ILogger<CategoryController> _logger;
  private readonly ApplicationDbContext _db;
  public CategoryController(ILogger<CategoryController> logger, ApplicationDbContext db)
  {
    _logger = logger;
    _db = db;
  }

  public IActionResult Index()
  {
    List<Category> objCategoryList = _db.Categories.ToList();
    return View(objCategoryList);
  }


  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}

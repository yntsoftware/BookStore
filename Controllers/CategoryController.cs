using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers;

public class CategoryController : Controller
{
  private readonly ILogger<CategoryController> _logger;

  public CategoryController(ILogger<CategoryController> logger)
  {
      _logger = logger;
  }

  public IActionResult Index()
  {
      return View();
  }


  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
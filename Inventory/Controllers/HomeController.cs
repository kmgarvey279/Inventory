using Microsoft.AspNetCore.Mvc;
using Inventory.Models;

namespace Inventory.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
      // return View(Item.GetAll());
    }

  }
}

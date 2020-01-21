using Microsoft.AspNetCore.Mvc;

namespace Physician.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
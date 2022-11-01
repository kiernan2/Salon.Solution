using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;

namespace Salon.Collections
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
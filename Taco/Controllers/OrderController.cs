using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Taco.Models;
using System.Collections.Generic;
using System.Linq;

namespace Taco.Controllers
{
  public class OrderController : Controller
  {
    private readonly TacoContext _db;
    public OrderController(TacoContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(model);
    }
  }
}
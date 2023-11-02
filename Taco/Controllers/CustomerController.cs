using Microsoft.AspNetCore.Mvc;
using Taco.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Taco.Controllers
{
  public class CustomersController : Controllers
  {
    private readonly TacoContext _db;
    public CustomersController(TacoContext db)
    {
      _db =db;
    }
    public ActionResult Index()
    List<Customer> model = _dbCustomer.Include(Customers => Customers.Order)
    return View(model);
  }
}
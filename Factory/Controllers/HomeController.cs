using Microsoft.AspNetCore.Mvc;
using Factory.Models;
// using System.Collections.Generic;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }
    // [HttpGet("/")]
    // public ActionResult Index()
    // {
    //   var thisJoin = _db.EngineerMachine
    //   .Include(engineerMachine => engineerMachine.JoinEntities)
    //   .ThenInclude(join => join.Engineer)
    //   .ThenInclude(join => join.Machine);
    //   return View(thisJoin);
    // }
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Engineers = _db.Engineers;
      ViewBag.Machines = _db.Machines;
      return View();
    }
  }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string str = "Xin chào " + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
        ViewBag.TB = str;
        return View();
    }
}

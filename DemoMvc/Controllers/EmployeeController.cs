using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;

public class EmployeeController : Controller{
    public IActionResult Index(){
        return View();
    }

    public IActionResult Welcome(){
        return View();
    }
}
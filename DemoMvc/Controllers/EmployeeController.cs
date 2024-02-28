using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;

public class EmployeeController : Controller{
    public IActionResult Index(){
        return View();
    }
    [HttpPost]

    public IActionResult Index(string MaNV, string TenNV, int Tuoi, float Luong){
            String str = "Mã Nhân Viên: " + MaNV + " - Tên Nhân Viên: " + TenNV.ToUpper() + " -  Tuổi: " + Tuoi + " - Lương: "+ Luong;
        ViewBag.A = str;
        return View();
    }
}
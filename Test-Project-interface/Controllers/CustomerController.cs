using Microsoft.AspNetCore.Mvc;

namespace Test_Project_interface.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Lienhe()
        {
            return View();
        } 
        public IActionResult TinTuc()
        {
            return View();
        }      
        public IActionResult GioiThieu()
        {
            return View();
        }  
        public IActionResult Trangchu()
        {
            return View();
        }
    }
}

using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {

        private static DataService dataService = new DataService();

        [HttpGet("")]
        public IActionResult Index()
        {
            Band[] bands = dataService.GetAll();
            return View(bands);
        }
    }
}




//[HttpGet("")]
//public IActionResult Index()
//{
//    Computer[] model = dataService.GetAll();
//    return View(model);
//}

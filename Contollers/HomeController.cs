using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers {
    public class HomeController : Controller{
        //localhost/home denilince çağrılan action
        public IActionResult Index(){
            return View();
        }
    }
}
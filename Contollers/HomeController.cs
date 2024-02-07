using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers {
    public class HomeController : Controller{
        //localhost/home denilince çağrılan action
        public string Index(){
            return "home/index";
        }
    }
}
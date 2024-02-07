using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Contollers{
    public class MeetingController : Controller{

        public string Index(){
            return "meeting/index";
        }
    }
}
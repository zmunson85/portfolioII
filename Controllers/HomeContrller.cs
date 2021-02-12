using System;
using Microsoft.AspNetCore.Mvc;
namespace PortIIController.Controllers
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Home()
        {
            return View("home");
        }

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("projects");
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }

        [HttpPost("process")]
        public ViewResult Process(string name, string email, string message)
        {
            return View("Index");
        }
    }
}
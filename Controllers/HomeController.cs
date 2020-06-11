using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DojoSurvey.Models;


namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]

        public ViewResult Index()
        {
            return View();
        }


        [HttpPost("survey")]
        public IActionResult FormSubmit(Survey yourSurvey)
        {
            

            return View("FormSubmit", yourSurvey);
        }
    }
}
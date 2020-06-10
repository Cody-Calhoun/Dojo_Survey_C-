using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]

        public ViewResult Index()
        {
            return View();
        }


        [HttpPost("form")]
        public IActionResult FormSubmit(string Name, string dojo_location, string fav_lang, string comment)
        {
            ViewBag.Name = Name;
            ViewBag.dojo_location = dojo_location;
            ViewBag.fav_lang = fav_lang;
            ViewBag.comment = comment;

            return View();
        }
    }
}
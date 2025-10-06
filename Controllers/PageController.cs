using Microsoft.AspNetCore.Mvc;
using System;
using YourProjectName.Models;

namespace YourProjectName.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        [Route("Page/Greet/{name}")]
        public IActionResult Greet(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(MessageModel model)
        {
            if (ModelState.IsValid)
            {
                return View("EditResult", model);
            }
            return View(model);
        }
    }
}
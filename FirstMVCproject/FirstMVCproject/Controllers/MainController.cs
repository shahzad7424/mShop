using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCproject.Models;
using Microsoft.AspNetCore.Mvc;
 

namespace FirstMVCproject.Controllers
{
    public class MainController : Controller
    {
        private april2019db1Context ORM = null;
        public MainController(april2019db1Context _ORM)
        {

            ORM = _ORM;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult addmovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addmovie(TMovie tm)
        {
            try
            {
                ORM.TMovie.Add(tm);
                ORM.SaveChanges();
                ViewBag.Message = "Movie is added successfuly";

            }
            catch (Exception ex)
            {

                ViewBag.Message = ex;
            }
            return View();
        }
    }
}
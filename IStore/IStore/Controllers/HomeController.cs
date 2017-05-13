using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IStore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }

        /// <summary>
        /// Метод Basket представляет корзину пользувателя
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public ActionResult Basket()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
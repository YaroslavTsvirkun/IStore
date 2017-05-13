using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IStore.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        /// <summary>
        /// Метод Index выдает список доступных курсов
        /// </summary>
        /// <returns>Возращает представление Views/Courses/Index</returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Метод CSharp выдает курс по програмированию на языке C#
        /// </summary>
        /// <returns>Возращает представление Views/Courses/CSharp</returns>
        [HttpGet]
        public ActionResult CSharp()
        {
            return View();
        }

        /// <summary>
        /// Метод CSS выдает курс по програмированию на языке - стилей CSS
        /// </summary>
        /// <returns>Возращает представление Views/Courses/CSS</returns>
        [HttpGet]
        public ActionResult CSS()
        {
            return View();
        }

        /// <summary>
        /// Метод FSharp выдает курс по програмированию на языке F#
        /// </summary>
        /// <returns>Возращает представление Views/Courses/FSharp</returns>
        [HttpGet]
        public ActionResult FSharp()
        {
            return View();
        }

        /// <summary>
        /// Метод Html выдает курс по програмированию на языке - разметки HTML
        /// </summary>
        /// <returns>Возращает представление Views/Courses/Html</returns>
        [HttpGet]
        public ActionResult Html()
        {
            return View();
        }

        /// <summary>
        /// Метод Java выдает курс по програмированию на языке Java
        /// </summary>
        /// <returns>Возращает представление Views/Courses/Java</returns>
        [HttpGet]
        public ActionResult Java()
        {
            return View();
        }

        /// <summary>
        /// Метод JavaScript выдает курс по програмированию на языке JavaScript
        /// </summary>
        /// <returns>Возращает представление Views/Courses/JavaScript</returns>
        [HttpGet]
        public ActionResult JavaScript()
        {
            return View();
        }

        /// <summary>
        /// Метод SQL выдает курс по програмированию на языке SQL
        /// </summary>
        /// <returns>Возращает представление Views/Courses/SQL</returns>
        [HttpGet]
        public ActionResult SQL()
        {
            return View();
        }

        /// <summary>
        /// Метод TypeScript выдает курс по програмированию на языке TypeScript
        /// </summary>
        /// <returns>Возращает представление Views/Courses/TypeScript</returns>
        [HttpGet]
        public ActionResult TypeScript()
        {
            return View();
        }
    }
}
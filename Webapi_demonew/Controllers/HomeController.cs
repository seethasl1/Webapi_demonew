using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Webapi_demonew.Models;
using Webapi_demonew.Repositories;

namespace Webapi_demonew.Controllers
{
    public class HomeController : Controller
    {
        Icomment Icom;
        public HomeController()
        {
            Icom = new Comments();
        }
        [HttpGet]
        public ActionResult InsertComment()
        {
            return View(new Comment());
        }
        public ActionResult Index()
        {
            

            return View();
        }
    }
}

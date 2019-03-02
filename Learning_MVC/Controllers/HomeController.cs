using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Application.BusinessLogic;
using Application.Models;

namespace Learning_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var users = UsersProcessor.ReadAll();

            return Content(JsonConvert.SerializeObject(users));
        }
    }
}
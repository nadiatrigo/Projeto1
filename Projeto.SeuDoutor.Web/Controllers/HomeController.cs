using Projeto.SeuDoutor.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.SeuDoutor.Web.Controllers
{    

    public class HomeController : Controller
    {
        private readonly IUsuarioAppService usuarioAppService;

        public HomeController(IUsuarioAppService usuarioAppService)
        {
            this.usuarioAppService = usuarioAppService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

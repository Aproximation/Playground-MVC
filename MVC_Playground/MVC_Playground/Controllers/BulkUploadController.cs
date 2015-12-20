using MVC_Playground.Logic.Filters;
using MVC_Playground.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Playground.Controllers
{
    public class BulkUploadController : Controller
    {
        [HeaderFooterFilter]
        [AdminFilter]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }
    }
}
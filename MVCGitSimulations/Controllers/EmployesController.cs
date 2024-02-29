using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGitSimulations.Controllers
{
    public class EmployesController : Controller
    {
        // GET: Employes
        public ActionResult Index()
        {
            return View();
        }
    }
}
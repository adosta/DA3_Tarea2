using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estados.Models;

namespace Estados.Controllers
{
    public class MunicipioController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Municipio
        public ActionResult Index()
        {
            return View();
        }

       /* public JsonResult getJsonList(int id)
        {
            var municipios = db..ToList();
            return Json(municipios, JsonRequestBehavior.AllowGet);
        }*/
    }
}
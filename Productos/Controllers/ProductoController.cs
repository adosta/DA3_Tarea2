using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DA3___primero.Models;

namespace DA3___primero.Controllers
{
    public class ProductoController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Producto
        
        public JsonResult getJsonList()
        {
            var productos = db.productos.ToList();
            return Json(productos, JsonRequestBehavior.AllowGet);
        }

        public JsonResult editProducto(int id)
        {
            var producto = db.productos.Find(id);
            var resultado = new { id = producto.productoID, nombre = producto.nombre, precio = producto.precio };

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult editProducto(int id, string nombre, int precio)
        {
            var respuesta = new { funciono = false };

            try
            {
                var producto = db.productos.Find(id);
                producto.nombre = nombre;
                producto.precio = precio;
                int registrosModificados = db.SaveChanges();

                if (registrosModificados > 0)
                {
                    respuesta = new { funciono = true };
                }
            }
            catch { }

            return Json(respuesta);

        }

        [HttpPost]
        public JsonResult createProducto(Producto producto)
        {
            var respuesta = new { funciono = true };

            try
            {
                db.productos.Add(producto);
                int registrosModificados = db.SaveChanges();

                if (registrosModificados > 0)
                {
                    respuesta = new { funciono = true };
                }
            }
            catch { }

            return Json(respuesta);
           
        }

        [HttpPost]
        public JsonResult eraseProducto(int id)
        {
            var respuesta = new { funciono = true };

            try
            {
                var producto = db.productos.Find(id);
                db.productos.Remove(producto);
                int registrosModificados = db.SaveChanges();

                if (registrosModificados > 0)
                {
                    respuesta = new { funciono = true };
                }
            }
            catch { }

            return Json(respuesta);
        }

        /*public class AllowCrossSiteJson : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
                base.OnActionExecuting(filterContext);
            }
        }*/
    }
}
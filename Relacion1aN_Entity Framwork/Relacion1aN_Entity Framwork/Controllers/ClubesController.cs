using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Servicios;


namespace Relacion1aN_Entity_Framwork.Controllers
{
    public class ClubesController : Controller
    {
        JugadorServicio Jugadores = new JugadorServicio();
        ClubesServicios Clubes = new ClubesServicios();

        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Agregar(Club C)
        {
            Clubes.Agregar(C);
            return Redirect("/Clubes/Lista");
        }


        public ActionResult Lista()
        {
            return View(Clubes.ObtenerTodos());
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            Club c = Clubes.ObtenerPorId(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Modificar(Club c)
        {
            Clubes.Modificar(c);
            return Redirect("/Clubes/Lista");
        }

        public ActionResult EliminarPorId(int id)
        {

            Clubes.EliminarPorId(id);
            return RedirectToAction("Lista");
        }
    }
}
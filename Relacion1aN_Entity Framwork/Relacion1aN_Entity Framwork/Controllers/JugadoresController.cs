using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Servicios;
using System.ComponentModel.DataAnnotations;

namespace Relacion1aN_Entity_Framwork.Controllers
{
    public class JugadoresController : Controller
    {
        JugadorServicio Jugadores = new JugadorServicio();
        ClubesServicios Clubes = new ClubesServicios();


        [HttpGet]
        public ActionResult Agregar()
        {
            ViewBag.ListaClubes = Clubes.ObtenerTodos();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Agregar([Bind(Include = "idJugador,Apellido,Edad,idClub")] Jugador j)
        {
            ViewBag.ListaClubes = Clubes.ObtenerTodos();
            if (ModelState.IsValid)
            {

                Jugadores.Agregar(j);
                return Redirect("/Jugadores/Lista");
            }
            return View(j);
        }

        [HttpGet]
        public ActionResult Modificar(int id)
        {
            ViewBag.ListaClubes = Clubes.ObtenerTodos();
            Jugador j = Jugadores.ObtenerPorId(id);
            return View(j);
        }

        [HttpPost]
        public ActionResult Modificar(Jugador j)
        {
            Jugadores.Modificar(j);
            return RedirectToAction("Lista");
        }

        public ActionResult Lista()
        {
            return View(Jugadores.ObtenerTodos());
        }
        public ActionResult Eliminar(int id)
        {
            Jugadores.Eliminar(id);
            return Redirect("/Jugadores/Lista");
        }
    }
}

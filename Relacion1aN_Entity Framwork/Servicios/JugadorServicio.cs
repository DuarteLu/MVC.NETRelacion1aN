using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;

namespace Servicios
{
    public class JugadorServicio
    {
        JugadorEntities ctx = new JugadorEntities();

        public void Agregar(Jugador j)
        {
            ctx.Jugador.Add(j);
            ctx.SaveChanges();

        }

        public Jugador ObtenerPorId(int id)
        {
            return ctx.Jugador.Find(id);
        }

        public void Eliminar(int id)
        {
            Jugador j = ctx.Jugador.Find(id);
            ctx.Jugador.Remove(j);
            ctx.SaveChanges();
        }

        public List<Jugador> ObtenerTodos()
        {
            return ctx.Jugador.ToList();
        }

        public void Modificar(Jugador j)
        {
            Jugador NuevoJugador = new Jugador();
            NuevoJugador = ctx.Jugador.Find(j.idJugador);
            NuevoJugador.Apellido = j.Apellido;
            NuevoJugador.Edad = j.Edad;
            NuevoJugador.idClub = j.idClub;
            ctx.SaveChanges();
        }
    }
}

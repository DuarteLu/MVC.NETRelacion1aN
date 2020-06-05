using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;

namespace Servicios
{
    public class ClubesServicios
    {
        JugadorEntities ctx = new JugadorEntities();

        public List<Club> ObtenerTodos()
        {
            return ctx.Club.ToList();
        }

        public void Agregar(Club C)
        {
            ctx.Club.Add(C);
            ctx.SaveChanges();
        }

        public Club ObtenerPorId(int id)
        {
            return ctx.Club.Find(id);

        }


        public void Modificar(Club c)
        {

            Club ClubViejo = new Club();
            ClubViejo = ObtenerPorId(c.idClub);
            ClubViejo.Nombre = c.Nombre;
            ctx.SaveChanges();
        }


        public void EliminarPorId(int id)
        {
            var ListaJugadores = (from e in ctx.Jugador
                                  where e.idClub == id
                                  select e);

            foreach (var Jugador in ListaJugadores)
            {
                ctx.Jugador.Remove(Jugador);
            }
            Club ClubAEliminar = ctx.Club.Find(id);
            ctx.Club.Remove(ClubAEliminar);
            ctx.SaveChanges();

        }
    }
}

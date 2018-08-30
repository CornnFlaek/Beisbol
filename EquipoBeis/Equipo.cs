using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadDeOrigen { get; set; }
        public string Entrenador { get; set; }
        public Estadio estadio{get; set;}

        public List<Jugador> jugadores { get; set; }

        public Equipo()
        {
            jugadores = new List<Jugador>();
            Nombre = "Nombre de equipo";
            CiudadDeOrigen = "Ciudad";
            Entrenador = "Entrenador";
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
        }
    }
}
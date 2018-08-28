using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador()
        {
            Nombre = "Nombre de jugador";
            Numero = "S/N";
        }

        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
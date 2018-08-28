using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo equipo1 = new Equipo();
            equipo1.Nombre = "Counter-Terrorists\n";
            
            equipo1.jugadores.Add(new Jugador("El Woss", "1"));
            equipo1.jugadores.Add(new Jugador("Cornn Flaek", "2"));
            equipo1.jugadores.Add(new Jugador("Bunny Hop", "3"));
            equipo1.jugadores.Add(new Jugador("Machado el Cumbiero", "4"));
            equipo1.jugadores.Add(new Jugador("Klinga", "5"));
            equipo1.jugadores.Add(new Jugador("Cereza", "6"));
            equipo1.jugadores.Add(new Jugador("El Moss", "7"));
            equipo1.jugadores.Add(new Jugador("Olga", "8"));
            equipo1.jugadores.Add(new Jugador("Promises", "9"));
            equipos.Add(equipo1);

            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Terrorists\n";
            equipo2.jugadores.Add(new Jugador("Antolin", "1"));
            equipo2.jugadores.Add(new Jugador("Shroud", "2"));
            equipo2.jugadores.Add(new Jugador("Skadoodle", "3"));
            equipo2.jugadores.Add(new Jugador("Mang0", "4"));
            equipo2.jugadores.Add(new Jugador("Sneaky", "5"));
            equipo2.jugadores.Add(new Jugador("Leffen", "6"));
            equipo2.jugadores.Add(new Jugador("Go1", "7"));
            equipo2.jugadores.Add(new Jugador("Vortex", "8"));
            equipo2.jugadores.Add(new Jugador("German", "9"));
            equipos.Add(equipo2);

            foreach (Equipo elemento in equipos)
            {
                Console.WriteLine("Equipo: " + elemento.Nombre);
                foreach (Jugador jugador in elemento.jugadores)
                {
                    Console.WriteLine("Nombre del jugador: " + jugador.Nombre);
                    Console.WriteLine("Numero: " + jugador.Numero);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
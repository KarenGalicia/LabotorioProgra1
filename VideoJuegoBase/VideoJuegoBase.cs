using System;

namespace LabotorioProgra1.VideoJuegoBase
{
    internal class VideoJuego
    {
        // Propiedades
        public string Titulo { get; set; }
        public string Desarrolladora { get; set; }
        public double Calificacion { get; set; }
        public int AnioLanzamiento { get; set; }
        public bool EnPartida { get; private set; }

        // Constructor
        public VideoJuego(string titulo, string desarrolladora, double calificacion, int anioLanzamiento)
        {
            Titulo = titulo;
            Desarrolladora = desarrolladora;
            Calificacion = calificacion;
            AnioLanzamiento = anioLanzamiento;
            EnPartida = false;
        }

        // Método para mostrar información del juego
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Desarrolladora: {Desarrolladora}");
            Console.WriteLine($"Calificación: {Calificacion}");
            Console.WriteLine($"Año de Lanzamiento: {AnioLanzamiento}");
        }

        // Método para iniciar la partida
        public void IniciarPartida()
        {
            if (!EnPartida)
            {
                Console.WriteLine($"Iniciando partida de {Titulo}...");
                EnPartida = true;
            }
            else
            {
                Console.WriteLine("¡La partida ya está en curso!");
            }
        }

        // Método para detener la partida
        public void DetenerPartida()
        {
            if (EnPartida)
            {
                Console.WriteLine($"Deteniendo partida de {Titulo}...");
                EnPartida = false;
            }
            else
            {
                Console.WriteLine("¡No hay partida en curso!");
            }
        }
    }
}
using System;

class VideoJuego
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
    public virtual void MostrarInformacion()
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

class VideoJuegoJpf : VideoJuego
{
    // Propiedades específicas para juegos de rol
    public int NivelMaximo { get; set; }
    public string MundoFantasia { get; set; }

    // Constructor
    public VideoJuegoJpf(string titulo, string desarrolladora, double calificacion, int anioLanzamiento, int nivelMaximo, string mundoFantasia)
        : base(titulo, desarrolladora, calificacion, anioLanzamiento)
    {
        NivelMaximo = nivelMaximo;
        MundoFantasia = mundoFantasia;
    }

    // Método para mostrar información del juego RPG
    public override void MostrarInformacion()
    {
        base.MostrarInformacion(); // Llamada al método de la clase bas
        Console.WriteLine($"Nivel Máximo: {NivelMaximo}");
        Console.WriteLine(value: $"Mundo de Fantasía: {MundoFantasia}");
    }
}

// Ejemplo de uso de la clase base VideoJuego
new VideoJuego(titulo: """The Witcher 3: Wild Hunt""", desarrolladora: """CD Projekt Red""", 9.7, anioLanzamiento: 2015).MostrarInformacion();
new VideoJuego(titulo: """The Witcher 3: Wild Hunt""", desarrolladora: """CD Projekt Red""", 9.7, anioLanzamiento: 2015).IniciarPartida();
new VideoJuego(titulo: """The Witcher 3: Wild Hunt""", desarrolladora: """CD Projekt Red""", 9.7, anioLanzamiento: 2015).IniciarPartida(); // Intentar iniciar partida nuevamente
new VideoJuego(titulo: """The Witcher 3: Wild Hunt""", desarrolladora: """CD Projekt Red""", 9.7, anioLanzamiento: 2015).DetenerPartida();
new VideoJuego(titulo: """The Witcher 3: Wild Hunt""", desarrolladora: """CD Projekt Red""", 9.7, anioLanzamiento: 2015).DetenerPartida(); // Intentar detener partida nuevamente

Console.WriteLine();


VideoJuegoJpf = new VideoJuegoJpf("The Elder Scrolls V: Skyrim", "Bethesda Game Studios", 9.3, 2011, 50, "Mundo abierto de fantasía");
juegoRPG.MostrarInformacion();
juegoRPG.IniciarPartida();
juegoRPG.IniciarPartida(); // Intentar iniciar partida nuevamente
juegoRPG.DetenerPartida();
juegoRPG.DetenerPartida(); // Intentar detener partida nuevamente

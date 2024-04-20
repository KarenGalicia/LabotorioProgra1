using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

    // Constructor adicional que proporciona valores predeterminados
    public VideoJuegoJpf()
        : base("", "", 0, 0) // Valores predeterminados
    {
        // Asigna valores predeterminados para las propiedades específicas de la clase derivada
        NivelMaximo = 0;
        MundoFantasia = "";
    }
}
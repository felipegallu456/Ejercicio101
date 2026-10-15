using System;

namespace Library
{
    public class Equipo
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public bool Disponibilidad { get; private set; }

        public Equipo(string codigo, string nombre)
        {
            this.Codigo=codigo;
            this.Nombre=nombre;
            Disponibilidad=true;
        }
        public void EstadoNoDisponible()
        {
            Disponibilidad=false;
        }
        public void EstadoDisponible()
        {
            Disponibilidad=true;
        }
    }
}



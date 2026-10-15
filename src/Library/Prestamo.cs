using System;

namespace Library
{
    public class Prestamo
    {
        public Estudiante Estudiante { get; set; }

        public DateTime FechaDelPrestamo { get; set; }

        public DateTime? FechaDeDevolución { get; private set; }

        public Equipo Equipo { get; set; }

        public bool PrestamoActivo { get; private set; }

        public Prestamo(Estudiante estudiante, Equipo equipo)
        {
            this.Equipo=equipo;
            this.Estudiante=estudiante;
            this.FechaDelPrestamo=DateTime.Now;
            PrestamoActivo=true;
            equipo.EstadoNoDisponible();
        }
        public void PrestamoRegistrado()
        {
            PrestamoActivo=false;
            FechaDeDevolución=DateTime.Now;
            Equipo.EstadoDisponible();


        }
    }
}


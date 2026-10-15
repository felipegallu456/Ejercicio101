using System;

namespace Library
{
    public class Estudiante
    {
        public string Nombre { get; set; }

        public string Documento { get; set; }

        public bool Disponibilidad {get; private set; }

        public Estudiante(string nombre, string documento)
        {
            this.Nombre=nombre;
            this.Documento=documento;
            
        }
    }
}
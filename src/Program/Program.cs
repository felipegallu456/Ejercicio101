//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Library;

namespace Ucu.Poo.RegistrarPrestamos
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Equipo notebook = new Equipo("EQP-001", "Notebook Intel Core");
            Equipo proyector = new Equipo("EQP-002", "Proyector Magcubic");

            Estudiante estudiante1 = new Estudiante("Felipe Galluzzo", "5714478-4");
            Prestamo prestamoActual = null;
            if (notebook.Disponibilidad)
            {
                prestamoActual = new Prestamo(estudiante1, notebook);
                Console.WriteLine("Prestamo registrado");
            }
            else
            {
                Console.WriteLine($"El equipo no esta disponible de momento");
            }
            Estudiante estudiante2 = new Estudiante("Alessio Moreira", "4378943-7");
            if (notebook.Disponibilidad)
            {
                var segundoPrestamo = new Prestamo(estudiante2, notebook);
                Console.WriteLine("Prestamo registrado");
            }
            else
            {
                Console.WriteLine("Prestamo rechazado, el equipo no esta disponible");
            }
            if (prestamoActual != null)
            {
                prestamoActual.PrestamoRegistrado();
            }
        }
    }
}
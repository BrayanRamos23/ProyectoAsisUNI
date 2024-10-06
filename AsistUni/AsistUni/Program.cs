using System;

namespace AsistUni
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int cantidadEstudiantes = int.Parse(Console.ReadLine());

            List<Universidad.Estudiante> estudiantes = new List<Universidad.Estudiante>();

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"\nIngrese los datos del estudiante {i + 1}:");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Total de Sesiones: ");
                int totalSesiones = int.Parse(Console.ReadLine());

                Console.Write("Sesiones Asistidas: ");
                int sesionesAsistidas = int.Parse(Console.ReadLine());

                estudiantes.Add(new Universidad.Estudiante
                {
                    Nombre = nombre,
                    TotalSesiones = totalSesiones,
                    SesionesAsistidas = sesionesAsistidas
                });
            }

            Console.WriteLine("\n--- Resumen de Asistencia ---");
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarInfo();
            }
        }
    }
}
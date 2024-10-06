using AsistUni;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistUni
{
    public class Universidad
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int TotalSesiones { get; set; }
            public int SesionesAsistidas { get; set; }

            public class Asistencia
            {
                private readonly Estudiante estudiante;

                public Asistencia(Estudiante estudiante)
                {
                    this.estudiante = estudiante;
                }

                public static double CalcularPorcentajeAsistencia(Estudiante estudiante)
                {
                    if (estudiante.TotalSesiones == 0) return 0;
                    return (double)estudiante.SesionesAsistidas / estudiante.TotalSesiones * 100;
                }

                public static bool CumpleMinimoAsistencia(Estudiante estudiante)
                {
                    return CalcularPorcentajeAsistencia(estudiante) >= 75;
                }
            }
        }
    }
    public static class MetodosExtension
    {
        public static void MostrarInfo(this Universidad.Estudiante estudiante)
        {
            var asistencia = new Universidad.Estudiante.Asistencia(estudiante);
            double porcentaje = Universidad.Estudiante.Asistencia.CalcularPorcentajeAsistencia(estudiante);
            bool cumpleMinimo = Universidad.Estudiante.Asistencia.CumpleMinimoAsistencia(estudiante);

            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Total de Sesiones: {estudiante.TotalSesiones}");
            Console.WriteLine($"Sesiones Asistidas: {estudiante.SesionesAsistidas}");
            Console.WriteLine($"Porcentaje de Asistencia: {porcentaje:F2}%");
            Console.WriteLine(cumpleMinimo ? "Cumple con el requisito de asistencia." : "No cumple con el requisito de asistencia.");
            Console.WriteLine();
        }
    }
}



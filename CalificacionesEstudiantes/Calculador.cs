using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionesEstudiantes
{
    internal class Calculador
    {
        //Implementa una aplicación que solicite diez calificaciones numéricas y
        //calcule la cantidad de estudiantes que alcanzaron una calificación mínima de 7
        //y la cantidad que quedó por debajo de este límite.
        public void calculadorEstudiantes()
        {
            const int cantidadCalificaciones = 10;
            int vueltasBucle = 0;
            int estudiantesCalificacionMinima = 0;
            int estudiantesReprobados = 0;
            int calificaciones = 0;
            string valorIntroducidoPorConsola = string.Empty;

            try
            {

                while (true)
                {
                    Console.WriteLine("Ingrese la calificaciones de los 10 estudiantes (en un rango de 1 a 10)");
                    valorIntroducidoPorConsola = Console.ReadLine();

                    //validamos que el dato no venga vacio o null
                    if (string.IsNullOrEmpty(valorIntroducidoPorConsola))
                    {
                        Console.WriteLine("No puedes dejar campos vacios!");
                        continue;
                    }

                    //validamos que nos manden el tipo de dato que solicitamos 
                    if (int.TryParse(valorIntroducidoPorConsola, out calificaciones))
                    {
                        if (calificaciones >= 1 && calificaciones <= 10)
                        {
                            if (calificaciones > 7)
                            {
                                estudiantesCalificacionMinima++;

                            }
                            else
                            {
                                estudiantesReprobados++;

                            }
                        }
                        else
                        {
                            Console.WriteLine("las calificaciones tienen que estar entre 1 y 10");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor las calificaciones solo pueden ser numericas");
                        continue;
                    }
                    //terminamos el bucle cuando sea necesario
                    vueltasBucle++;
                    if (vueltasBucle == cantidadCalificaciones)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Estudiantes con calificaciones minima para aprobar: {estudiantesCalificacionMinima}");
                Console.WriteLine($"Estudiantes que no alcanzaron la calificacion minima: {estudiantesReprobados}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}

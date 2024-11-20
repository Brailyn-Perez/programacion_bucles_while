using CalificacionesEstudiantes;

internal class Program
{
    private static void Main(string[] args)
    {
        //Implementa una aplicación que solicite diez calificaciones numéricas y
        //calcule la cantidad de estudiantes que alcanzaron una calificación mínima de 7
        //y la cantidad que quedó por debajo de este límite.
        Calculador calculador = new Calculador();
        calculador.calculadorEstudiantes();
    }
}
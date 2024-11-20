using EmpresaConEmpleados;

internal class Program
{
    private static void Main(string[] args)
    {
        //Escribe un algoritmo que, para una empresa con 'n' empleados y un rango salarial de $100 a $500,
        //cuente cuántos empleados se encuentran en cada uno de los siguientes grupos:
        //$100-$300 y mayor a $300. Asimismo, calcula el gasto total en nómina.
        CalcularSalario calcularSalario = new CalcularSalario();
        calcularSalario.calcularSalario();

    }
}
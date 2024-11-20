using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaConEmpleados
{
    internal class CalcularSalario
    {
        //Escribe un algoritmo que, para una empresa con 'n' empleados y un rango salarial de $100 a $500,
        //cuente cuántos empleados se encuentran en cada uno de los siguientes grupos:
        //$100-$300 y mayor a $300. Asimismo, calcula el gasto total en nómina.



        public void calcularSalario()
        {
            int cantidadEmpleados = 0;
            int salarioEmpleados = 0;
            int empleadosConSalarioEntre100Y300 = 0;
            int empleadosConSalarioMayorA300 = 0;
            int gastoTotalNomina = 0;
            int vueltaBucles = 0;
            const int salarioMinimo = 100;
            const int salarioMaximo = 500;
            string valorintroducidoPorConsola = string.Empty;

            try
            {
                //aqui nos encargamos de validar y pedir la cantidad de Empleados
                while (true)
                {
                    Console.WriteLine("Ingrese la cantidad de empleados que necesita");
                    valorintroducidoPorConsola = Console.ReadLine();

                    if (string.IsNullOrEmpty(valorintroducidoPorConsola))
                    {
                        Console.WriteLine("los valores vacios no son permitidos");
                        continue;
                    }
                    if (int.TryParse(valorintroducidoPorConsola, out cantidadEmpleados))
                    {
                        Console.WriteLine("Empleados Ingresados Con exito");
                        break;
                    }
                }

                //Pedimos que ingresen el salario de cada uno de los empleados
                while (true)
                {
                    Console.WriteLine("Ingrese el salario de los empleados");
                    valorintroducidoPorConsola = Console.ReadLine();

                    if (string.IsNullOrEmpty(valorintroducidoPorConsola))
                    {
                        Console.WriteLine("No se permiten salarios vacios (Los salarios tienen un rango de 100-500)");
                        continue;
                    }

                    //validamos que se nos ingrese el tipo de dato deseado
                    if (int.TryParse(valorintroducidoPorConsola, out salarioEmpleados))
                    {
                        //validamos que los salarios se encuentren entre el rango solicitado por la empresa
                        if (salarioEmpleados >= salarioMinimo && salarioEmpleados <= salarioMaximo)
                        {
                            //aqui dividimos los salarios entre 100 y 300 y los mayores a 300
                            if (salarioEmpleados <= 300)
                            {
                                empleadosConSalarioEntre100Y300++;
                            }
                            else
                            {
                                empleadosConSalarioMayorA300++;
                            }
                            //Sumamos los salarios para saber el gasto total de nomina
                            gastoTotalNomina += salarioEmpleados;
                            Console.WriteLine("Salario ingresado con exito");


                        }
                        else
                        {
                            Console.WriteLine("Los salarios tienen un rango de 100-500");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El salario tiene que ser un numero");
                        continue;
                    }
                    vueltaBucles++;
                    if (vueltaBucles >= cantidadEmpleados)
                    {
                        break;
                    }

                }
                Console.WriteLine($"Numero de empleados de la empresa : {cantidadEmpleados}\n" +
                    $"Empleados con un salario entre 100 y 300 : {empleadosConSalarioEntre100Y300}\n" +
                    $"Empleados con salario Mayor a 300 : {empleadosConSalarioMayorA300}\n" +
                    $"Gasto Total de nomina de la empresa : {gastoTotalNomina}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }

    }
}

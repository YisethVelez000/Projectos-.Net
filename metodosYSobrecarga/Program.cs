using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosYSobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear una clase que solicite al usuario que ingrese el nombre del empleado, el departamento al que pertenece, la cantidad de horas laboradas y el valor por hora. Luego,
             se llama al método CalcularSalarioBruto para calcular el salario bruto del empleado en función de las horas laboradas y el valor por hora.
             Finalmente, se llama al método ImprimirDetallesEmpleado para imprimir los detalles ingresados junto con el salario bruto calculado. */

            //Definimos las variables
            String nombreEmpleado,departamento;
            double valorPorHora, horasLaboradas;

            //Pedimos los datos
            Console.WriteLine("Ingrese el nombre del empleado : ");
            nombreEmpleado= Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del departamento : ");
            departamento= Console.ReadLine();
            Console.WriteLine("Ingrese las horas laboradas : ");
            while (!double.TryParse(Console.ReadLine(), out horasLaboradas) || horasLaboradas < 0)
            {
                Console.WriteLine("Ingrese un valor valido");
            }
            Console.WriteLine("Ingrese el valor por hora : ");
            while(!double.TryParse(Console.ReadLine(), out valorPorHora) || valorPorHora < 0)
            {
                Console.WriteLine("Ingrese un valor valido");
            };

            //Llamamos al metodo imprimirDetallesEmpleado
            ImprimirDetallesEmpleado(nombreEmpleado, departamento, horasLaboradas,valorPorHora);

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();

        }

        static void ImprimirDetallesEmpleado(string nombreEmpleado, string departamento, double horasLaboradas, double valorPorHora)
        {
            Console.WriteLine($"Detalles del Empleado\nNombre Empleado: {nombreEmpleado}\nDepartamento: {departamento}\nHoras laboradas : {horasLaboradas}\nValor por hora : {valorPorHora}\nSalario bruto : " + CalcularSalarioBruto(valorPorHora, horasLaboradas).ToString("C2"));

        }

        static double CalcularSalarioBruto(double valorPorHora, double horasLaboradas)
        {
            double salarioBruto = valorPorHora * horasLaboradas;
            return salarioBruto;
        }

    }
}

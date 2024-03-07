using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> empleados = new List<String>();

            empleados.Add("Jairo");
            empleados.Add("Alix");
            empleados.Add("Sara");
            empleados.Add("Wiliam");


            //empleados.Sort();
            empleados.Insert(1, "Alison");

            empleados.Remove("Jairo");

            for (int i = 0; i < empleados.Count; i++)
            {
                Console.WriteLine(empleados.ElementAt(i));
            }

            empleados.RemoveAt(3);
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();



        }
    }
}

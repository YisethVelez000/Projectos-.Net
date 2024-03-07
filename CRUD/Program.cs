using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definimos variables
            int opcion;
            bool continuar = true;
            String nombreLicor;
            double valorLicor;
            string nuevoNombre;
            double nuevoPrecio;
            //Creamos un diccionario de licores
            Dictionary<string,double> licores = new Dictionary<string,double>();

            while (continuar)
            {
                //Mostramos el menú
                    Console.WriteLine("Distribudora de licores");
                    Console.WriteLine("Menú");
                    Console.WriteLine("1. Ingresar licor");
                    Console.WriteLine("2. Consultar licor");
                    Console.WriteLine("3. Actualizar licor ");
                    Console.WriteLine("4. Eliminar un licor ");
                    Console.WriteLine("5. Listar todos los colores");
                    Console.WriteLine("0. Salir");
                    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion > 5 || opcion < 0)
                    {
                        Console.WriteLine("Ingrese una opcion valida");
                    }

                switch (opcion)
                {
                    case 0:
                        continuar = false;
                        Console.WriteLine("Gracias por usar el programa");
                        break;
                    case 1:
                        //Preguntamos si esta seguro de que quiere agregar un licor
                        Console.WriteLine("¿Esta seguro que desea ingresar un licor?\n1.Si\n2.No");
                        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2)

                        {
                            Console.WriteLine("Ingrese una opcion valida");
                        }

                        if (opcion == 1)
                        {
                            Console.WriteLine("Ingrese el nombre del licor ");
                            nombreLicor = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio del licor");
                            while(!double.TryParse(Console.ReadLine(), out valorLicor)|| valorLicor < 0){
                                Console.WriteLine("Ingrese un valor valido");
                            }

                            licores.Add(nombreLicor,valorLicor);
                        }
                        else
                        {
                            break;
                        }
                        continuar = true;
                        break;
                    case 2:
                        Console.WriteLine("¿Esta seguro de que desea consultar un licor?\n1.Si\n2.No");
                        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2)
                        
                        {
                            Console.WriteLine("Ingrese una opcion valida");
                        }
                        if (opcion == 1)
                        {
                            Console.WriteLine("Ingrese el nombre del licor que desea consultar");
                            nombreLicor = Console.ReadLine();

                            //Recorremos el diccionario con un foreach
                            foreach (KeyValuePair<string, double> licoresEntry in licores)
                            {
                                if (licoresEntry.Key == nombreLicor)
                                {
                                    Console.WriteLine($"Se encontró una coincidencia para la clave '{nombreLicor}'. El valor asociado es: {licoresEntry.Value.ToString("C2")}");
                                    break; // Detener la búsqueda después de encontrar la primera coincidencia
                                }
                                else
                                {
                                    Console.WriteLine("No se encontraron coincidencias");
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("¿Esta seguro que desea actualizar un licor?\n1.Si\n2.No");
                        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2)

                        {
                            Console.WriteLine("Ingrese una opcion valida");
                        }
                        if (opcion == 1)
                        {
                            Console.WriteLine("Ingrese el nombre del licor que desea actualizar");
                            nombreLicor= Console.ReadLine();
                            foreach (KeyValuePair<string, double> licoresEntry in licores)
                            {
                                if (licoresEntry.Key == nombreLicor)
                                {
                                    //Preguntamos si desea cambiar el nombre 
                                    Console.WriteLine("Ingrese según la opción :\n1.Cambiar nombre\n2.Cambiar precio\n3.Cambiar ambos");
                                    while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
                                    {
                                        Console.WriteLine("Ingrese una opcion valida");
                                    }

                                    if (opcion == 1)
                                    {
                                        //Actualizamos unicamente la clave del diccionario
                                        Console.WriteLine("Ingrese el nuevo nombre:");
                                        nuevoNombre = Console.ReadLine();
                                        licores[nuevoNombre] = licores[nombreLicor];
                                        licores.Remove(nombreLicor);
                                        Console.WriteLine($"El nombre del licor se actualizó a '{nuevoNombre}'.");

                                    }
                                    else if (opcion == 2)
                                    {
                                        //Actualizamos unicamente el valor del diccionario
                                        Console.WriteLine("Ingrese el nuevo precio:");
                                        while (!double.TryParse(Console.ReadLine(), out nuevoPrecio)|| nuevoPrecio<0)
                                        {
                                            Console.WriteLine("Ingrese un precio válido:");
                                        }
                                        licores[nombreLicor] = nuevoPrecio;
                                        Console.WriteLine($"El precio del licor '{nombreLicor}' se actualizó a {nuevoPrecio}.");
                                        break;
                                    }
                                    else
                                    {
                                        //Actualizamos clave y valor del diccionario
                                        Console.WriteLine("Ingrese el nuevo nombre:");
                                        nuevoNombre = Console.ReadLine();
                                        Console.WriteLine("Ingrese el nuevo precio:");
                                        while (!double.TryParse(Console.ReadLine(), out nuevoPrecio))
                                        {
                                            Console.WriteLine("Ingrese un precio válido:");
                                        }
                                        licores[nuevoNombre] = nuevoPrecio;
                                        licores.Remove(nombreLicor);
                                        Console.WriteLine($"El nombre del licor se actualizó a '{nuevoNombre}' y su precio a {nuevoPrecio}.");
                                        break;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No se encontraron coincidencias");
                                }
                            }

                        }
                        break;
                    case 4:
                        Console.WriteLine("¿Esta seguro de que desea eliminar un licor?\n1.Si\n2.No");
                        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2)

                        {
                            Console.WriteLine("Ingrese una opcion valida");
                        }
                            Console.WriteLine("Ingrese el nombre del licor que desea eliminar");
                            nombreLicor = Console.ReadLine();
                            if (licores.ContainsKey(nombreLicor))
                            {
                                Console.WriteLine($"¿Está seguro de que quiere eliminar el licor '{nombreLicor}'?\n1. Sí\n2. No");
                                while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 2)
                                {
                                    Console.WriteLine("Ingrese una opción válida (1 o 2):");
                                }

                                if (opcion == 1)
                                {
                                    licores.Remove(nombreLicor);
                                    Console.WriteLine($"El licor '{nombreLicor}' se eliminó con éxito.");
                                }
                                else
                                {
                                    Console.WriteLine("Operación cancelada. El licor no se eliminó.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("El licor ingresado no existe");
                            }
                        break;
                    case 5:
                        Console.WriteLine("Los licores existentes son : ");
                        foreach (KeyValuePair<string, double> licoresEntry in licores)
                        {
                            Console.WriteLine($"{licoresEntry.Key} y su precio es {licoresEntry.Value.ToString("C2")}");
                        }
                            break;
                }
            }
        }

    }
}

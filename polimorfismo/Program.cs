using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carga ,numeroPuertas;
            double cilindraje;
            String modelo, marca, matricula;

            Console.WriteLine("Polimorfismo con Vehiculos");
            VehiculoCarga vehiculoCarga1 = new VehiculoCarga();
            VehiculoDeportivo vehiculoDeportivo = new VehiculoDeportivo();
            VehiculoTurismo vehiculoTurismo = new VehiculoTurismo();

            Console.WriteLine("Crear el vehiculo de carga");
            Console.WriteLine("Ingrese la marca del vehiculo");
            marca=Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la matricula del vehiculo");
            matricula=Console.ReadLine();
            Console.WriteLine("Ingrese la carga del vehiculo");
            while(!int.TryParse(Console.ReadLine(), out carga)|| carga<0)
            {
                Console.WriteLine("Ingrese un dato valido");
            }

            vehiculoCarga1.setCarga(carga);
            vehiculoCarga1.setMarca(marca);
            vehiculoCarga1.setMatricula(matricula);
            vehiculoCarga1.setModelo(modelo);

            Console.WriteLine("Vehiculo creado exitosamente ");
            Console.WriteLine(vehiculoCarga1.mostrarDatos());

            Console.WriteLine("Crear el vehiculo de Deportivo");
            Console.WriteLine("Ingrese la marca del vehiculo");
            marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la matricula del vehiculo");
            matricula = Console.ReadLine();
            Console.WriteLine("Ingrese el cilindraje del vehiculo");
            while (!double.TryParse(Console.ReadLine(), out cilindraje) || cilindraje< 0)
            {
                Console.WriteLine("Ingrese un dato valido");
            }

            vehiculoDeportivo.setMarca(marca);
            vehiculoDeportivo.setModelo(modelo);
            vehiculoDeportivo.setMatricula(matricula);
            vehiculoDeportivo.setCilindraje(cilindraje);

            Console.WriteLine("Vehiculo creado exitosamente ");
            Console.WriteLine(vehiculoDeportivo.mostrarDatos());

            Console.WriteLine("Crear el vehiculo de Turismo");
            Console.WriteLine("Ingrese la marca del vehiculo");
            marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la matricula del vehiculo");
            matricula = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de puertas  vehiculo");
            while (!int.TryParse(Console.ReadLine(), out numeroPuertas) || numeroPuertas < 0)
            {
                Console.WriteLine("Ingrese un dato valido");
            }

            vehiculoTurismo.setMatricula(matricula);
            vehiculoTurismo.setModelo(modelo);
            vehiculoTurismo.setMarca(marca);
            vehiculoTurismo.setNumeroPuertas(numeroPuertas);

            Console.WriteLine("Vehiculo creado exitosamente");
            Console.WriteLine(vehiculoTurismo.mostrarDatos());

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}

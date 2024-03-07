/*Mabe  solicita a una empresa externa el desarrollo de una clase programada en Java, para el 
funcionamiento lógico de su nueva línea de lavadoras, misma que puedan implementar sus programadores de manera sencilla en los 
programas desarrollados dentro Mabe. La clase debe cumplir con las siguientes características:

Solicitar los kilos y tipo de ropa a  lavar. Estos se solicitan a través de argumentos. (los tipos de ropa son más de 10 y se van guardando en un List. Entre los tipos de ropa tenemos(ropa de colores, algodón, lycra, sedas, Jeans, tennis, entre otros.
La clase debe brindar una opción de fijar el tiempo de lavado en minutos en caso de que la ropa esté muy sucia.
La clase debe de realizar las funciones de: llenado de agua, lavado, enjuague y secado y ciclo Terminado.

Antes de comenzar el ciclo de secado, el sistema debe preguntar si se desea secar las prendas de una vez, y de ser así, se continua con el proceso hasta el final. En caso de que no, se detiene el proceso y se deja una opción de “Reanudar” para cuando el usuario lo desee.

Todos los métodos deben estar correctamente encapsulados, para evitar que los programadores de Mabe utilicen métodos o variables que no son necesarios.
El único método disponible para importar(no encapsulado) debe ser CicloTerminado().
Mabe es quien desarrolla la clase que contiene el método main.

La capacidad máxima de lavado es de 30 kg
No se pueden lavar menos de 10 kilos.
La lavadora debe preguntar por el tipo de prendas a lavar , la temperatura que debe utilizar según el tipo de ropa y siempre se debe 
mostrar una recomendación de lavado en la pantalla dependiendo del tipo de ropa(ver recomendaciones de lavado).
Cuando la lavadora esté llenando se debe realizar un retraso de 7 segundos que simule el tiempo de llenado de agua y parpadear así: 
Llenando…llenando….Igual para cada proceso.
Cada ciclo debe emitir un sonido diferente, así como se comporta la lavadora cuando cambia de estado.
Se deben controlar las excepciones en cada proceso.
Los sonidos se pueden descargar o grabar para su uso.

El costo de lavar cada kilo es de  $ 4.000
Se debe calcular y mostrar cuánto cuestan los kilos  de ropa lavados IVA incluido.
Cuántos clientes atendió.
Se debe calcular y mostrar cuantos cuestan los kilos  de ropa lavados incluyendo el IVA.
Cuando la ropa sea de color o algodón el precio del kilogramo aumenta en un 5%.
El dueño se gana el 30 %  de lo que cuesta lavar en cada kilo, por tanto, es necesario calcular y mostrar para él, el valor de la 
ganancia y el total de dinero realizado en de la operación de lavado. También se debe mostrar el costo total de lavado para el cliente. Adicionalmente, la cantidad de kwh consumida, se presume que el kwh cuesta: 516,72 $/kWh.
Recuerde mostrar el nombre del cliente y la fecha y hora del lavado.
Solo se termina el programa cuando el usuario digita “Q” para salir.

Al terminar todos los ciclos se muestra un contador de tiempo que dice cuanto se demoró el lavado de ropa en minutos o segundos.
Recomendaciones para el lavado de cada prenda:

Las distintas temperaturas del agua en el ciclo de lavado
Agua fría (hasta 20 º): se recomienda para ropa de colores, algodón, lycra, sedas, prendas delicadas y telas que puedan achicarse.
Agua tibia (entre 30 a 50º): se recomienda para jeans, camperas, ropa muy sucia o poco delicada.
Agua caliente (entre 55 a 90º): se recomienda para toallas, sábanas o acolchados, telas blancas gruesas y cortinas de tela. 


Crear dos clases
Instancias de clase
Uso de métodos.
Paso de parámetros
Uso de constructores
Uso de Getter y setter.
Encapsulamiento(Modificadores de acceso).
Manejo de excepciones.



*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadora
    class Program
    {
        static void Main(string[] args)
        {
            Lavadora lavadora = new Lavadora();
            lavadora.Llenado();
            lavadora.Lavado();
            lavadora.Enjuague();
            lavadora.Secado();
            lavadora.CicloTerminado();
        }
    }


    class Lavadora{
        private int kilos = 0;
        private string tipoRopa = "";
        private int tiempoLavado = 0;
        private int temperatura = 0;
        private int costoLavado = 0;
        private int clientesAtendidos = 0;
        private int ganancia = 0;
        private int kwhConsumidos = 0;
        private string nombreCliente = "";
        private string fechaHora = "";
        private int contadorTiempo = 0;
        private List<string> tiposRopa = new List<string>();

        public Lavadora()
        {
            this.kilos = 0;
            this.tipoRopa = "";
            this.tiempoLavado = 0;
            this.temperatura = 0;
            this.costoLavado = 0;
            this.clientesAtendidos = 0;
            this.ganancia = 0;
            this.kwhConsumidos = 0;
            this.nombreCliente = "";
            this.fechaHora = "";
            this.contadorTiempo = 0;
        }

        public void Llenado()
        {
            Console.WriteLine("Ingrese los kilos de ropa a lavar: ");
            this.kilos = Convert.ToInt32(Console.ReadLine());
            if (this.kilos < 10)
            {
                throw new Exception("No se pueden lavar menos de 10 kilos");
            }
            else if (this.kilos > 30)
            {
                throw new Exception("La capacidad máxima de lavado es de 30 kg");
            }
            Console.WriteLine("Ingrese el tipo de ropa a lavar: ");
            this.tipoRopa = Console.ReadLine();
            this.tiposRopa.Add(this.tipoRopa);
            Console.WriteLine("Ingrese el tiempo de lavado en minutos: ");
            this.tiempoLavado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura del agua: ");
            this.temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Llenando...");
            System.Threading.Thread.Sleep(7000);
            Console.WriteLine("Llenado completado");
        }

        public void Lavado()
        {
            Console.WriteLine("Lavando...");
            System.Threading.Thread.Sleep(7000);
            Console.WriteLine("Lavado completado");
        }

        public void Enjuague()
        {
            Console.WriteLine("Enjuagando...");
            System.Threading.Thread.Sleep(7000);
            Console.WriteLine("Enjuague completado");
        }

        public void Secado()
        {
            Console.WriteLine("Desea secar las prendas de una vez? (S/N): ");
            string secar = Console.ReadLine();
            if (secar == "S")
            {
                Console.WriteLine("Secando...");
                System.Threading.Thread.Sleep(7000);
                Console.WriteLine("Secado completado");
            }
            else if (secar == "N")
            {
                Console.WriteLine("Proceso detenido");
                Console.WriteLine("Desea reanudar el proceso? (S/N): ");
                string reanudar = Console.ReadLine();
                if (reanudar == "S")
                {
                    Console.WriteLine("Reanudando...");
                    System.Threading.Thread.Sleep(7000);
                    Console.WriteLine("Proceso reanudado");
                }
                else if (reanudar == "N")
                {
                    Console.WriteLine("Proceso detenido");
                }
            }
        }

        public void CicloTerminado()
        {
            Console.WriteLine("Ciclo terminado");
            Console.WriteLine("Ingrese el nombre del cliente: ");
            this.nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha y hora del lavado: ");
            this.fechaHora = Console.ReadLine();
            Console.WriteLine("Ingrese el contador de tiempo: ");
            this.contadorTiempo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantos clientes atendió: ");
            this.clientesAtendidos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuántos cuestan los kilos de ropa lavados IVA incluido: ");
            this.costoLavado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuántos cuestan los kilos de ropa lavados incluyendo el IVA: ");
            this.costoLavado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El valor de la ganancia es: ");
            this.ganancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El total de dinero realizado en de la operación de lavado es: ");
            this.ganancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La cantidad de kwh consumida es: ");
            this.kwhConsumidos = Convert.ToInt32(Console.ReadLine());
        }

        public int getKilos()
        {
            return this.kilos;
        }

        public void setKilos(int kilos)
        {
            this.kilos = kilos;
        }
        
        public string getTipoRopa()
        {
            return this.tipoRopa;
        }

        public void setTipoRopa(string tipoRopa)
        {
            this.tipoRopa = tipoRopa;
        }

        public int getTiempoLavado()
        {
            return this.tiempoLavado;
        }

        public void setTiempoLavado(int tiempoLavado)
        {
            this.tiempoLavado = tiempoLavado;
        }

        public int getTemperatura()
        {
            return this.temperatura;
        }

        public void setTemperatura(int temperatura)
        {
            this.temperatura = temperatura;
        }

        public int getCostoLavado()
        {
            return this.costoLavado;
        }

        public void setCostoLavado(int costoLavado)
        {
            this.costoLavado = costoLavado;
        }

        public int getClientesAtendidos()
        {
            return this.clientesAtendidos;
        }

        public void setClientesAtendidos(int clientesAtendidos)
        {
            this.clientesAtendidos = clientesAtendidos;
        }

        public int getGanancia()
        {
            return this.ganancia;
        }

        public void setGanancia(int ganancia)
        {
            this.ganancia = ganancia;
        }

        public int getKwhConsumidos()
        {
            return this.kwhConsumidos;
        }

        public void setKwhConsumidos(int kwhConsumidos)
        {
            this.kwhConsumidos = kwhConsumidos;
        }

        public string getNombreCliente()
        {
            return this.nombreCliente;
        }

        public void setNombreCliente(string nombreCliente)
        {
            this.nombreCliente = nombreCliente;
        }

        public string getFechaHora()
        {
            return this.fechaHora;
        }

        public void setFechaHora(string fechaHora)
        {
            this.fechaHora = fechaHora;
        }

        public int getContadorTiempo()
        {
            return this.contadorTiempo;
        }

        public void setContadorTiempo(int contadorTiempo)
        {
            this.contadorTiempo = contadorTiempo;
        }

        public List<string> getTiposRopa()
        {
            return this.tiposRopa;
        }

        public void setTiposRopa(List<string> tiposRopa)
        {
            this.tiposRopa = tiposRopa;
        }

         
}
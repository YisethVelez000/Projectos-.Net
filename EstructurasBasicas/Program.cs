
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasBasicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definimos variables
            int edad,opcion,personasAtentidas=0, formaPago;
            double IMC,peso,altura,totalPagar=0;
            bool continuar = true, comborbilidades=false, continuar2;
            long telefono;
            string nombreCompleto, documento, eps, direccion,correoElectronico, fechaNacimiento, gradoEscolaridad,opcion2, recomendacion, diagnostico;
            DateTime fechaHora;


            //Usamos un ciclo while para almacenar indefinidamente un cliente
            while (continuar) 
            {
                Console.WriteLine("****** GIMNASIO ******");
                Console.WriteLine("1.Agregar Cliente");
                Console.WriteLine("2.Salir");

                while (!int.TryParse(Console.ReadLine(),out opcion) || opcion<1 || opcion > 2)
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese su nombre completo");
                            nombreCompleto = Console.ReadLine();
                        bool continuar3 = true;
                        while (continuar3)
                        {
                            if (nombreCompleto == "")
                            {
                                Console.WriteLine("El nombre es requerido");
                                Console.WriteLine("Ingrese su nombre completo");
                                nombreCompleto = Console.ReadLine();

                            }
                            else
                            {
                                continuar3 = false;

                            }
                        }

                        personasAtentidas++;

                        Console.WriteLine("Ingrese su edad");
                        while(!int.TryParse(Console.ReadLine(),out edad)|| edad < 0)
                        {
                            Console.WriteLine("Ingrese una edad valida");
                        }
                        if (edad < 15)
                        {
                            Console.WriteLine($"Lo siento {nombreCompleto} usted no puede ingresar aun por su edad");

                        }
                        else
                        {
                            Console.WriteLine("Ingrese su número de documento");
                            documento= Console.ReadLine();

                            Console.WriteLine("Ingrese su EPS");
                            eps = Console.ReadLine();

                            Console.WriteLine("Ingrese su correo electronico");
                            correoElectronico = Console.ReadLine();

                            Console.WriteLine("Ingrese su número de telefono");
                            while(!long.TryParse(Console.ReadLine(), out telefono) || telefono < 0)
                            {
                                Console.WriteLine("Ingrese un número valido");

                            }

                            Console.WriteLine("Ingrese su direccion");
                            direccion = Console.ReadLine();

                            Console.WriteLine("Ingrese su fecha de nacimiento (DIA/MES/AÑO");
                            fechaNacimiento = Console.ReadLine();

                            Console.WriteLine("Ingrese su grado de escolaridad");
                            gradoEscolaridad=Console.ReadLine();

                            continuar2 = true;

                            while (continuar2) { 
                                Console.WriteLine("¿Tiene comorbilidades?");
                                opcion2 = Console.ReadLine().ToLower();
                                if (opcion2 == "si" || opcion2=="Si" || opcion2=="SI")
                                {
                                    comborbilidades = true;
                                    continuar2 = false;
                                }
                                else if(opcion2 == "no")
                                {
                                    comborbilidades = false;
                                    continuar2 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una opcion valida");
                                }
                            }

                            Console.WriteLine("Ingrese su peso en kg ");
                            while(!double.TryParse(Console.ReadLine(),out peso) || peso < 0)
                            {
                                Console.WriteLine("Ingrese un peso  valido");
                            }

                            Console.WriteLine("Ingrese su altura en metros");
                            while (!double.TryParse(Console.ReadLine(), out altura) || altura < 0)
                            {
                                Console.WriteLine("Ingrese una altura valido");
                            }


                            //Calculamos el IMC
                            IMC = peso /altura/altura;
                            
                            if( IMC <0.00 && IMC <= 16.00)
                            {
                                recomendacion = "Su peso es demasiado bajo - Consulte su médico.";
                                diagnostico = "Delgadez Severa";
                            }
                            else if (IMC <= 16.99)
                            {
                                recomendacion = "Su peso es bajo - Incluya calorías y carbohidratos en su dieta.";
                                diagnostico = "Delgadez Moderada";
                            }
                            else if (IMC <= 18.49)
                            {
                                recomendacion = "Su peso es ligeramente bajo - Mejore sus hábitos alimenticios.";
                                diagnostico = "Delgadez Leve";
                            }
                            else if(IMC <= 24.99)
                            {
                                recomendacion = "Usted tiene un peso saludable.";
                                diagnostico = "Normal";
                            }
                            else if(IMC<= 29.99)
                            {
                                recomendacion = "Su peso es levemente alto - Procure hacer ejercicio.";
                                diagnostico = "Preobeso";
                            }
                            else if(IMC <= 34.99)
                            {
                                recomendacion = "Su peso es alto - Controle su dieta y realice ejercicio.";
                                diagnostico = "Obesidad Leve";
                            }
                            else if (IMC <= 39.99)
                            {
                                recomendacion = "Su peso es muy alto - Visite a su médico y controle su dieta.";
                                diagnostico = "Obesidad Media";
                            }
                            else
                            {
                                recomendacion = "Su peso es excesivamente alto - Visite a su médico cuanto antes.";
                                diagnostico = "Obesidad Mórbida";
                                Console.WriteLine("Por favor vaya primero a su EPS");

                            }

                            //Verificamos la forma de pago

                            Console.WriteLine("Digite su forma de pago\n1.Contado\n2.Tarjeta de credito");
                            while(!int.TryParse(Console.ReadLine(), out formaPago) || formaPago<1 || formaPago > 2)
                            {
                                Console.WriteLine("Ingrese una opcion valida");
                            }

                            switch (formaPago)
                            {
                                case 1:
                                    totalPagar = (70000) - (70000 * 0.10);
                                    break;
                                case 2:
                                    totalPagar = 70000;
                                    break;

                            }


                            Console.WriteLine("Matriculado con exito");
                            fechaHora = DateTime.Now;
                            Console.WriteLine("Fecha y hora : " + fechaHora);
                            Console.WriteLine($"Su IMC es de : {IMC} ");
                            Console.WriteLine($"Su diagnostico : {diagnostico}");
                            Console.WriteLine($"Su recomendación es : {recomendacion}");
                            if (comborbilidades)
                            {
                                Console.WriteLine("Se debe asignar un tutor especial debido a sus comborbilidades");
                            }
                            Console.WriteLine($"Su total a pagar es de : {totalPagar.ToString("C2")}");




                        }
                        break;
                    case 2:
                        continuar=false;
                        Console.WriteLine($"Personas atentidas : {personasAtentidas}");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}

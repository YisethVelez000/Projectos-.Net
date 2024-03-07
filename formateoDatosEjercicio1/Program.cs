//Desarrollar un programa que lea el nombre del empleado, su codigo tipo entero, la cantidad de horas laboradas y el valor de cada uno
/*Se imprime el salario sin formato alguno
se imprime el salario con formato de pesos y redondeado a 2 decimales por encima
Se imprime el salario con formato de pesos y redondeado al numero mas cercano  y a 2 decimales
Se imprime el salario con formato de pesos y redondeado a 2 decimales
Si el salario es mayor a 2SMLV emitir una alerta que diga que No recibe subsidio de transporte en caso contrario que si cuenta */

//Definimos Variables
double salario;
int horas;
double valorHora;
string nombre;
int codigo;
double smlv = 1300000;

//Leemos los datos
Console.WriteLine("Ingrese el nombre del empleado");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese el código del empleado");
codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de horas laboradas");
horas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la hora");
valorHora = double.Parse(Console.ReadLine());

//Calculamos el salario
salario = horas * valorHora;

//Imprimimos el salario sin formato
Console.WriteLine($"El salario es: {salario}");

//Imprimimos el salario con formato de pesos y redondeado a 2 decimales por encima
Console.WriteLine($"El salario con formato de pesos y redondeado a 2 decimales por encima es: {Math.Ceiling(salario).ToString("C2")}");

//Imprimimos el salario con formato de pesos y redondeado al numero mas cercano y a dos decimales 
Console.WriteLine($"El salario con formato de pesos y redondeado al numero mas cercano y a 2 decimales es : {Math.Round(salario, 2).ToString("C2")}");

//Validamos si el salario es mayor a 2SMLV
if (salario > (2 * smlv))
{
    Console.WriteLine("No recibe subsidio de transporte");
} 
else
{
    Console.WriteLine("Si cuenta con subsidio de transporte");
}

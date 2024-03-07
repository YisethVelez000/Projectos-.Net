
//Importamos la libreria humanizer
using Humanizer;

Console.WriteLine("Ingrese el nombre :");
var nombre = Console.ReadLine();

Console.WriteLine("Ingrese su cargo : ");
var cargo = Console.ReadLine();

Console.WriteLine("Ingrese su eps : ");
var eps = Console.ReadLine();

Console.WriteLine("Ingrese su edad : ");
var edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Hola mi nombre es : {nombre} mi cargo es {cargo} y mi eps es {eps} y mi edad es {edad.ToWords()} años.");
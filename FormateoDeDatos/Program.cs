//Formateo de datos en C#

using System.Runtime.Serialization;

//Formateo de monedas
Console.WriteLine("Colocar signo de pesos y separados de mil");
double precioVenta = 100767.89;
Console.WriteLine($"El precio de venta es :{precioVenta:C}"); /* El modificador :C indica que se formatee el valor como una moneda, se muestra el simbolo de la
10345456.78898;moneda local y la separacion de miles*/
Console.ReadKey();
Console.WriteLine("------------------------------------");

//Formatear Porcentaje
Console.WriteLine("Formateo Porcentaje Usando ToString");
double porcentaje = 0.15;
string porcentajeFormateado = porcentaje.ToString("P");
/*El modificador P usando el to String añade el formato de porcentaje es decir añade el simbolo de % ademas de convetirlo a su porcentaje*/
Console.WriteLine("El porcentaje de 0.15 es : " + porcentajeFormateado);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Presiona una tecla para continuar");
Console.ReadKey();

Console.WriteLine("Mostrar dos decimaes");
double dosDecimales= 10345456.78898;
Console.WriteLine($"El valor con dos decimales es : {dosDecimales:F2}");
/*El modificador F2 muestra solo los dos decimales de un numero*/
Console.WriteLine("-----------------------------------");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadKey();

Console.WriteLine("Mostrar Diferentes Formatos");
int numero = 1234567;
string numeroFormateado1 = numero.ToString("N");
string numeroFormateado2 = numero.ToString("N2");
string numeroFormateado3 = numero.ToString("D8");
string numeroFormateado4 = string.Format("{0:C}", numero);
Console.WriteLine("Salida Formato 1 : " + numeroFormateado1);
Console.WriteLine("Salida Formato 2 : " + numeroFormateado2);
Console.WriteLine("Salida Formato 3 : " + numeroFormateado3);
Console.WriteLine("Salida Formato 4 : " + numeroFormateado4);
Console.WriteLine("----------------------------------");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadKey();


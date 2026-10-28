//Programa de intercambio de variables 
//Primero, definimos los datos
using System.Runtime.InteropServices;

int a, b, c;

//ingrsamos los datos 
Console.Write("Ingresa el valor de A: ");
a= Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa el valor de B: ");
b= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Los valores originales son: A: {a} y B: {b}");

//proceso 

c = a;
a = b;
b = c;

//salida 
Console.WriteLine($"Los valores cambiados son:  A: {a} y B {b}");
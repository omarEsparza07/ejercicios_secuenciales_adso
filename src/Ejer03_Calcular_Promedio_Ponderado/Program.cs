//Programa que calcule el promedio ponderado 
//definimos
double n1, n2, n3, P;

//pedimos datos 
Console.WriteLine("Bienvenidos al calculador de promedio ponderado!!");
Console.Write("Por favor, Ingrese la nota del corte 1: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Por favor, Ingrese la nota del corte 2: ");
n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Por favor, Ingrese la nota del corte 3: ");
n3 = Convert.ToDouble(Console.ReadLine());

//procesoooo :p

P = (n1 * 0.25) + (n2*0.35) + (n3*0.4);

//salidaAAA

Console.WriteLine("El promedio ponderado es: "+P);

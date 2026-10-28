//definimos
int a, b;

//preguintamos
Console.Write("Digite el valor de A: ");
a=Convert.ToInt32(Console.ReadLine());
Console.Write("Digite el valor de B: ");
b=Convert.ToInt32(Console.ReadLine());

//resolvemos 

a = a + b;
b = a-b;
a = a - b; 

//probamos resultado:

Console.WriteLine($"El resultado de valores cambiados es: A: {a} Y B :{b}");

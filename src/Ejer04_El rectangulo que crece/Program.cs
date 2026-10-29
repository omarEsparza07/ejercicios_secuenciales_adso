//Programa que calcula le crecimiento de un tectangulo 

// definimos variables
double b, h, P, A;

//pedimos datos
Console.WriteLine("Bienvenido a la calculadora de area y perimetro");
Console.Write("Por favor, ingresa el valor de la base del rectangulo: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Por favor, ingresa el valor de la altura del rectangulo: ");
h = Convert.ToDouble(Console.ReadLine());

// realizamos primeros procesos 
P = (2 * b) + (2 * h);
A = b * h;
//imprimimos resultados 
Console.WriteLine($"El area sin aumentar del rectangulo es: {A} y el perimetro: {P}");
Console.WriteLine("presione una tecla cualquiera para ver el resultado con los valores aumentados");
Console.ReadKey();
b = b * 2;
h = h * 3;
P = (2 * b) + (2 * h);
A = b * h;
Console.WriteLine($"El area aumentada del rectangulo es: {A} y el perimetro: {P}");
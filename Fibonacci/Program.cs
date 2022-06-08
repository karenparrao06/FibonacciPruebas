// See https://aka.ms/new-console-template for more information
using Fibonacci;

Console.WriteLine("CALCULAR SERIE FIBONACCI. ");

Console.WriteLine("Ingrese el numero limite hasta el que desea calcular: ");
int numero = int.Parse(Console.ReadLine()!);
Console.WriteLine("_____");
Fibonacci1 fibonacci = new Fibonacci1();
fibonacci.calcularFibonacci(numero);


// See https://aka.ms/new-console-template for more information
int numeroEntero =0;

Console.WriteLine("EJERCICIO 1");
Console.WriteLine("numero Entero");

numeroEntero =  Convert.ToInt32(Console.ReadLine());

if (numeroEntero >= 1)
{
    Console.WriteLine("Numero positivo");
}
if (numeroEntero <= -1)
{
    Console.WriteLine("Numero negativo");
}
if (numeroEntero == 0)
{ 
    Console.WriteLine("El numero que ingreso es cero");
}

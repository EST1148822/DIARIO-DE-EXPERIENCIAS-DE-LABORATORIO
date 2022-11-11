class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre: ");
        string Nombre = Console.ReadLine();

        Console.WriteLine("Hola mundo");
        Console.WriteLine("soy " + Nombre);

        /* Console.WriteLine escribe en diferentes líneas */

        Console.WriteLine("Hola mundo ");
        Console.WriteLine("soy " + Nombre);
        Console.ReadKey();
    }
}
      
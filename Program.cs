class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola mundo soy Ricardo");
   

        Console.WriteLine("Hola mundo");
        Console.WriteLine("Soy Ricardo");

        /* COMENTARIO */

        Console.Write("Hola mundo ");
        Console.Write("soy Ricardo\n");

        Console.WriteLine("\nIngrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Hola mundo ");
        Console.Write("soy " + nombre);
        Console.ReadKey();
    }
}
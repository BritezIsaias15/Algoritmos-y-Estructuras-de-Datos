using System.Runtime.ConstrainedExecution;

Console.WriteLine("Ingrese una página o atras.");
string texto = Console.ReadLine();

if (texto == "")
{
    Console.WriteLine("No ha ingresado nada.");
}
else
{
    var result = Navegar(texto);
    if (result)
    {
        Console.WriteLine("n");
    }
    else
    {
        Console.WriteLine("s");
    }
}

string Navegar(string texto)
{
    var pila = new Stack<char>();

}

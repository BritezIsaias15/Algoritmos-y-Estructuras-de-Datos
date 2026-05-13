using System.Reflection.Metadata.Ecma335;

try
{
    Console.WriteLine("Ingrese su número base");
    int basee = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese su número exponente");
    int exponente = int.Parse(Console.ReadLine());

    Console.WriteLine("El resultado es " + calcularPotencia(basee, exponente));
}
catch (FormatException)
{
    Console.WriteLine("Error: El número ingresado no es válido.");
}
static int calcularPotencia(int basee, int exponente)
{
    if (exponente == 0)
    {
        return 1;
    }
    else
    {
        return basee * calcularPotencia(basee, exponente - 1);
    }
}

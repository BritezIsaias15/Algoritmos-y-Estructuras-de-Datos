using System.Reflection.Metadata.Ecma335;
Console.WriteLine("Ingrese el número a invertir");
int.TryParse(Console.ReadLine(), out int n);

invertirNumero(n);

static int invertirNumero(int n)
{
    if (n < 10)
    {
        Console.Write(n);
        return n;
    }
    else
    {
        Console.Write(n % 10);
        return invertirNumero(n / 10);
    }
}


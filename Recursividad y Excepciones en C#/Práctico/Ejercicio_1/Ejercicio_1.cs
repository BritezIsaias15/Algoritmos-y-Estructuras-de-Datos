Console.WriteLine("Ingrese el número a descomponer:");
int.TryParse(Console.ReadLine(), out int n);

contarNumeros(n);
static int contarNumeros(int n)
{
    if (n < 10)
    {
        return 1;
    }
    else
    {
        return 1 + contarNumeros(n / 10);
    }
}

Console.WriteLine("El número tiene " + contarNumeros(n) + " dígitos.");
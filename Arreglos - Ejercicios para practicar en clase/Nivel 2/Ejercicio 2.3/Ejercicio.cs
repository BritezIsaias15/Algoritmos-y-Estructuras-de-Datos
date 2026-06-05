string[] array = new string[10];


for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Ingrese el caractér N°{i + 1} (a, b, c)");
    string carac = Console.ReadLine();
    if (carac != "a" && carac != "b" && carac != "c")
    {
        Console.WriteLine("Ingrese un caracter válido.");
    }
    else
    {
        array[i] = carac;
        Console.Clear();
    }
}

var (a, b, c, inva) = ContarCarac(array);

Console.WriteLine($"La letra a apareció {a} veces.");
Console.WriteLine($"La letra b apareció {b} veces.");
Console.WriteLine($"La letra c apareció {c} veces.");
Console.WriteLine($"Los caracteres inválidos fueron un total de {inva}");

(int a, int b, int c, int inva) ContarCarac(string[] array)
{
    int a = 0;
    int b = 0;
    int c = 0;
    int inva = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == "a")
        {
            a++;
        }
        else if (array[i] == "b")
        {
            b++;
        }
        else if (array[i] == "c")
        {
            c++;
        }
        else
        {
            inva++;
        }
    }
    return (a, b, c, inva);
}


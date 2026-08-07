using System.Runtime.ConstrainedExecution;

Console.WriteLine("Ingrese una expresión matemática.");
string calc = Console.ReadLine();

if (calc == "")
{
    Console.WriteLine("No ha ingresado nada.");
}
else
{
    var result = Comprobar(calc);
    if (!result)
    {
        Console.WriteLine("La expresión no está balanceada");
    }
    else
    {
        Console.WriteLine("La expresión está balanceada.");
    }
}

bool Comprobar(string calc)
{
    char[] cadena = calc.ToCharArray();

    var pila = new Stack<char>();

    foreach (var c in cadena)
    {
        if (c == '(')
        {
            pila.Push(c);
        }
        if (pila.Count() > 0)
        {
            if (c == ')')
            {
                pila.Pop();
            }
        }
        else if (c == ')')
        {
            return false;
        }
    }
    if (pila.Count() > 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

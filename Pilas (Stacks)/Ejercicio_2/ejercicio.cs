using System.Runtime.ConstrainedExecution;

Console.WriteLine("Ingrese una expresión matemática.");
string calc = Console.ReadLine();

if (calc == null)
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
    bool resultado = true;
    char[] cadena = calc.ToCharArray();

    var pila = new Stack<char>();

    foreach (var c in cadena)
    {
        if (c == '(')
        {
            pila.Push(c);
        }
        else if (pila.Peek() == '(' && c == ')')
        {
            pila.Pop(); 
        }
        else if (pila.Peek() != '(' && c == ')')
        {
            resultado = false;
            break;
        }
    }
    return resultado;
}

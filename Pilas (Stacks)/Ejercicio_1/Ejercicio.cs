using System.Collections;

Console.WriteLine("Ingrese un texto para invertirlo.");
string mensaje = Console.ReadLine();

if (mensaje != "")
{
    Console.WriteLine(StringReverse(mensaje));
}
else
{
    Console.WriteLine("Cantidad de caracteres inválida.");
}
string StringReverse(string mensaje)
{
    string respuesta = "";
    char[] caracteres = mensaje.ToCharArray();

    var primerPila = new Stack<char>();

    foreach (char c in caracteres)
    {
        primerPila.Push(c);
    }
    while (primerPila.Count > 0)
    {
        respuesta += primerPila.Pop();
    }
    return respuesta;
}

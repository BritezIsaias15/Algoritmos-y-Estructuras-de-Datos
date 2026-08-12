using System.Linq;

bool shutdown = false;
var texto = new Stack<string>();
var redo = new Stack<string>();

while (!shutdown)
{
    Console.WriteLine("Seleccione una opción \n1.Escribir \t 2.Deshacer \t 3.Mostrar \t 4.Rehacer \t 5.Salir");
    int input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            Escribir();
            break;
        case 2:
            Deshacer();
            break;
        case 3:
            Mostrar();
            break;
        case 4:
            Redo();
            break;
        case 5:
            shutdown = true;
            break;
        default:
            Console.WriteLine("Ingrese una opción válida");
            break;

    }
}
void Redo()
{
    Console.Clear();
    if (redo.Count() == 0)
    {
        Console.WriteLine("No hay texto para rehacer.");
    }
    else
    {
        texto.Push(redo.Pop());
    }
}
void Mostrar()
{
    Console.Clear();
    foreach (string word in texto.Reverse())
    {
        Console.Write(word);
    }
        Console.WriteLine();
}

void Deshacer()
{
    Console.Clear();
    if (texto.Count() == 0)
    {
        Console.WriteLine("No hay texto el cuál deshacer.");
    }
    else
    {
        redo.Push(texto.Pop());
    }
}

void Escribir()
{
    Console.Clear();
    Console.WriteLine("Ingrese el texto.");
    texto.Push(Console.ReadLine());
    Console.Clear();
}

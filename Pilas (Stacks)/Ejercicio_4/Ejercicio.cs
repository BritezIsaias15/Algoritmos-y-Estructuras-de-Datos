
var texto = new List<string>();

while (true)
{
    Console.WriteLine("Seleccione una opción \n1.Escribir \t 2.Deshacer \t 3.Mostrar");
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
        default:
            Console.WriteLine("Ingrese una opción válida");
            break;
         
    }
}

void Mostrar()
{
    Console.Clear();
    foreach (string word in texto)
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
        texto.RemoveAt(texto.Count()-1);
    }
}

void Escribir()
{
    Console.Clear();
    Console.WriteLine("Ingrese el texto.");
    texto.Add(Console.ReadLine());
}

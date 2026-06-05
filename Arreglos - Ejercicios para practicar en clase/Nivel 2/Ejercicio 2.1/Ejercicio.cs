Console.WriteLine("¿Cuántos nombres desea ingresar?.");
int.TryParse(Console.ReadLine(), out int cant);
Console.Clear();

string[] nombres = new string[cant];

for (int i = 0; i < cant; i++)
{
    Console.WriteLine($"Ingrese el nombre Nº{i+1}.");
    string nombre = Console.ReadLine();
    nombres[i] = nombre;
    Console.Clear();
}

nombres = Invertir(nombres);

foreach(string holo in nombres)
{
    Console.Write(holo + " ");
}

string[] Invertir(string[] nombres)
{
    int inicio = 0;
    int fin = nombres.Length - 1;

    while (inicio < fin)
    {
        string auxiliar = nombres[inicio];
        nombres[inicio] = nombres[fin];
        nombres[fin] = auxiliar;

        inicio++;
        fin--;
    }
    return nombres;
}

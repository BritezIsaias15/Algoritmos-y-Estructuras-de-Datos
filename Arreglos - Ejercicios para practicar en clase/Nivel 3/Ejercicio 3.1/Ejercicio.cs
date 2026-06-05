Console.WriteLine("¿Cuántos números desea ingresar?");
int.TryParse(Console.ReadLine(), out int cant);
Console.Clear();

int[] array = new int[cant];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Ingrese el N°{i+1}.");
    int.TryParse(Console.ReadLine(), out array[i]);
    Console.Clear();
}

foreach(int numeros in array)
{
    Console.Write(numeros + " ");
}

Console.WriteLine("¿Cuántas veces desea rotar?");
int.TryParse(Console.ReadLine(), out int rotar);

int[] Rotar(int[] array, int rotar)
{
    int auxiliar;
    int auxiliar2;
    for (int i = 0; i <= rotar; i++)
    {
        
    }
    return array;
}

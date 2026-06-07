int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Ingrese el N°{i + 1}.");
    int.TryParse(Console.ReadLine(), out array[i]);
    Console.Clear();
}

Console.WriteLine("¿Cuántas veces desea rotar?");
int.TryParse(Console.ReadLine(), out int rotar);
rotar = rotar % 5;

int[] rotado = Rotar(array, rotar);

foreach (int numeros in array)
{
    Console.Write(numeros + " ");
}
int[] Rotar(int[] array, int rotar)
{
    int aux;
    int aux2;
    for (int i = 0; i < rotar; i++)
    {
        aux = array[1];
        array[1] = array[0];
        aux2 = array[2];
        array[2] = aux;
        aux = array[3];
        array[3] = aux2;
        aux2 = array[4];
        array[4] = aux;
        array[0] = aux2;
    }
    return array;
}

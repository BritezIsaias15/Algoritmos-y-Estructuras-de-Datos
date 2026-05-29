using System.Timers;

int[] arreglo1 = { 1, 0, 3, 4, 5, 6, 7, 8, 9, 10 };
int ubicacion = 2;

int posicion = busquedaB(arreglo1, ubicacion);

if (posicion != -1)
{
    Console.WriteLine($"La posicion del numero {ubicacion} en el array es la {posicion}.");
}
else
{
    Console.WriteLine("El número no se encuentra en el array.");
}

static int busquedaB(int[] arreglo1, int ubicacion)
{
    int j = 0;
    for (int i = 0; i < arreglo1.Length; i++)
    {
        if (arreglo1[i] == ubicacion)
        {
            return j;
        }
        else
        {
            j = ubicacion - 2;
            j++;
        }

    }
    return -1;
}

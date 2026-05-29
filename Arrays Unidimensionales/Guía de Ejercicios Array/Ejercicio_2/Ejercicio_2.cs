using System.Timers;

int[] arreglo1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int buscar = 6;
int resultado = busquedaL(arreglo1, buscar);

if (resultado < 0)
{
    Console.WriteLine("No se encotró el número en el array.");
}
else
{
    Console.WriteLine($"El número {buscar} se encuentra en la posición {resultado} del array.");
}

static int busquedaL(int[] arreglo1, int buscar)
{
    int resultado = -1;
    for (int i = 0; i < arreglo1.Length; i++)
    {
        if (arreglo1[i] == buscar)
        {
            return i;
        }
    }
    return resultado;
}


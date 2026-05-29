int[] num = { 23, 75, 4, 12, 43, 62, 77, 81, 9, 90 };
int buscar = 43;

int posicion = busquedaLineal(num, buscar);

if (posicion != -1)
{
    Console.WriteLine($"El número {buscar} se encuentra en la posición {posicion} del array.");
}
else
{
    Console.WriteLine("El número no se encuentra en el array.");
}

    static int busquedaLineal(int[] num, int buscar)
    {
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == buscar)
            {
                return i;
            }
        }
        return -1;
    }

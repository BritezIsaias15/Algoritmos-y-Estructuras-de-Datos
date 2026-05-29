int[] arreglo1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //Impar
int[] arreglo2 = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; //Par

int[] mezcla = mezclaArreglos(arreglo1, arreglo2);

foreach (int numeros in mezcla)
{
    Console.WriteLine(numeros);
}

static int[] mezclaArreglos(int[] arreglo1, int[] arreglo2)
{
    int n = arreglo1.Length;
    int[] mezcla = new int[n];
    for (int i = 0; i < n; i++)
    {
        if (arreglo1[i] % 2 == 1)
        {
            mezcla[i] = arreglo1[i];
        }
        else if (arreglo2[i] % 2 == 0)
        {
            mezcla[i] = arreglo2[i];
        }
    }
    return mezcla;
}

int[] arreglo1 = { 7, 2, 9, 1, 3, 6, 4, 8, 10, 5 };
int[] resultado = ordenar(arreglo1);

foreach (int numeros in resultado)
{
    Console.WriteLine(numeros);
}

static int[] ordenar(int[] arreglo1)
{
    for (int i = 0; i < arreglo1.Length - i - 1; i++)
    {
        for (int j = 0; j < arreglo1.Length - 1; j++)
        {
            if (arreglo1[j] > arreglo1[j + 1]) //Si el primer numero es mayor que el siguiente y siguiente y siguiente...
            {
                int auxiliar = arreglo1[j];
                arreglo1[j] = arreglo1[j + 1];
                arreglo1[j + 1] = auxiliar;
            }
        }
    }
    return arreglo1;
}


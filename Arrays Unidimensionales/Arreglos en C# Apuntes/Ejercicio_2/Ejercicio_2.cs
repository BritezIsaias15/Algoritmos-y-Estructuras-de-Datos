int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] b = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

int[] resultado = productoDeArreglos(a, b);

Console.WriteLine("Arreglo c");
foreach (int numeros in resultado)
{
    Console.WriteLine(numeros);
}

static int[] productoDeArreglos(int[] a, int[] b)
{
    int N = a.Length;

    int[] c = new int[N];

    for (int i = 0; i < N; i++)
    {
        c[i] = a[i] * b[N - (i + 1)];
    }
    return c;
}


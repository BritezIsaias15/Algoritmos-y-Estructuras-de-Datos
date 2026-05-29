int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

double[] porPi = multiplicarPorPi(num);

Console.WriteLine("Array por pi");
foreach (double numeros in porPi)
{
    Console.WriteLine(numeros + " ");
}

static double[] multiplicarPorPi(int[] num)
{
    int N = num.Length;
    double[] resultado = new double[N];

    for (int i = 0; i < N; i++)
    {
        resultado[i] = i * 3.14;
    }
    return resultado;
}

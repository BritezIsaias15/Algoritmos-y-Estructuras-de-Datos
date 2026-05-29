int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] reverso = reversa(num);

Console.WriteLine("Array al reverso");
foreach (int numeros in reverso)
{
    Console.WriteLine(numeros + " ");
}

static int[] reversa(int[] num)
{
    int N = num.Length;
    int[] resultado = new int[N];
    int j = 0;

    for (int i = N - 1; i >= 0; i--)
    {
        resultado[j] = num[i];
        j++;
    }
    return resultado;
}

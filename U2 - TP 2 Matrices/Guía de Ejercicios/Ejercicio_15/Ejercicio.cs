double[,] matriz1 = new double[3, 3]
{
    {1.5, 8.32, 7.93 },
    {6.7, 2.43, 12.54 },
    {4.92, 5.99, 10.23}
};

double[,] matriz2 = new double[3, 3]
{
    {9.56, 2.53, 7.21},
    {12.54, 3.65, 1.21},
    {6.32, 8.11, 4.78}
};

double[,] matriz = SumaMatrices(matriz1, matriz2);

for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

double[,] SumaMatrices(double[,] matriz1, double[,] matriz2)
{
    double[,] matrizResultado = new double[3, 3];

    for (int i = 0; i < matriz1.GetLength(0); i++)
    {
        for (int j = 0; j < matriz1.GetLength(1); j++)
        {
            matrizResultado[i, j] = matriz1[i, j] + matriz2[i, j];
        }
    }
    return matrizResultado;
}

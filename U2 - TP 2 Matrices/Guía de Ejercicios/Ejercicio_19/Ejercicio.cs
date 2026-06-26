double[,] matriz1 = new double[2, 2]
{
    {4, 1},
    {2, 6}
};

double[,] matriz = InvertirMatriz(matriz1);

for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

double[,] InvertirMatriz(double[,] matriz1)
{
    double[,] matrizResultado = new double[2, 2];
    double[,] matrizArreglo = new double[2, 2]
    {
        { matriz1[1, 1], -1 * matriz1[0, 1] },
        { -1 * matriz1[1, 0], matriz1[0, 0]}
    };
    double det = matriz1[0, 0] * matriz1[1, 1] - (matriz1[0, 1] * matriz1[1, 0]);

    if (det == 0)
    {
        return matriz1;
    }
    else
    {
        for (int i = 0; i < matriz1.GetLength(0); i++)
        {
            for (int j = 0; j < matriz1.GetLength(1); j++)
            {
                matrizResultado[i, j] = (1 / det) * matrizArreglo[i, j];
            }
        }
    }
    return matrizResultado;
}

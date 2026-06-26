double[,] matriz1 = new double[3, 3]
{
    {1.5, 8.32, 7.93 },
    {6.7, 2.43, 12.54 },
    {4.92, 5.99, 10.23}
};

double[,] matriz = TrasponerMatriz(matriz1);

for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

double[,] TrasponerMatriz(double[,] matriz1)
{
    double[,] matrizResultado = new double[3, 3];
    double[,] auxiliar = new double[3, 3];

    for (int i = 0; i < matriz1.GetLength(0); i++)
    {
        for (int j = 0; j < matriz1.GetLength(1); j++)
        {
            auxiliar[i, j] = matriz1[i, j];
        }
    }
    for (int i = 0; i < matriz1.GetLength(0); i++)
    {
        for (int j = 0; j < matriz1.GetLength(1); j++)
        {
            matrizResultado[i, j] = auxiliar[j, i];
        }
    }
    return matrizResultado;
}

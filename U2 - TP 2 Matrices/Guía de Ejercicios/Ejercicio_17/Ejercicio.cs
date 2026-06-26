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

double[,] matriz = ProductoMatrices(matriz1, matriz2);

if (matriz.GetLength(0) == 0 || matriz.GetLength(1) == 0)
{
    Console.WriteLine("Las matrices no se pueden multiplicar");
}
else
{
    for (int i = 0; i < matriz1.GetLength(0); i++)
    {
        for (int j = 0; j < matriz2.GetLength(1); j++)
        {
            Console.Write(matriz[i, j].ToString("F2") + "\t");
        }
        Console.WriteLine();
    }
}

double[,] ProductoMatrices(double[,] matriz1, double[,] matriz2)
{
    double[,] Null = new double[0, 0];

    int fila1 = matriz1.GetLength(0);
    int fila2 = matriz2.GetLength(0);
    int columna1 = matriz1.GetLength(1);
    int columna2 = matriz2.GetLength(1);

    double[,] matrizResultado = new double[fila1, columna2];

    if (fila2 != columna1)
    {
        return Null;
    }
    else
    {
        for (int i = 0; i < fila1; i++)
        {
            for (int j = 0; j < columna2; j++)
            {
                double suma = 0;
                for (int k = 0; k < columna1; k++)
                {
                    suma += matriz1[i, k] * matriz2[k, j];
                }
                matrizResultado[i, j] = suma;
            }
        }
        return matrizResultado;
    }
}

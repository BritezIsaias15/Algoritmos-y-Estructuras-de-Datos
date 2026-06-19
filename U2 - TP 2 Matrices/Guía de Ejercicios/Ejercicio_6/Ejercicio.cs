int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {1, 1, 3},
    {8, 9, 5}
};

int columna = Maximo(matriz);

Console.WriteLine($"El mayor elemento de la matriz se encuentra en la columna {columna}.");

int Maximo(int[,] matriz)
{
    int fila = matriz.GetLength(0);
    int columna = matriz.GetLength(1);
    int max = 0;
    int posColum = 0;

    for (int i = 0; i < fila; i++)
    {
        for (int j= 0; j < columna; j++)
        {
            if (matriz[i,j] > max)
            {
                max = matriz[i, j];
                posColum = j;
            }
        }
    }
    return posColum;
}

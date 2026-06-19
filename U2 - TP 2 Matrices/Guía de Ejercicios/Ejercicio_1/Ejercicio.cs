int[,] matriz = new int[3,3]
{
    {1,2,3},
    {4,5,6}, 
    {7,8,9}
};

int resultado = SumaMatriz(matriz);

Console.WriteLine($"La suma de todos los valores de la matriz es {resultado}.");

int SumaMatriz(int[,] matriz)
{
    int suma = 0;
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            suma += matriz[i, j];
        }
    }
    return suma;
}

int[,] matriz = new int[3, 3]
{
    {-1, 2, -3},
    {4, 5, -6},
    {7, -8, -9}
};

var (posi, nega) = Positivos(matriz);

Console.WriteLine($"La cantidad de números positivos que hay en la matriz son {posi}.");
Console.WriteLine($"La cantidad de números negativos que hay en la matriz son {nega}.");

(int posi, int nega) Positivos(int[,] matriz)
{
    int positivos = 0;
    int negativos = 0;
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            if (matriz[i,j] < 0)
            {
                negativos++;
            }
            else
            {
                positivos++;
            }
        }
    }
    return (positivos, negativos);
}

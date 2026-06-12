int[,] matriz = new int[10, 10];

int increment = 1;
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(0); j++)
    {
        matriz[i, j] = increment;
        increment++;
    }
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(0); j++)
    {
        if (matriz[i,j] % 2 == 0)
        {
            matriz[i, j] = 0;
        }
    }
}

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(0); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {1, 1, 3},
    {8, 9, 5}
};

matriz = MostrarMatriz(matriz);

int[,] MostrarMatriz(int[,] matriz)
{
    Console.Write($"Matriz actual:");

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
    }
    Console.WriteLine();

    matriz = Rotar(matriz);

    Console.Write($"Matriz rotada:");

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
    }
    return matriz;
}

int[,] Rotar(int[,] matriz)
{
    Console.WriteLine("¿Cuántas veces desea rotar?");
    int rotar = Convert.ToInt32(Console.ReadLine());

    if (rotar == matriz.GetLength(0))
    {
        return matriz;
    }
    else
    {
        while (rotar > 0)
        {
            int columna = matriz.GetLength(1);
            int aux;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                aux = matriz[i, 2];
                matriz[i, 2] = matriz[i, 1];
                matriz[i, 1] = matriz[i, 0];
                matriz[i, 0] = aux;
            }
            rotar--;
        }
        return matriz;
    }
}

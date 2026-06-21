int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {1, 1, 3},
    {8, 9, 5}
};
try
{
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

        matriz = Intercambio(matriz);

        Console.Write($"Matriz invertida:");

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

    int[,] Intercambio(int[,] matriz)
    {
        Console.WriteLine("Ingrese la primera fila para intercambiar. (1 - 3)");
        int priFila = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda fila para intercambiar. (1 - 3)");
        int secFila = Convert.ToInt32(Console.ReadLine());
        int columna = matriz.GetLength(1);
        priFila--;
        secFila--;
        int auxiliar;

        if (priFila == secFila)
        {
            return matriz;
        }
        else
        {
            for (int i = 0; i < columna; i++)
            {
                auxiliar = matriz[priFila, i];
                matriz[priFila, i] = matriz[secFila, i];
                matriz[secFila, i] = auxiliar;
            }
        }
        return matriz;
    }
}
catch (FormatException) 
{
    Console.WriteLine("Formato no válido.");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Fuera de rango.");
}

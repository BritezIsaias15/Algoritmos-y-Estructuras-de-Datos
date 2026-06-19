int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {1, 1, 3},
    {8, 9, 5}
};

int[,] matrizInvertida = Intercambio(matriz);


int[,] Intercambio(int[,] matriz)
{
    Console.WriteLine("Ingrese la primera fila para intercambiar. (0 - 2)");
    int.TryParse(Console.ReadLine(), out int priFila);
    Console.WriteLine("Ingrese la segunda fila para intercambiar. (0 - 2)");
    int.TryParse(Console.ReadLine(), out int secFila);
    int columna = matriz.GetLength(1);

    if (priFila == secFila)
    {
        return matriz;
    }
    else
    {
        for (int i = 0; i < columna; i++)
        {
            int[] auxiliar = matriz[priFila, i];
        }
    }
}

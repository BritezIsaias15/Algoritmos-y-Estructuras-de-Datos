int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {1, 1, 3},
    {8, 9, 5}
};

var(fila, columna) = Posicion(matriz);

if (fila == -1 && columna == -1)
{
    Console.WriteLine("El número no se encuentra en la matriz.");
}
else
{
    Console.WriteLine($"El número se encuentra en la posicion {fila}x{columna}.");
}

(int fila, int columna) Posicion(int[,] matriz)
{
    Console.WriteLine("Ingrese el número que desea buscar en la matriz.");
    int.TryParse(Console.ReadLine(), out int num);

    int fila = matriz.GetLength(0);
    int columna = matriz.GetLength(1);
    int posFila = -1;
    int posColum = -1;

    for (int i = 0; i < fila; i++)
    {
        for (int j = 0; j < columna; j++)
        {
            if (matriz[i, j] == num)
            {
                posFila = i;
                posColum = j;
            }
        }
    }
    return (posFila, posColum);
}

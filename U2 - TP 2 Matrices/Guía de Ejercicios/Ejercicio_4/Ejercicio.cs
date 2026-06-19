int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {6, 1, 3},
    {8, 9, 5}
};

var (max, indice) = Maximo(matriz);

Console.WriteLine($"El mayor valor en la columna {indice} es {max}");

(int max, int indice) Maximo(int[,] matriz)
{
    Console.WriteLine("Ingrese un número del 0 al 2");
    int.TryParse(Console.ReadLine(), out int indice);

    int fila = matriz.GetLength(0);
    int max = matriz[0, indice];

    for (int i = 1; i < fila; i++)
    {
       if (matriz[i, indice] > max)
       {
            max = matriz[i, indice];
       }
    }
    return (max, indice);
}

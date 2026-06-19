int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {6, 1, 3},
    {8, 9, 5}
};

var (max, indice) = Maximo(matriz);

Console.WriteLine($"El mayor valor en la fila {indice} es {max}");

(int max, int indice) Maximo(int[,] matriz)
{
    Console.WriteLine("Ingrese un número del 0 al 2");
    int.TryParse(Console.ReadLine(), out int indice);

    int columna = matriz.GetLength(1);
    int max = matriz[indice, 0];

    for (int i = 1; i < columna; i++)
    {
       if (matriz[indice,i] > max)
       {
            max = matriz[indice, i];
       }
    }
    return (max, indice);
}

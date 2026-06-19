int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {1, 1, 3},
    {8, 9, 5}
};

var(suma, indice) = Maximo(matriz);

Console.WriteLine($"La suma de todos los valores de la fila {indice} es de {suma}.");

(int suma, int indice) Maximo(int[,] matriz)
{
    Console.WriteLine("Ingrese la fila que desea sumar.(0-2)");
    int.TryParse(Console.ReadLine(), out int indice);

    int columna = matriz.GetLength(1);
    int suma = 0;

    for (int i = 0; i < columna; i++)
    {
        suma += matriz[indice, i];
    }
    return (suma, indice);
}

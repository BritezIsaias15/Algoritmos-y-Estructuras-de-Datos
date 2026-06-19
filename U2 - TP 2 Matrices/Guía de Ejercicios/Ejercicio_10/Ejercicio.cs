int[,] matriz = new int[3, 3]
{
    {7, 2, 4},
    {1, 1, 3},
    {8, 9, 5}
};

var(suma, indice) = Suma(matriz);

Console.WriteLine($"La suma de todos los valores de la columna {indice} es de {suma}.");

(int suma, int indice) Suma(int[,] matriz)
{
    Console.WriteLine("Ingrese la fila que desea sumar.(0-2)");
    int.TryParse(Console.ReadLine(), out int indice);

    int fila = matriz.GetLength(0);
    int suma = 0;

    for (int i = 0; i < fila; i++)
    {
        suma += matriz[i, indice];
    }
    return (suma, indice);
}

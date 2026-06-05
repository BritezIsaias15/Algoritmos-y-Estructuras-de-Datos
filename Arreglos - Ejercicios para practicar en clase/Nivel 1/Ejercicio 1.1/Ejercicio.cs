using System.Diagnostics.CodeAnalysis;

int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var (suma, promedio) = SumaYPromedio(arreglo);

Console.WriteLine($"La suma de todos los elementos es de: {suma}");
Console.WriteLine($"El promedio de todos los elementos es de {promedio}");


(int suma, float promedio) SumaYPromedio(int[] arreglo)
{
    int suma = 0;
    for (int i = 0; i < arreglo.Length; i++)
    {
        suma += arreglo[i];
    }
    float promedio = (float)suma / arreglo.Length;
    return (suma, promedio);
}

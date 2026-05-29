using System.Reflection;
using System.Threading.Tasks.Sources;

int[] array = { 1, 4, 2, 3, 5, 6, 8, 9, 7, 10 };

int contador = estrictamenteCreciente(array);

Console.Write($"La regla se rompió {contador} veces");

int estrictamenteCreciente(int[] array)
{
    int contador = 0;
    int auxiliar = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] <= auxiliar)
        {
            contador++;
        }

        auxiliar = array[i];
    }
    return contador;
}

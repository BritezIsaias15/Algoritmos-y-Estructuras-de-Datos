int[] array = { 6, 2, 7, 5, 1, 3, 4, 8 };

var (mayor, menor) = MinMax(array);

Console.WriteLine($"El número mayor en el array es {mayor}");
Console.WriteLine($"El número menor en el array es {menor}");
(int mayor, int menor) MinMax(int[] array)
{
    int n = array.Length;
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < n; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (max, min);
}

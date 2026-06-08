int[] array = { 1, 2, 2, 3, 4, 5, 6, 6, 6, 7, 8, 9, 9, 10 };

Console.WriteLine($"Array actual:");
foreach (int numeros in array)
{
    Console.Write(numeros + " ");
}

Console.WriteLine();

int[] sinRepetidos = new int[longitudNueva(array)];

int[] nuevoArray = arrayCorregido(sinRepetidos, array);

Console.WriteLine($"Array corregido:");
foreach (int numeros in nuevoArray)
{
    Console.Write(numeros + " ");
}

int[] arrayCorregido(int[] sinRepetidos, int[] array)
{
    if (array.Length == 0) return sinRepetidos;
        
    int j = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != array[i + 1])
        {
            sinRepetidos[j] = array[i];
            j++;
        }
    }
    sinRepetidos[j] = array[array.Length - 1];
    return sinRepetidos;
}

int longitudNueva(int[] array)
{
    if (array.Length == 0) return 0;

    int j = 1;

    for (int i = 0; i < array.Length - 1 ; i++)
    {
        if (array[i] != array[i + 1])
        {
            j++;
        }
        
    }
    
    return j;
}

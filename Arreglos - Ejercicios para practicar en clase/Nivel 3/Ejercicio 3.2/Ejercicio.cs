using System.Reflection.Metadata.Ecma335;

int[] array = { 1, 2, 2, 3, 4, 5, 6, 6, 6, 7, 8, 9, 9, 10 };

Console.WriteLine($"Array actual:");
foreach(int numeros in array)
{
    Console.Write(numeros + " ");
}

int[] Duplicados(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i+1])
        {
            
        }
    }
}

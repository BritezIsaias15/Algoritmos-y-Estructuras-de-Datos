int[] array = { 2, 6, 7, 13, 18, 23, 28, 32, 37, 40, 42, 44, 45, 48, 50 };

Console.WriteLine("Números primos en la lista:");

int[] primos = IdentificarPrimos(array);

foreach(int numeros in primos)
{
    Console.Write(numeros + " ");
}

int[] IdentificarPrimos(int[] array)
{
    int cant = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 2 ||)
        {
            //No es primo
        }
        Console.WriteLine(cant);
    }
    int[] newArray = new int[cant];
    while (cant != 0)
    {
        int k = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if ()
            {
                newArray[k] = array[j];
                k++;
                cant--;
            }
        }
    }
    return newArray;
}

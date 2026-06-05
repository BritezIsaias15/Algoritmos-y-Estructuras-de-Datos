int[] array = { 2, 6, 7, 13, 18, 23, 28, 32, 37, 40, 42, 44, 45, 48, 50 };

Console.WriteLine("Números primos en la lista:");

int[] primos = IdentificarPrimos(array);

foreach (int numeros in primos)
{
    Console.Write(numeros + " ");
}

int[] IdentificarPrimos(int[] array)
{
    int cant = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 2 || array[i] == 3 || array[i] == 5 || array[i] == 7 || array[i] == 11)
        {
            //Primos obligatorios
            cant++;
        }
        else if (array[i] % 2 != 0 && array[i] % 3 != 0 && array[i] % 5 != 0 && array[i] % 7 != 0 && array[i] % 11 != 0)
        {
            cant++;
        }
        Console.WriteLine(cant);
    }
    int[] newArray = new int[cant];
    while (cant != 0)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 2 || array[i] == 3 || array[i] == 5 || array[i] == 7 || array[i] == 11)
            {
                //Primos obligatorios
                newArray[k] = array[i];
                k++;
                cant--;
            }
            else if (array[i] % 2 != 0 && array[i] % 3 != 0 && array[i] % 5 != 0 && array[i] % 7 != 0 && array[i] % 11 != 0)
            {
                newArray[k] = array[i];
                k++;
                cant--;
            }
        }
    }
    return newArray;
}

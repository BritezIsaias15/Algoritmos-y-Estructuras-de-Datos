int[] arreglo1 = { 1, 2, 3, 4 };
int[] arreglo2 = { 1, 2, 3, 4 };
int producto = productoEscalarConInverso(arreglo1, arreglo2);
Console.WriteLine($"El producto escalar entre el arreglo 1 y el inverso del arreglo 2 es: {producto}");


static int productoEscalarConInverso(int[] arreglo1, int[] arreglo2)
{
    int[] arreglo2Inv = new int[arreglo2.Length];
    int j = 0;
    int resultado = 0;
    int producto = 0;

    //Invertir arreglo2
    for (int i = arreglo2.Length - 1; i >= 0; i--)
    {
        arreglo2Inv[j] = arreglo2[i];
        j++;
    }

    //Conseguir el producto
    for (int k = 0; k < arreglo1.Length; k++)
    {
        producto += (arreglo1[k] * arreglo2Inv[k]);
    }
    return producto;
}



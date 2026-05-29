using System.Reflection;
using System.Threading.Tasks.Sources;

int[] array = { 1, 2, 3, 4, 5, 0 };
// 0 está en la posición 5
Console.WriteLine("Ingrese un valor.");
int.TryParse(Console.ReadLine(), out int num);

foreach (int numeros in intercalar(array, num))
{
    Console.Write(numeros + " ");
}
int[] intercalar(int[] array, int num)
{
    int n;

    for (n = array.Length - 2; n >= 0 && array[n] > num ; n--)
    {
        array[n + 1] = array[n];
    }
    array[n + 1] = num;

    return array;

}

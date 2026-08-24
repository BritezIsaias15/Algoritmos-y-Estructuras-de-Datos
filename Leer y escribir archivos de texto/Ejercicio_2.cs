using System.Runtime.CompilerServices;

Console.WriteLine("Ingrese el nombre del archivo.");
string ruta = Console.ReadLine();

StreamReader sr = null;

try
{
    sr = new StreamReader(ruta);
    string linea = sr.ReadLine();
    int numeroLinea = 1;
    while (linea != null)
    {
        Console.WriteLine($"{numeroLinea}: {linea}");
        linea = sr.ReadLine();
        numeroLinea++;
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("No se ha encontrado el archivo.");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
}
finally
{
    if (sr != null)
    {
        sr.Close();
    }
}

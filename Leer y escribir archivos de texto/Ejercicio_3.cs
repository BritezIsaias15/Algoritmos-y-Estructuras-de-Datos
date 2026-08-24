string ruta = "diario.txt";

if (!File.Exists(ruta))
{
    Console.WriteLine("Archivo no encontrado");
    return;
}
using (StreamReader sr = new StreamReader(ruta))
{
    if (sr.Peek() >= 0)
    {
        string contenido = sr.ReadToEnd();

        Console.WriteLine("Contenido del archivo");
        Console.WriteLine(contenido);

        int caracteres = contenido.Length;
        string[] palabras = contenido.Split(
        new char[] { ' ', '\r', '\n' },
        StringSplitOptions.RemoveEmptyEntries
        );

        Console.WriteLine("Información");
        Console.WriteLine($"Cantidad de caracteres: {caracteres}");
        Console.WriteLine($"Cantidad de palabras: {palabras.Length}");
    }
    else
    {
        Console.WriteLine("El archivo está vacío.");
    }
}

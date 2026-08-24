string salida = "diario.txt";

using (StreamWriter sw = new StreamWriter(salida, false))
{
    Console.WriteLine("Ingrese su nombre.");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su frase favorita.");
    string frase = Console.ReadLine();

    sw.WriteLine("Diario Personal");
    sw.WriteLine($"Nombre: {nombre}.");
    sw.WriteLine($"Frase favorita: {frase}.");
}
using (StreamWriter sw = new StreamWriter(salida, true))
{
    sw.WriteLine($"Última acutalización: {DateTime.Now}");
}
Console.WriteLine("Proceso completado.");

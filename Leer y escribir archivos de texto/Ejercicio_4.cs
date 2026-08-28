using System.Text;

string ruta = "tabla_multiplicar.txt";

try
{
    using (StreamWriter sw = new StreamWriter(ruta, false, Encoding.UTF8))
    {
        sw.WriteLine("Tabla del 7 en una sola línea.");
        for (int i = 1; i <= 10; i++)
        {
            
            int resultado = 7 * i;
            sw.Write(resultado);
            
            if (i < 10)
            {
                sw.Write(" - ");

            }
        }
        sw.WriteLine("\nTabla del 7 en varias líneas.");
        for (int i = 1; i <= 10; i++)
        {
            sw.WriteLine($"7x{i} = {7 * i}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

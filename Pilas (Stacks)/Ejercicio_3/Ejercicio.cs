Console.WriteLine("Seleccione una opción \n1.Ir a página\t 2.Atrás");
string texto = Console.ReadLine();

if (texto == "")
{
    Console.WriteLine("No ha ingresado nada.");
}
else
{
    var result = Navegar(texto);

}

string Navegar(string texto)
{
    var pila = new Stack<string>();


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		    var paginas = new Stack<string>();
			while (true)
			{
				Console.WriteLine("Escriba ir a página o atrás.");
				string opcion = Console.ReadLine();

				if (opcion == "Ir a página")
				{
					Console.WriteLine("Ingrese la URL.");
					paginas.Push(Console.ReadLine());
				}
				if (opcion == "Atrás")
				{
					if (paginas.Count() !=0)
					{
						Console.WriteLine(paginas.Pop());
					}
					else
					{
						Console.WriteLine("No hay páginas anteriores.");
					}
				}
			}
		}
	}
}

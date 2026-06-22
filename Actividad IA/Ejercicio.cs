bool salir = false;

int espacioLibre = 4;

string[,] menu = new string[20, 3]
    {
     {"fideos con salsa", "$4.500","15"},
     {"ensalada caprese", "$3.800", "8"},
     {"pizza napolitana", "$6.200", "20"},
     {"hamburguesa de queso", "$5.500", "12"},
     {"salchipapa", "$3.200", "10"},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "},
     {" ", " ", " "}
    };


while (!salir)
{
    Console.WriteLine("\n--- SISTEMA DE GESTIÓN DE RESTAURANTE ---");
    Console.WriteLine("1. Registrar nuevo plato (Validar datos)");
    Console.WriteLine("2. Mostrar todos los platos en el menú");
    Console.WriteLine("3. Calcular precio promedio general");
    Console.WriteLine("4. Buscar un plato por su nombre");
    Console.WriteLine("5. Mostrar platos que superan el precio promedio");
    Console.WriteLine("6. Mostrar plato más caro y más barato");
    Console.WriteLine("7. Eliminar un plato por su nombre");
    Console.WriteLine("8. Salir del programa");
    Console.Write("Seleccione una opción: ");

    ConsoleKeyInfo opcionInput = Console.ReadKey(true);
    Console.Clear();

    switch (opcionInput.Key)
    {

        case ConsoleKey.D1:
            Console.WriteLine("\n[Opción 1: Registrar nuevo plato]");
            (menu, espacioLibre) = RegistrarPlato(menu, espacioLibre);
            break;

        case ConsoleKey.D2:
            Console.WriteLine("\n[Opción 2: Mostrar todos los platos]");
            MostrarMenu();
            break;

        case ConsoleKey.D3:
            Console.WriteLine("\n[Opción 3: Calcular precio promedio]");
            double promedio = CalcularPromedio(menu);
            Console.WriteLine($"El precio promedio de los platos es: ${promedio}");
            break;


        case ConsoleKey.D4:
            Console.WriteLine("\n[Opción 4: Buscar plato por nombre]");
            BuscarReceta(menu);
            break;

        case ConsoleKey.D5:
            Console.WriteLine("\n[Opción 5: Platos que superan el promedio]");
            SuperaPromedio(menu, CalcularPromedio(menu));
            break;

        case ConsoleKey.D6:
            Console.WriteLine("\n[Opción 6: Plato más caro y más barato]");
            var(platoMin, platoMax) = MinMaxPrecio(menu,espacioLibre);
            Console.WriteLine($"El plato mas caro es {menu[platoMax, 0]} con el precio de {menu[platoMax, 1]}.");
            Console.WriteLine($"El plato mas barato es {menu[platoMin, 0]} con el precio de {menu[platoMin, 1]}.");
            break;

        case ConsoleKey.D7:
            Console.WriteLine("\n[Opción 7: Eliminar plato por nombre]");
           EliminarPlato();
           
            break;

        case ConsoleKey.D8:
            Console.WriteLine("\nSaliendo del sistema... ¡Buen provecho!");
            salir = true;
            break;

        default:
            Console.WriteLine("\nOpción no válida. Por favor, intente de nuevo.");
            break;
    }
}

(string[,] menu, int espacioLibre) RegistrarPlato(string[,] menu, int espacioLibre)
{
    espacioLibre++;

    Console.WriteLine("Ingrese el nombre de la receta");
    menu[espacioLibre, 0] = Console.ReadLine();

    Console.WriteLine("Ingrese el precio de la receta");
    menu[espacioLibre, 1] = "$" + Console.ReadLine();

    Console.WriteLine("Ingrese el tiempo de coción de la receta");
    menu[espacioLibre, 2] = Console.ReadLine();

    return (menu, espacioLibre);
}

void MostrarMenu()
{
    for (int i = 0; i < menu.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < menu.GetLength(1); j++)
        {
            Console.Write(menu[i, j] + " ");
        }
    }
}

double CalcularPromedio(string[,] menu)
{
    double sumaPrecios = 0;
    int platosContados = 0;

    for (int i = 0; i <= espacioLibre; i++)
    {

        string precioTexto = menu[i, 1];

        precioTexto = precioTexto.Replace("$", "").Trim();


        if (double.TryParse(precioTexto, out double precioConvertido))
        {
            sumaPrecios += precioConvertido;
            platosContados++;
        }
    }
    double promedioFinal = sumaPrecios / platosContados;

    return promedioFinal;
}

void BuscarReceta(string[,] menu)
{
    Console.WriteLine("Ingrese el nombre de la receta que desea buscar:");
    string receta = Console.ReadLine().ToLower().Trim();

    for (int i = 0; i < menu.GetLength(0); i++)
    {
       
        if (receta == menu[i, 0])
        {
            for (int j = 0; j < menu.GetLength(1); j++)
            {
                Console.Write(menu[i, j] + " ");
            } 
        }
    }
   
}

void SuperaPromedio(string[,] menu, double promedio) 
{
    for (int i = 0; i < menu.GetLength(0); i++)
    {
        menu[i, 1] = menu[i,1].Replace("$", "").Trim();
        double.TryParse(menu[i, 1], out double precioConvertido);
        if (precioConvertido > promedio)
        {
            for(int j = 0; j < menu.GetLength(1); j++) 
            {
                Console.Write(menu[i,j] + " ");
            }
            Console.WriteLine();
            
        }
    }
}

(int platoMin, int platoMax) MinMaxPrecio(string[,] menu, int espacioLibre)
{
    int platoMin = 0;
    int platoMax = 0;

    double precioMax = double.MinValue;
    double precioMin = double.MaxValue;

    for (int i = 0; i <= espacioLibre; i++)
    {
        string precioTexto = menu[i, 1].Replace("$", "").Replace(".", "").Trim();
       

        if (double.TryParse(precioTexto, out double precioConvertido))
        {
            
            if (precioConvertido > precioMax)
            {
                precioMax = precioConvertido;
                platoMax = i;
            }
          
            if (precioConvertido < precioMin)
            {
                precioMin = precioConvertido;
                platoMin = i;
            }
        }
    }
    return (platoMin, platoMax);
}

void EliminarPlato() 
{
    Console.WriteLine("Ingrese el nombre de la receta que desea borrar:");
    string receta = Console.ReadLine().ToLower().Trim();

    for (int i = 0; i < menu.GetLength(0); i++)
    {

        if (receta == menu[i, 0])
        {
            for (int j = 0; j < menu.GetLength(1); j++)
            {
                menu[i, j] = menu[i, j].Replace(menu[i,j], "").Trim();
            }
        }
    }

}

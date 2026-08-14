using System;
using System.Formats.Tar;
using System.Net.Sockets;

bool shutdown = false;
Juegos[] catalogo = new Juegos[4];
int[,] gondola = new int[2, 2];

Inventario.CargarCatalogoInicial(catalogo);
Gondola.Cargar(catalogo, gondola);
Inventario.Mostrar(catalogo);

while (!shutdown)
{
    Console.WriteLine($"Ingrese una opción\n1.Buscar videojuego\t2.Mostrar videojuegos\t3.Consultar Gondola\t7.Salir");
    int.TryParse(Console.ReadLine(), out int opcion);

    switch (opcion)
    {
        case 1:
            Inventario.BuscarJuego(catalogo);
            break;
        case 2:
            Inventario.Mostrar(catalogo);
            break;
        case 3:
            Gondola.ConsultarProducto(catalogo, gondola);
            break;
        /*case 4:
            Encolar();
            break;
        case 5:
            ConsultarSigCliente();
            break;
        case 6:
            CobrarCliente();
            break;*/
        case 7:
            shutdown = true;
            break; 
       default:
           Console.Clear();
           Console.WriteLine("Ingrese una opción válida.");
           Console.Clear();
           break;
    }
}

public struct Juegos
{
    public int id;
    public string titulo;
    public double precio;
    public string categoria;
    public int stock;
}

public struct Cliente
{
    public int id;
    public int idProducto;
    public string nombre;
    public string apellido;
    public int numero;
}

public static class Servicio
{
    public static void Encolar()
    {

    }
}

public static class Gondola
{
    public static void ConsultarProducto(Juegos[] catalogo, int[,] gondola)
    {
        Console.Clear();
        Console.WriteLine("Ingrese la fila del producto que desea buscar.");
        int.TryParse(Console.ReadLine(), out int fila);
        Console.Clear();
        Console.WriteLine("Ingrese la columna del producto que desea buscar.");
        int.TryParse(Console.ReadLine(), out int columna);
        bool encontrar = false;
        fila -= 1;
        columna -= 1;

        if (fila < 0 || fila > gondola.GetLength(0) || columna < 0 || columna > gondola.GetLength(1))
        {
            Console.WriteLine("Ubicación no válida.");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
            return;
        }

        int buscar = gondola[fila, columna];

        for (int i = 0; i < catalogo.Length; i++)
        {
            if (catalogo[i].id == buscar)
            {
                Console.WriteLine("Id\t\tTitulo\t\tPrecio\t\tCategoria\t\tStock");
                Console.WriteLine($"{catalogo[i].id,-4}\t{catalogo[i].titulo,-15}\t{catalogo[i].precio,-10}\t{catalogo[i].categoria,-15}\t{catalogo[i].stock,-8}");
                Console.WriteLine("Presione Enter para continuar.");
                Console.ReadLine();
                encontrar = true;
            }
        }

        if (!encontrar)
        {
            Console.WriteLine("No se ha encontrado productos en esa ubicación.");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
        }
        encontrar = false;
        Console.Clear();
    }
    public static void Cargar(Juegos[] catalogo, int[,] gondola)
    {
        gondola[0, 0] = catalogo[0].id;
        gondola[0, 1] = catalogo[1].id;
        gondola[1, 0] = catalogo[2].id;
        gondola[1, 1] = catalogo[3].id;
    }
}
public static class Inventario
{
    public static void Mostrar(Juegos[] catalogo)
    {
        Console.Clear();
        Console.WriteLine($"{"Id",-4}{"Título",-15}{"Precio",-10}{"Categoria",-15}{"Stock",-8}");

        for (int i = 0; i < catalogo.Length; i++)
        {
            if (catalogo[i].id != 0)
            {
                Console.WriteLine($"{catalogo[i].id,-4}{catalogo[i].titulo,-15}{catalogo[i].precio,-10}{catalogo[i].categoria,-15}{catalogo[i].stock,-8}");
            }
        }
        Console.WriteLine("Presione Enter para continuar.");
        Console.ReadLine();
        Console.Clear();

    }

    public static void CargarCatalogoInicial(Juegos[] catalogo)
    {
        catalogo[0] = new Juegos { id = 1, titulo = "GTA V", precio = 89.99, categoria = "Mundo abierto", stock = 90 };
        catalogo[1] = new Juegos { id = 2, titulo = "Minecraft", precio = 25.99, categoria = "Supervivencia", stock = 30 };
        catalogo[2] = new Juegos { id = 3, titulo = "Cuphead", precio = 9.99, categoria = "Plataformas", stock = 15 };
        catalogo[3] = new Juegos { id = 4, titulo = "No Man's Sky", precio = 19.99, categoria = "Mundo abierto", stock = 60 };
    }

    public static void BuscarJuego(Juegos[] catalogo)
    {
        Console.Clear();
        Console.WriteLine("Elige como deseas buscar el juego. \n1.ID\t2.Título");
        int.TryParse(Console.ReadLine(), out int opcion);

        switch (opcion)
        {
            case 1:
                BuscarId(catalogo);
                break;
            case 2:
                BuscarTitulo(catalogo);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Ingrese una opción válida.");
                break;
        }

    }
    private static void BuscarTitulo(Juegos[] catalogo)
    {
        Console.Clear();
        Console.WriteLine("Ingrese el Titulo del juego que desea buscar.");
        string opcion = Console.ReadLine();
        bool encontrar = false;

        for (int i = 0; i < catalogo.Count(); i++)
        {
            if (catalogo[i].titulo == opcion)
            {
                Console.Clear();
                Console.WriteLine("Id\t\tTitulo\t\tPrecio\t\tCategoria\t\tStock");
                Console.WriteLine($"{catalogo[i].id,-4}\t{catalogo[i].titulo,-15}\t{catalogo[i].precio,-10}\t{catalogo[i].categoria,-15}\t{catalogo[i].stock,-8}");
                Console.WriteLine("Presione Enter para continuar.");
                Console.ReadLine();
                encontrar = true;
            }
        }
        if (!encontrar)
        {
            Console.WriteLine("No se ha encontrado el juego.");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
        }
        encontrar = false;
        Console.Clear();
    }
    
    private static void BuscarId(Juegos[] catalogo)
    {
        Console.Clear();
        Console.WriteLine("Ingrese el Id del juego que desea buscar.");
        int.TryParse(Console.ReadLine(), out int opcion);
        bool encontrar = false;

        for (int i = 0; i < catalogo.Count(); i++)
        {
            if (catalogo[i].id == opcion)
            {
                Console.Clear();
                Console.WriteLine("Id\t\tTitulo\t\tPrecio\t\tCategoria\t\tStock");
                Console.WriteLine($"{catalogo[i].id,-4}\t{catalogo[i].titulo,-15}\t{catalogo[i].precio,-10}\t{catalogo[i].categoria,-15}\t{catalogo[i].stock,-8}");
                Console.WriteLine("Presione Enter para continuar.");
                Console.ReadLine();
                encontrar = true;
            }
        }
        if (!encontrar)
        {
            Console.WriteLine("No se ha encontrado el juego.");
            Console.WriteLine("Presione Enter para continuar.");
            Console.ReadLine();
        }
        encontrar = false;
        Console.Clear();
    }
}

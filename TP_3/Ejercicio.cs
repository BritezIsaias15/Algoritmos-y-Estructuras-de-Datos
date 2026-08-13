using System;
using System.Formats.Tar;
using System.Net.Sockets;

bool shutdown = false;
Juegos[] catalogo = new Juegos[4];
int[,] gondola = new int[2, 2];

Inventario.CargarCatalogoInicial(catalogo);
Inventario.Mostrar(catalogo);

while (!shutdown)
{
    Console.WriteLine($"Ingrese una opción\n1.Buscar videojuego\t2.Mostrar videojuegos");
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
            ConsultarProducto(catalogo);
            break;
        case 4:
            EncolarCliente();
            break;
        case 5:
            ConsultarSigCliente();
            break;
        case 6:
            CobrarCliente():
            break;
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


public static class Inventario
{
    public static void Gondolas(Juegos[] catalogo, int[,] gondola)
    {
        for (int i = 0; i < gondola.GetLength(0); i++)
        {
            //Matriz que valen 1-4 para comparar id
        }
    }

    public static void Mostrar(Juegos[] catalogo)
    {
        Console.Clear();
        Console.WriteLine($"{"Id",-4}{"Título",-15}{"Precio",-10}{"Categoria",-15}{"Stock",-8}");

        for (int i = 0; i < catalogo.Length; i++)
        {
            if (catalogo[i].id != 0)
            {
                Console.WriteLine($"{catalogo[i].id, -4}{catalogo[i].titulo,-15}{catalogo[i].precio, -10}{catalogo[i].categoria, -15}{catalogo[i].stock, -8}");
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
        int encont = 0;

        for (int i = 0; i < catalogo.Count(); i++)
        {
            if (catalogo[i].titulo == opcion)
            {
                Console.Clear();
                Console.WriteLine("Id\t\tTitulo\t\tPrecio\t\tCategoria\t\tStock");
                Console.WriteLine($"{catalogo[i].id}\t{catalogo[i].titulo}\t{catalogo[i].precio}\t{catalogo[i].categoria}\t{catalogo[i].stock}");
                Console.WriteLine("Presione Enter para continuar.");
                Console.ReadLine();
                encont++;
            }
        }
        if (encont == 0)
        {
            Console.WriteLine("No se ha encontrado el juego.");
        }
        encont = 0;
        Console.Clear();
    }

    private static void BuscarId(Juegos[] catalogo)
    {
        Console.Clear();
        Console.WriteLine("Ingrese el Id del juego que desea buscar.");
        int.TryParse(Console.ReadLine(), out int opcion);
        int encont = 0;

        for (int i = 0; i < catalogo.Count(); i++)
        {
            if (catalogo[i].id == opcion)
            {
                Console.Clear();
                Console.WriteLine("Id\t\tTitulo\t\tPrecio\t\tCategoria\t\tStock");
                Console.WriteLine($"{catalogo[i].id}\t{catalogo[i].titulo}\t{catalogo[i].precio}\t{catalogo[i].categoria}\t{catalogo[i].stock}");
                Console.WriteLine("Presione Enter para continuar.");
                Console.ReadLine();
                encont++;
            }
        }
        if (encont == 0)
        {
            Console.WriteLine("No se ha encontrado el juego.");
        }
        encont = 0;
        Console.Clear();
    }
}

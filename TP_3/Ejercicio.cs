using System;
using System.Formats.Tar;
using System.Net.Sockets;

bool shutdown = false;
Juegos[] catalogo = new Juegos[100];

Inventario.CargarCatalogoInicial(catalogo);
Inventario.Mostrar(catalogo);

while (!shutdown)
{
    Console.WriteLine($"Ingrese una opción\n1.Ingresar videojuego\t2.Buscar videojuego\t3.Mostrar videojuegos");
    int.TryParse(Console.ReadLine(), out int opcion);

    switch (opcion)
    {
        case 1:
            Inventario.AgregarJuego(catalogo);
            break;
        case 2:
            Inventario.BuscarJuego(catalogo);
            break;
        case 3:
            Inventario.Mostrar(catalogo);
            break;
        default:
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
    public int idComprar;
    public string Nombre;
    public string Apellido;
    public int Numero;
    }

public static class Inventario
{
    public static void Mostrar(Juegos[] catalogo)
    {
        Console.Clear();
        Console.WriteLine("Id\t\tTitulo\t\tPrecio\t\tCategoria\t\tStock");

        for (int i = 0; i < catalogo.Length; i++)
        {
            if (catalogo[i].id != 0)
            {
                Console.WriteLine($"{catalogo[i].id}\t\t{catalogo[i].titulo}\t\t{catalogo[i].precio}\t\t{catalogo[i].categoria}\t\t{catalogo[i].stock}");
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

    public static void AgregarJuego(Juegos[] catalogo)
    {
        Console.Clear();
        int posicion = 1;
        for (int i = 0; i < catalogo.Count(); i++)
        {
            if (catalogo[i].id != 0)
            {
                posicion++;
            }
        }
        catalogo[posicion].id = posicion;
        Console.WriteLine("Ingrese el título del juego.");
        catalogo[posicion].titulo = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del juego.");
        double.TryParse(Console.ReadLine(), out catalogo[posicion].precio);
        Console.WriteLine("Ingrese la categoría del juego.");
        catalogo[posicion].categoria = Console.ReadLine();
        Console.WriteLine("Ingrese el stock del juego.");
        int.TryParse(Console.ReadLine(), out catalogo[posicion].stock);
        Console.Clear();
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

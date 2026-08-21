using System;
using System.ComponentModel.Design;
using System.Data;
using System.Formats.Tar;
using System.Net.Sockets;
using System.Runtime.InteropServices;

bool shutdown = false;
Juegos[] catalogo = new Juegos[16];
int juego_id = 4;
Cliente[] compra = new Cliente[20];
var cola = new Queue<int>();
int[,] gondola = new int[4, 4];
int gondola_id = 4;

Inventario.CargarCatalogoInicial(catalogo);
Gondola.Cargar(catalogo, gondola);
Inventario.Mostrar(catalogo);

while (!shutdown)
{
    Console.WriteLine($"Ingrese una opción\nInventario\n1.Mostrar videojuego\t2.Buscar videojuegos\t3.Agregar videojuego\nGondola\n4.Consultar gondola\t5. Agregar videojuego\nServicio\n6.Encolar cliente\t7.Vender\n8.Salir");
    int.TryParse(Console.ReadLine(), out int opcion);
    Console.Clear();

    switch (opcion)
    {
        case 1:
            Inventario.Mostrar(catalogo);
            break;
        case 2:
            Inventario.Buscar(catalogo);
            break;
        case 3:
            Inventario.Agregar(catalogo, ref juego_id);
            break;
        case 4:
            Gondola.Consultar(catalogo, gondola);
            break;
        case 5:
            Gondola.Agregar(catalogo, ref gondola, ref gondola_id, juego_id);
            break;
        case 6:
            Servicio.Encolar(ref cola);
            break;
        case 7:
            //Servicio.Vender();
            break;
        case 8:
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
}

public static class Servicio
{
    public static void Encolar(ref Queue<int> cola)
    {
        Console.WriteLine("Ingrese la cantidad de clientes actuales en la cola.");
        int.TryParse(Console.ReadLine(), out int clientes);
        if (clientes <= 0)
        {
            Console.WriteLine("Cantidad inválida.\nPresione Enter para continuar.");
            Console.ReadLine();
            return;
        }
        else if (clientes > 20)
        {
            Console.WriteLine("Exceso de clientes.\nPresione Enter para continuar.");
            Console.ReadLine();
            return;
        }
        else
        {
            for (int i = 0; i < clientes; i++)
            {
                cola.Enqueue(i);
            }
        }
    }

    public static void Atender(Cliente[] comprar, int id)
    {
        Console.Clear();
        Console.WriteLine("Ingrese el id del producto que desea vender");
        int.TryParse(Console.ReadLine(), out int idProducto);

        comprar[id] = new Cliente { id = id, idProducto = idProducto };
        id++;
    }
}

public static class Gondola
{
    public static void Agregar(Juegos[] catalogo, ref int[,] gondola, ref int gondola_id, int juegos_id)
    {
        if (gondola_id >= juegos_id)
        {
            Console.WriteLine("No se han encontrado juegos o no hay más espacios en los estantes.\nPresione Enter para continuar.");
            Console.ReadLine();
            Console.Clear();
            return;
        }
        else
        {
            Console.WriteLine($"Ingrese la fila del estante para el juego {catalogo[gondola_id].titulo}");
            int.TryParse(Console.ReadLine(), out int fila);
            Console.WriteLine($"Ingrese la columna del estante para el juego {catalogo[gondola_id].titulo}");
            int.TryParse(Console.ReadLine(), out int columna);
            fila--;
            columna--;
            if (fila > gondola.GetLength(0) || columna > gondola.GetLength(1) || gondola[fila, columna] != 0)
            {
                Console.WriteLine("Dimensiones inválidas.\nPresione Enter para continuar");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            else
            {
                gondola[fila, columna] = gondola_id + 1;
                gondola_id++;
            }
        }
    }
    public static void Consultar(Juegos[] catalogo, int[,] gondola)
    {
        for (int i = 0; i < gondola.GetLength(0); i++)
        {
            for (int j = 0; j < gondola.GetLength(1); j++)
            {
                Console.Write(gondola[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Ingrese la fila del producto que desea buscar.");
        int.TryParse(Console.ReadLine(), out int fila);
        Console.WriteLine("Ingrese la columna del producto que desea buscar.");
        int.TryParse(Console.ReadLine(), out int columna);
        Console.Clear();
        fila -= 1;
        columna -= 1;

        if (fila < 0 || fila >= gondola.GetLength(0) || columna < 0 || columna >= gondola.GetLength(1))
        {
            Console.WriteLine("Ubicación no válida.\nPresione Enter para continuar.");
            Console.ReadLine();
            Console.Clear();
            return;
        }
        else
        {
            int buscar = gondola[fila, columna];

            for (int i = 0; i < catalogo.Length; i++)
            {
                if (catalogo[i].id == buscar)
                {
                    Console.WriteLine($"{"Id",-4}{"Título",-15}{"Precio",-10}{"Categoria",-15}{"Stock",-8}");
                    Console.WriteLine($"{catalogo[i].id,-4}\t{catalogo[i].titulo,-15}\t{catalogo[i].precio,-10}\t{catalogo[i].categoria,-15}\t{catalogo[i].stock,-8}");
                    Console.WriteLine("Presione Enter para continuar.");
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
            }
            Console.WriteLine("No se ha encontrado ningún producto.\nPresione Enter para continuar.");
            Console.ReadLine();
            Console.Clear();
        }
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
    public static void Agregar(Juegos[] catalogo, ref int juego_id)
    {
        if (juego_id > catalogo.Length)
        {
            Console.WriteLine("Catalogo lleno. No se pueden agregar más juegos.\nPresione Enter para continuar.");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Ingrese el título del juego.");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del juego.");
            double.TryParse(Console.ReadLine(), out double precio);
            Console.WriteLine("Ingrese la categoría del juego.");
            string categoria = Console.ReadLine();
            Console.WriteLine("Ingrese el stock del juego.");
            int.TryParse(Console.ReadLine(), out int stock);
            Console.Clear();
            if (titulo == "" || categoria == "" || stock < 0)
            {
                Console.WriteLine("Datos inválidos.\nPresione Enter para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                int new_id = juego_id + 1;
                catalogo[juego_id] = new Juegos { id = new_id, titulo = titulo, precio = precio, categoria = categoria, stock = stock };
                juego_id++;
            }
        }
    }

    public static void Mostrar(Juegos[] catalogo)
    {
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

    public static void Buscar(Juegos[] catalogo)
    {
        Console.WriteLine("Elige como deseas buscar el juego.\n1.ID\t2.Título");
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
        Console.WriteLine("Ingrese el Titulo del juego que desea buscar.");
        string opcion = Console.ReadLine();
        bool encontrar = false;
        Console.Clear();

        for (int i = 0; i < catalogo.Count(); i++)
        {
            if (catalogo[i].titulo == opcion)
            {
                Console.WriteLine($"{"Id",-4}{"Título",-15}{"Precio",-10}{"Categoria",-15}{"Stock",-8}");
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
        Console.WriteLine("Ingrese el Id del juego que desea buscar.");
        int.TryParse(Console.ReadLine(), out int opcion);
        bool encontrar = false;

        for (int i = 0; i < catalogo.Count(); i++)
        {
            if (catalogo[i].id == opcion)
            {
                Console.Clear();
                Console.WriteLine($"{"Id",-4}{"Título",-15}{"Precio",-10}{"Categoria",-15}{"Stock",-8}");
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

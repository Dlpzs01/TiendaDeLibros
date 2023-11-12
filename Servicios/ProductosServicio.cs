using TiendaLibros.Entidades;
using TiendaLibros.Repositorios;

namespace TiendaLibros.Servicios;

public enum Operaciones
{
    Crear = 1,
    Actualizar = 2,
    Eliminar = 3,
    Leer = 4,
    Salir
}

public class ProductosServicio
{
    private readonly ProductosRepositorio productosRepositorio;

    public ProductosServicio()
    {
        productosRepositorio = new ProductosRepositorio();
    }

    public void MostraMenu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("CRUD Producto");
            Console.WriteLine("1. Crear: ");
            Console.WriteLine("2. Actualizar: ");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Leer");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opcion: ");
            // Operador de coalescencia nula...
            string opcion = Console.ReadLine() ?? "5";
            Operaciones operacion = Enum.Parse<Operaciones>(opcion);

            switch (operacion)
            {
                case Operaciones.Crear:
                    Crear();
                    break;
                case Operaciones.Actualizar:
                    Actualizar();
                    break;
                case Operaciones.Eliminar:
                    Eliminar();
                    break;
                case Operaciones.Leer:
                    Leer();
                    break;
                case Operaciones.Salir: return;

                default: return;
            }
        } while (true);
    }

    public void Crear()
    {
        Console.WriteLine("Creando el producto");
        Console.WriteLine("Ingrese el nombre: ");
        string nombre = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Ingrese la descripcion: ");
        string descripcion = Console.ReadLine() ?? string.Empty;
        Guid id = Guid.NewGuid();

        var producto = new Producto
        {
            Id = id,
            Nombre = nombre,
            Descripcion = descripcion
        };
        productosRepositorio.Crear(producto);

        Console.WriteLine("Producto Creado...");
        Console.WriteLine("Id: " + producto.Id);
        Console.WriteLine("Nombre: " + producto.Nombre);
        Console.WriteLine("Descripcion: " + producto.Descripcion);
        Console.ReadLine();
    }

    private void Actualizar()
    {
        Console.WriteLine("Actualizando el producto");
    }

    private void Eliminar()
    {
        Console.WriteLine("Ingrese el Id del producto:");
        Guid id = Guid.Parse(Console.ReadLine() ?? "");
        Producto? producto = productosRepositorio.ObtenerPorId(id);
        if (producto is null)
        {
            Console.WriteLine("El producto no existe");
            Console.ReadLine();
            return;
        }

        productosRepositorio.Eliminar(producto);
        Console.WriteLine("El producto fue eliminado");
        Console.ReadLine();
    }

    private void Leer()
    {
        List<Producto> productos = productosRepositorio.Leer();
        foreach (Producto producto in productos)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Id: " + producto.Id);
            Console.WriteLine("Nombre: " + producto.Nombre);
            Console.WriteLine("Descripcion: " + producto.Descripcion);
        }

        Console.ReadLine();
    }
}

// 398637bd-d783-4b88-89d8-f3edbc2ec3cb (Producto 2)
// ba77c9f4-43ac-4462-82e4-e32b0afa4d58
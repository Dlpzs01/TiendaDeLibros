using TiendaLibros.Entidades;

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

    public void MostraMenu()
    {
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
    }

    public void Crear()
    {
        
    }

    private void Actualizar()
    {
        Console.WriteLine("Actualizando el producto");
    }

    private void Eliminar()
    {
        Console.WriteLine("Eliminado el producto");
    }

    private void Leer()
    {
        Console.WriteLine("Leyendo el producto");
    }
}
using TiendaLibros.Entidades;

namespace TiendaLibros.Repositorios;

public class ProductosRepositorio
{
    private readonly List<Producto> productos;

    public ProductosRepositorio()
    {
        var producto1 = new Producto
        {
            Id = Guid.NewGuid(),
            Nombre = "Producto 1",
            Descripcion = "Alguna descripcion del producto 1",
        };
        var producto2 = new Producto
        {
            Id = Guid.NewGuid(),
            Nombre = "Producto 2",
            Descripcion = "Alguna descripcion del producto 2",
        };
        var producto3 = new Producto
        {
            Id = Guid.NewGuid(),
            Nombre = "Producto 3",
            Descripcion = "Alguna descripcion del producto 3",
        };

        productos = new()
        {
            producto1,
            producto2,
            producto3
        };
    }

    public void Crear(Producto producto)
    {
        productos.Add(producto);
    }

    public void Actualizar(Producto producto)
    {

    }

    public void Eliminar(Producto producto)
    {
        productos.Remove(producto);
    }

    public Producto? ObtenerPorId(Guid id)
    {
        return productos.FirstOrDefault(producto => producto.Id == id);
    }

    public List<Producto> Leer()
    {
        return productos;
    }
}
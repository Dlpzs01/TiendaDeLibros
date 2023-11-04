namespace TiendaLibros.Entidades;

public class Categoria
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }  = string.Empty;
    public string Descripcion { get; set; } = string.Empty;

    void Crear() { }
    void Eliminar() { }
    void CrearOtraCosa() {}
}
namespace TiendaLibros.Entidades;

public class Factura
{
    public Guid Id { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public decimal Subtotal { get; set; }
    public decimal Total { get; set; }
}
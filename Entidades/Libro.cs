namespace TiendaLibros.Entidades;

public class Libro : Publicacion
{
    public string ISBN { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public string Moneda { get; set; } = string.Empty;

    public Libro(string titulo, string autor, string isbn, string publicador, TipoPublicacion tipo) : base(titulo, publicador, tipo)
    {
        if (string.IsNullOrEmpty(isbn)) throw new ArgumentException("El ISBN es requerido");

        if (!(isbn.Length == 10 || isbn.Length == 13)) throw new ArgumentException("El ISBN debe ser de 10 o 13 caracteres");

        ISBN = isbn;
        Autor = autor;
    }

    public decimal EstablecerPrecio(decimal precio, string moneda)
    {
        if (precio < 0)
            throw new ArgumentOutOfRangeException(nameof(precio), "El precio no puede ser negativo");

        decimal precioAnterior = Precio;
        Moneda = moneda;
        Precio = precio;

        return precioAnterior;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Titulo: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Tipo Publicacion: " + Tipo);
        Console.WriteLine($"Precio: {Moneda}{Precio}");
    }
}
namespace TiendaLibros.Entidades;

public enum TipoPublicacion { Misc, Libro, Magazine, Articulo }

public class Publicacion
{
    public string Titulo { get; set; } = string.Empty;
    // PascalCase => primer nombre => PrimerNombre; 
    public string Publicador { get; set; } = string.Empty;
    public TipoPublicacion Tipo { get; set; }

    // camelCase => primer nombre => primerNombre
    public Publicacion(string titulo, string publicador, TipoPublicacion tipo)
    {
        if (string.IsNullOrEmpty(publicador)) throw new ArgumentException("El publicador es requerido");

        Publicador = publicador;
        if (string.IsNullOrEmpty(titulo)) throw new ArgumentException("El titulo es requerido");

        Titulo = titulo;
        Tipo = tipo;
    }
}

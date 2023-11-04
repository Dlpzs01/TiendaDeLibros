using TiendaLibros.Entidades;

var libro0 = new Libro("Programacion Orientada a Objetos", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);
var libro1 = new Libro("Algoritmos y estructura de datos", "Danny Lopez", "Rjj66HoPQ2", "DevStack.Inc", TipoPublicacion.Libro);
var libro2 = new Libro("Programacion Web", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);
var libro3 = new Libro("Dise;o dirigido por el dominio", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);
var libro4 = new Libro("Libro prueba", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);
var libro5 = new Libro("WEB APIs", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);
var libro6 = new Libro("Docker", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);
var libro7 = new Libro("JavaScript", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);
var libro8 = new Libro("Programacion en base de datos", "Danny Lopez", "RjjmAmbUGgUvW", "DevStack.Inc", TipoPublicacion.Libro);

Libro[] libros = {
    libro0,
    libro1,
    libro2,
    libro3,
    libro4,
    libro5,
    libro6,
    libro7,
    libro8
};

for (int i = 0; i < libros.Length; i++)
{
    Libro libro = libros[i];
    Console.WriteLine("===========================");
    var random = new Random();
    libro.EstablecerPrecio(random.Next(100) * 2, "$");
    libro.MostrarInformacion();
}

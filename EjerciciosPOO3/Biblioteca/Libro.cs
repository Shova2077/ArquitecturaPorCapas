namespace EjerciciosPOO3;
public class Libro : Atributo
{
    public string Autor {get; set;}

    public decimal Paginas {get; set;}

    public Libro(string nombre, decimal precio, decimal anio, string autor, decimal paginas) :  base(nombre, precio, anio)
    {
        Autor = autor;
        Paginas = paginas;
    }




     /*
    Una librería vende distintos tipos de publicaciones: libros y revistas. Todas tienen un título, un precio y un año de publicación. Los libros tienen además un autor y un número de páginas; las revistas tienen un número de edición y una periodicidad (mensual, semanal o quincenal, usando un enum). El sistema debe poder describir cualquier publicación con un método que devuelva un texto con sus datos, listar todas las publicaciones ordenadas por precio de menor a mayor usando LINQ, y listar solo los libros usando LINQ. Si se intenta crear una publicación con precio negativo, se debe lanzar una excepción.
    */
}
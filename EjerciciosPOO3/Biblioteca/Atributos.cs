namespace EjerciciosPOO3;
public class Atributo
{
    public string Titulo {get; set;}
    public decimal Precio {get; set;}
    public decimal Anio {get; set;}

    public Atributo(string titulo, decimal precio, decimal anio)
    {
        Titulo = titulo;
        Precio = precio;
        Anio = anio;
    }

    public virtual string Describir()
    {
        return $"El nombre es: {Titulo}, el precio es: {Precio}, el año de publicacion es: {Anio}";
    }


     /*
    Una librería vende distintos tipos de publicaciones: libros y revistas. Todas tienen un título, un precio y un año de publicación. Los libros tienen además un autor y un número de páginas; las revistas tienen un número de edición y una periodicidad (mensual, semanal o quincenal, usando un enum). El sistema debe poder describir cualquier publicación con un método que devuelva un texto con sus datos, listar todas las publicaciones ordenadas por precio de menor a mayor usando LINQ, y listar solo los libros usando LINQ. Si se intenta crear una publicación con precio negativo, se debe lanzar una excepción.
    */
}
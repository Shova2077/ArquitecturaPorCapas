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

    public override string Describir()
    {
        return $"Nombre del autor del Libro {Autor}, Cantidad: {Paginas}";
    }
}
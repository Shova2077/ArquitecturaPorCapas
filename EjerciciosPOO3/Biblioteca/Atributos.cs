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
}
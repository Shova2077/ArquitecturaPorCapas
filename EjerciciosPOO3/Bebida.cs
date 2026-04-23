namespace EjerciciosPOO3;

public abstract class Bebida
{
    public string Nombre {get; set;}
    public decimal Precio {get; set;}

    public Bebida(string nombre, decimal precio)
    {
        if (precio <= 0)
        {
            throw new ArgumentException("El precio debe ser mayor a cero");
        }
        Nombre = nombre;
        Precio = precio;
    }

    public abstract string Preparar();

    public string MostrarPrecio()
    {
        return $"Bebida: {Nombre}, Precio: ${Precio}";
    }
}
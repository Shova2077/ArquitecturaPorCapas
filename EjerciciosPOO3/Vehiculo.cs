namespace EjerciciosPOO3;

public class Vehiculo
{
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public int Anio {get; set;}

    public Vehiculo(string marca, string modelo, int anio)
    {
        if (anio <= 1900)
        {
            throw new ArgumentExcpetion("El vehiculo es muy antiguo")
        }
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
    }
    
    virtual string Describir()
    {
        return $"{Marca} {Modelo} {(Anio)}";
    }
}

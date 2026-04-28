using System.Diagnostics;

namespace EjerciciosPOO3;
public enum Periodicidad
    {
        Semanal = 1,
        Quincena = 2,
        Mensual = 3,
    }
public class Revista : Atributo
{
    public decimal Edicion {get; set;}
    public Periodicidad Periodicidad{get; set;}
    
    public Revista(string nombre, decimal precio, decimal anio, decimal edicion, Periodicidad periodicidad) : base(nombre, precio, anio)
    {
        Edicion = edicion;
        Periodicidad = periodicidad;
    }

}
namespace EjerciciosPOO3;

public class Agua : Bebida
{
    public bool EsConGas {get; set;}

    public Agua(string nombre, decimal precio, bool esconGas) : base(nombre, precio)
    {
        EsConGas = esconGas;
    }
    public override string Preparar()
    {
        return $"Preparando Agua marca: {Nombre} con gas: {(EsConGas ? "Sí" : "No")}";
    }
}
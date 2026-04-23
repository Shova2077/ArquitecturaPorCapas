namespace EjerciciosPOO3;

public class Jugo : Bebida
{
    public string Fruta {get; set;}

    public Jugo(string nombre, decimal precio, string fruta) : base(nombre, precio)
    {
        Fruta = fruta;
    }

    public override string Preparar()
    {
        return $"Se esta preparando un {Nombre} de {Fruta}";
    }
}
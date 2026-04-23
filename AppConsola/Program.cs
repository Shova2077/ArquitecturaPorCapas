using System.IO.Pipes;
using EjerciciosPOO3;

List<Vehiculo> vehiculos = new List<Vehiculo>()
{
    new Auto("Lamborghini", "Gallardo", 2015, 2),
    new Moto("Susuki", "Hayabusa", 2018, false),
    new Moto("Susuki", "V-Strom", 2015, true)
};

foreach (Vehiculo v in vehiculos)
{
    Console.WriteLine(v.Describir());
}

try 
{
    Auto autoAntiguo = new Auto("Ford", "T", 1900, 2);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}




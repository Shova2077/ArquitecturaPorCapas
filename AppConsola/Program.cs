using System.IO.Pipes;
using EjerciciosPOO3;

bool menu = true;
while (menu == true)
{
    Console.WriteLine("---Menu de Ejercicios---");
    Console.WriteLine("1-Ejercicio 1");
    Console.WriteLine("2-Ejercicio 2");
    Console.WriteLine("3-Ejercicio 3");
    Console.WriteLine("0- Salir");
    int op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {
        case 0:
            menu = false;
        break;
        case 1:
            Ejercicio01();
        break;
        case 2:
            Ejercicio02();
        break;
        case 3:
            Ejercicio03();
        break;
    }
}


static void Ejercicio01()
{
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
}

static void Ejercicio02()
{
    List<Bebida> bebidas = new List<Bebida>()
    {
     new Cafe("Latte", 6500, true),
     new Agua("Villavicencio", 2000, false),
     new Jugo("Jugo", 4000, "Frutilla"),
    };

    foreach (Bebida b in bebidas)
    {
        Console.WriteLine(b.Preparar());
        Console.WriteLine(b.MostrarPrecio());
    }

    try
    {
        Cafe precioInvalido = new Cafe("Negativo", -20, false);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void Ejercicio03()
{



   
}
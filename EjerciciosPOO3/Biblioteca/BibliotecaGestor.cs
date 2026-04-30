namespace EjerciciosPOO3;

public class BibliotecaGestor
{
    public void ListarPublicaciones(List<Libro> libros, List<Revista> revistas)
    {
        foreach (Libro l in libros)
        {
            List<Libro> librosordenados = libros.OrderByDescending(l => l.Anio).ToList();
            Console.WriteLine("Ordenados por precio");
            Console.WriteLine(l.Describir());
        }
    }
}
using Ejercicio32Matricula;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Estudiante estudiante = new Estudiante();
            estudiante.IngresarDatos();
            estudiante.CalcularMatricula();
            estudiante.MostrarResultados();
        } while (DeseaContinuar());
    }

    static bool DeseaContinuar()
    {
        Console.Write("¿Desea calcular la matrícula de otro estudiante? (s/n): ");
        string respuesta = Console.ReadLine().ToLower();
        return respuesta == "s";
    }
}
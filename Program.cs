using _10_;

public class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Ingrese el número de créditos: ");
                int créditos = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el estrato: ");
                int estrato = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor por crédito: ");
                double valorcredito = double.Parse(Console.ReadLine());

                Estudiantes estudiantes = new Estudiantes(créditos, estrato, valorcredito);
                estudiantes.MostrarInformacion();

            }
        }
    }
}


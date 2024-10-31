using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32Matricula
{
    public class Estudiante
    {
        public int Creditos { get; set; }
        public int Estrato { get; set; }
        public double ValorCredito { get; set; } = 100000;
        public double Matricula { get; private set; }
        public double Subsidio { get; private set; }

        public void IngresarDatos()
        {
            Console.Write("Ingrese la cantidad de créditos que toma el estudiante: ");
            Creditos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el estrato del estudiante (1, 2, 3): ");
            Estrato = int.Parse(Console.ReadLine());
        }

        public void CalcularMatricula()
        {
            double costoCreditos = Creditos <= 20 ? Creditos * ValorCredito : (20 * ValorCredito) + ((Creditos - 20) * ValorCredito * 2);
            double descuento = ObtenerDescuento();
            Matricula = costoCreditos - (costoCreditos * descuento);
            Subsidio = ObtenerSubsidio();
        }

        private double ObtenerDescuento()
        {
            switch (Estrato)
            {
                case 1:
                    return 0.80; 
                case 2:
                    return 0.50;
                case 3:
                    return 0.30;
                default:
                    return 0;
            }
        }

        private double ObtenerSubsidio()
        {
            switch (Estrato)
            {
                case 1:
                    return 200000;
                case 2:
                    return 100000;
                default:
                    return 0;
            }
        }

        public void MostrarResultados()
        {
            Console.WriteLine($"El costo de la matrícula es: {Matricula:C}");
            Console.WriteLine($"El valor del subsidio es: {Subsidio:C}");
        }
    }
}

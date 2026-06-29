using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double horas;
            double pagoHora;
            double sueldo;
            double bono = 0;

            Console.Write("Ingrese el nombre del trabajador: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese las horas trabajadas: ");
            horas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el pago por hora: ");
            pagoHora = Convert.ToDouble(Console.ReadLine());

            // Método por valor
            sueldo = CalcularSueldo(horas, pagoHora);

            // Método por referencia
            CalcularBono(ref bono, sueldo);

            // Mostrar resultados
            Mostrar(nombre, sueldo, bono);

            Console.ReadKey();
        }

        // Función por valor
        static double CalcularSueldo(double horas, double pagoHora)
        {
            return horas * pagoHora;
        }

        // Método por referencia
        static void CalcularBono(ref double bono, double sueldo)
        {
            bono = sueldo * 0.10;
        }

        // Método para mostrar datos
        static void Mostrar(string nombre, double sueldo, double bono)
        {
            Console.WriteLine("\n------ BOLETA ------");
            Console.WriteLine("Trabajador : " + nombre);
            Console.WriteLine("Sueldo     : S/ " + sueldo);
            Console.WriteLine("Bono       : S/ " + bono);
            Console.WriteLine("Total      : S/ " + (sueldo + bono));
        }
    }
}



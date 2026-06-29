using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Class1;

namespace Otro
{
    internal class Program
    {


        static void Main(string[] args)
        {
            encabezado();
            // Variables Iniciales
            double peso = 80.0;
            double altura = 1.75;

            Console.WriteLine($"--- DATOS INICIALES ---");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"Altura: {altura} m\n");

            // IMPRIMIMOS EL IMC BASANDONOS EN LOS VALORES INICIALES
            double imc = CalcularPeso.CalcularIMC(peso, altura);
            Console.WriteLine($"Tu IMC actual es: {imc:F2}\n"); //26.12

            // POR REFERENCIA
            // Usamos ref para simular que la persona bajó 4 kilos en el gimnasio
            Console.WriteLine("Pasaron 2 meses de gimnasio y la persona perdió 4 kg...\n");
            CalcularPeso.AplicarPlanGimnasio(ref peso, 4.0);

            // El peso original cambió de forma permanente
            Console.WriteLine($"Ahora el peso es de {peso} kg");

            // Calculamos el nuevo IMC con el peso actualizado
            double nuevoImc = CalcularPeso.CalcularIMC(peso, altura);
            Console.WriteLine($"Tu nuevo IMC es: {nuevoImc:F2}");
        }
    }

}

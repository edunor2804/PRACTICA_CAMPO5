using System;

public class GestionAcademica
{
    public static class LogicaEstudiantil
    {
        public static double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public static void AplicarBono(ref double notaFinal, double puntosExtra)
        {
            notaFinal += puntosExtra;
        }
    }
}

namespace Escuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 14.5;
            double n2 = 12.0;
            double n3 = 16.0;
            double bono = 1.5;

            double promedio = GestionAcademica.LogicaEstudiantil.CalcularPromedio(n1, n2, n3);
            Console.WriteLine($"Promedio inicial: {promedio:F2}");

            GestionAcademica.LogicaEstudiantil.AplicarBono(ref promedio, bono);
            Console.WriteLine($"Promedio final mas bono: {promedio:F2}");

            string profesor = " Profesor Pedro Castillo";
            Console.WriteLine($"Calificado por: {profesor}");
        }
    }
}



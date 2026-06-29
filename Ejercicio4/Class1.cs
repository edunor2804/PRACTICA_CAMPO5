public class Class1
{
    public static void encabezado()
    {
        Console.WriteLine("╔═════════════════════════════════════╗");

        Console.WriteLine("║         Calcular mi Peso             ║");

        Console.WriteLine("╚═════════════════════════════════════╝");
    }
    public static class CalcularPeso
    {
        // MÉTODO POR VALOR
        public static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura); // Fórmula del IMC
        }

        // MÉTODO POR REFERENCIA
        public static void AplicarPlanGimnasio(ref double pesoActual, double kilosPerdidos)
        {
            pesoActual = pesoActual - kilosPerdidos; // Altera el peso declarado inciialmente
        }
    }
}


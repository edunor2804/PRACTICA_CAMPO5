using System;

internal class CambiodeDinero
{
    public static double ConvertirSolesADolares(double montoSoles, double tipoCambio)
    {
        return montoSoles / tipoCambio;
    }

    public static void ProcesarRetiro(ref double saldoActual, double montoRetirar)
    {
        if (montoRetirar <= saldoActual)
        {
            saldoActual = saldoActual - montoRetirar;
            Console.WriteLine("Retiro exitoso. Guardando nuevo saldo...");
        }
        else
        {
            Console.WriteLine("Error: Fondos insuficientes para la operación.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== CAJERO AUTOMÁTICO ===");

        double saldoCuenta = 50000;
        double tipoCambioHoy = 3.75;

        Console.WriteLine("Tu saldo actual es: S/. " + saldoCuenta);
        Console.Write("¿Cuánto dinero deseas retirar?: ");

        if (double.TryParse(Console.ReadLine(), out double monto))
        {
            ProcesarRetiro(ref saldoCuenta, monto);

            Console.WriteLine("\nSaldo final en Soles: S/. " + saldoCuenta);

            double saldoEnDolares = ConvertirSolesADolares(saldoCuenta, tipoCambioHoy);
            Console.WriteLine("Tu saldo equivalente en Dólares es: $" + Math.Round(saldoEnDolares, 2));
        }
        else
        {
            Console.WriteLine("Monto inválido ingresado.");
        }

        Console.ReadKey();
    }
}

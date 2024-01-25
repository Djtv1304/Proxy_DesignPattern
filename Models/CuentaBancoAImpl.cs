namespace Proxy_DesignPattern.Models
{
    public class CuentaBancoAImpl : ICuenta
    {

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {

            double saldoActual = cuenta.saldoInicial - monto;
            cuenta.saldoInicial = saldoActual;
            Console.WriteLine("Saldo actual: " + cuenta.saldoInicial);

            return cuenta;

        }

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {

            double saldoActual = cuenta.saldoInicial + monto;
            cuenta.saldoInicial = saldoActual;
            Console.WriteLine("Saldo actual: " + cuenta.saldoInicial);

            return cuenta;

        }

        public string mostrarSaldo(Cuenta cuenta)
        {

            return("Saldo actual: " + cuenta.saldoInicial);

        }

    }
}

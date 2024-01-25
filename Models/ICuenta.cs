namespace Proxy_DesignPattern.Models
{
    public interface ICuenta
    {

        Cuenta retirarDinero(Cuenta cuenta, double monto);
        Cuenta depositarDinero(Cuenta cuenta, double monto);
        string mostrarSaldo(Cuenta cuenta);

    }
}

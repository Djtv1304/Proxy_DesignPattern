namespace Proxy_DesignPattern.Models
{
    public class Cuenta
    {

        public int idCuenta { get; set; }
        public string usuario { get; set;}
        public double saldoInicial { get; set; }

        public Cuenta(int idCuenta, string usuario, double saldoInicial)
        {

            this.idCuenta = idCuenta;
            this.usuario = usuario;
            this.saldoInicial = saldoInicial;

        }

    }
}

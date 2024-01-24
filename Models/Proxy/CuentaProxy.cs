namespace Proxy_DesignPattern.Models.Proxy
{
    public class CuentaProxy : ICuenta
    {
        
        private CuentaBancoAImpl cuentaReal;

        public Cuenta depositarDinero(Cuenta cuenta, double monto)
        {
            
            if (cuentaReal == null)
            {

                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.depositarDinero(cuenta, monto);

            }
            else
            {

                return cuentaReal.depositarDinero(cuenta, monto);

            }

        }

        public void mostrarSaldo(Cuenta cuenta)
        {
            
            if(cuentaReal == null)
            {

                cuentaReal = new CuentaBancoAImpl();
                cuentaReal.mostrarSaldo(cuenta);

            }
            else
            {

                cuentaReal.mostrarSaldo(cuenta);

            }

        }

        public Cuenta retirarDinero(Cuenta cuenta, double monto)
        {
            
            if (cuentaReal == null)
            {

                cuentaReal = new CuentaBancoAImpl();
                return cuentaReal.retirarDinero(cuenta, monto);

            }
            else
            {

                return cuentaReal.retirarDinero(cuenta, monto);

            }

        }
    }
}
